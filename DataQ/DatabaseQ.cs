using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Store.Models;
using Store.Forms;

namespace Store.DataQ
{
    internal class DatabaseQ
    {
        private string connectionString;


        public DatabaseQ()
        {
            // Retrieve the connection string from App.config
            connectionString = ConfigurationManager.ConnectionStrings["StoreShop"].ConnectionString;

        }




        public int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();

                    // Debugging: Log the query and parameters
                    Console.WriteLine($"Executing Query: {query}");
                    foreach (var param in parameters)
                    {
                        Console.WriteLine($"{param.ParameterName}: {param.Value}");
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Rows affected: {rowsAffected}");

                    return rowsAffected;
                }
            }
        }


        public void ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }






        public object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }






        public DataTable ExecuteReader(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }





        // Method to test the database connection
        public bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Optionally, log the exception or display a message
                System.Windows.Forms.MessageBox.Show("Database Connection Failed: " + ex.Message);
                return false;
            }
        }





        // Create (Register a New User)
        public int CreateUser(User user)
        {
            string query = "INSERT INTO tblUser (Username, [Password], [Role], Email, Address, Mobile) VALUES (@Username, @Password, @Role, @Email, @Address, @Mobile); SELECT CAST(scope_identity() AS int);";

            SqlParameter[] parameters = new SqlParameter[]
            {
                 new SqlParameter("@Username", user.Username),
                 new SqlParameter("@Password", user.Password),
                 new SqlParameter("@Role", user.Role),
                 new SqlParameter("@Email", user.Email),
                 new SqlParameter("@Address", user.Address),
                 new SqlParameter("@Mobile", user.Mobile)

            };

            // Execute the query and return the new UserID
            return (int)ExecuteScalar(query, parameters);
        }

        public string GetUsernameById(int userId)
        {
            string username = string.Empty;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Username FROM tblUser WHERE UserID = @UserID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        username = result.ToString();
                    }
                }
            }
            return username;
        }




        public void CreateUserProfile(UserProfile profile)
        {
            string query = @"
            INSERT INTO tblUserProfile (UserID, Username, ProfilePicture, Email, Address, Mobile)
            VALUES (@UserID, @Username, @ProfilePicture, @Email, @Address, @Mobile);";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@UserID", profile.UserID),
            new SqlParameter("@Username", string.IsNullOrEmpty(profile.Username) ? string.Empty : profile.Username),
            new SqlParameter("@ProfilePicture", profile.ProfilePicture ?? (object)DBNull.Value),
            new SqlParameter("@Email", string.IsNullOrEmpty(profile.Email) ? string.Empty : profile.Email),
            new SqlParameter("@Address", string.IsNullOrEmpty(profile.Address) ? string.Empty : profile.Address),
            new SqlParameter("@Mobile", string.IsNullOrEmpty(profile.Mobile) ? string.Empty : profile.Mobile)
            };

            ExecuteNonQuery(query, parameters);
        }





        // Read (Get User by Username)
        public User GetUserByUsername(string username)
        {
            string query = "SELECT * FROM tblUser WHERE Username COLLATE SQL_Latin1_General_CP1_CS_AS = @Username";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username)
            };

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                Password = reader.GetString(reader.GetOrdinal("Password")),
                                Role = reader.GetString(reader.GetOrdinal("Role")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Address = reader.GetString(reader.GetOrdinal("Address")),
                                Mobile = reader.GetString(reader.GetOrdinal("Mobile")),
                                IsActive = reader.GetInt32(reader.GetOrdinal("IsActive"))
                                // Add other fields as necessary
                            };
                        }
                        else
                        {
                            return null; // User not found
                        }
                    }
                }
            }
        }





        // Read (Get User by ID)
        public User GetUserByID(int userId)
        {
            string query = "SELECT * FROM tblUser WHERE UserID = @UserID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", userId)
            };

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                Password = reader.GetString(reader.GetOrdinal("Password")),
                                Role = reader.GetString(reader.GetOrdinal("Role")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Address = reader.GetString(reader.GetOrdinal("Address")),
                                Mobile = reader.GetString(reader.GetOrdinal("Mobile"))
                                // Add other fields as necessary
                            };
                        }
                        else
                        {
                            return null; // User not found
                        }
                    }
                }
            }
        }





        public DataRow GetUserById(int userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT UserID, Username, Role, Email, Address, Mobile, CreatedDate, UpdatedDate
                FROM tblUser
                WHERE UserID = @UserID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable userTable = new DataTable();
                    adapter.Fill(userTable);

                    // Return the first row if the user exists, otherwise return null
                    return userTable.Rows.Count > 0 ? userTable.Rows[0] : null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching user by ID: {ex.Message}");
            }
        }





        public bool ResetUserPassword(string email, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {


                    string query = @"
                UPDATE tblUser
                SET Password = @Password
                WHERE Email = @Email";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error resetting password: {ex.Message}");
            }
        }





        public DataRow GetUserProfileById(int userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT 
                    ProfileID, 
                    UserID, 
                    Username, 
                    ProfilePicture, 
                    Email, 
                    Address,
                    Mobile
                FROM tblUserProfile
                WHERE UserID = @UserID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable resultTable = new DataTable();

                    adapter.Fill(resultTable);

                    if (resultTable.Rows.Count > 0)
                    {
                        return resultTable.Rows[0]; // Return the first row
                    }
                    else
                    {
                        return null; // No matching user profile found
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching user profile: {ex.Message}");
            }
        }





        public void UpdateUserProfile(int userId, string profilePicture, string email, string address, string mobile)
        {
            string query = @"
        BEGIN TRANSACTION;

        -- Update tblUserProfile
        IF EXISTS (SELECT 1 FROM tblUserProfile WHERE UserID = @UserID)
        BEGIN
            UPDATE tblUserProfile
            SET ProfilePicture = @ProfilePicture,
                Email = @Email,
                Address = Address,
                Mobile = @Mobile
            WHERE UserID = @UserID;
        END
        ELSE
        BEGIN
            INSERT INTO tblUserProfile (UserID, ProfilePicture, Email, Address, Mobile)
            VALUES (@UserID, @ProfilePicture, @Email, @Address, @Mobile);
        END

        -- Update tblUser
        UPDATE tblUser
        SET Email = @Email, UpdatedDate = GETDATE()
        WHERE UserID = @UserID;

        COMMIT TRANSACTION;
    ";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", userId),
                new SqlParameter("@ProfilePicture", string.IsNullOrWhiteSpace(profilePicture) ? (object)DBNull.Value : profilePicture),
                new SqlParameter("@Email", string.IsNullOrWhiteSpace(email) ? (object)DBNull.Value : email),
                new SqlParameter("@Address", string.IsNullOrWhiteSpace(address) ? (object)DBNull.Value : address),
                new SqlParameter("@Mobile", string.IsNullOrWhiteSpace(mobile) ? (object)DBNull.Value : mobile)
            };

            ExecuteNonQuery(query, parameters);
        }



        // Update (Update User Details)
        public void UpdateUser(User user)
        {
            string query = "UPDATE tblUser SET Username = @Username, [Password] = @Password, Role = @Role, Email = @Email, Address = @Address, Mobile = @Mobile, UpdatedDate = GETDATE() WHERE UserID = @UserID";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Username", user.Username),
            new SqlParameter("@Password", user.Password),
            new SqlParameter("@Role", user.Role),
            new SqlParameter("@Email", user.Email),
            new SqlParameter("@Address", user.Address),
            new SqlParameter("@Mobile", user.Mobile),
            new SqlParameter("@UserID", user.UserID)
            };

            ExecuteNonQuery(query, parameters);
        }





        public void AddProductBuy(int userId,
                          string productName,
                          int karat,
                          decimal price,
                          int quantity,
                          string paymentMethod)
        {
            // 1) First, load the user’s details
            string userSql = @"
            SELECT Username
            FROM tblUser
            WHERE UserID = @UserID";

            var userTable = ExecuteReader(userSql, new SqlParameter("@UserID", userId));
            if (userTable.Rows.Count == 0)
                throw new Exception($"No user found with ID {userId}");

            DataRow u = userTable.Rows[0];
            string username = u["Username"].ToString();


            // 2) Now insert into ProductsBuy with all columns
            string insert = @"
            INSERT INTO dbo.ProductsBuy
            (UserID, Username, ProductName, Karat, Price, Quantity, PaymentMethod)
            VALUES
            (@UserID, @Username, @ProductName, @Karat, @Price, @Quantity, @PaymentMethod)";


            var parameters = new[]
            {
        new SqlParameter("@UserID",      userId),
        new SqlParameter("@Username",    username),
        new SqlParameter("@ProductName", productName),
        new SqlParameter("@Karat",       karat),
        new SqlParameter("@Price",       price),
        new SqlParameter("@Quantity",    quantity),
        new SqlParameter("@PaymentMethod", paymentMethod ?? (object)DBNull.Value),};

            ExecuteNonQuery(insert, parameters);
        }





        public void SetGramPrice(decimal price)
        {
            string q = "UPDATE dbo.Config SET ConfigValue = @Price WHERE ConfigKey = 'GramPrice'";
            ExecuteNonQuery(q, new[] { new SqlParameter("@Price", price) });
        }


        public decimal GetGramPrice()
        {
            var table = ExecuteReader("SELECT ConfigValue FROM dbo.Config WHERE ConfigKey='GramPrice'");
            return table.Rows.Count > 0 ? Convert.ToDecimal(table.Rows[0][0]) : 0m;
        }







        public void AddInvestment(int userId,
                          string username,
                          decimal quantity,
                          decimal totalSpent,
                          decimal gramPrice)
        {
            // 1) See if the user already has an InvestmentDetails row
            var existing = ExecuteReader(
                "SELECT QuantityBought, TotalSpent FROM dbo.InvestmentDetails WHERE UserID = @UserID",
                new SqlParameter("@UserID", userId)
            );

            if (existing.Rows.Count == 0)
            {
                // –––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––
                // No row yet → INSERT brand new
                string insert = @"
            INSERT INTO dbo.InvestmentDetails
                (UserID, Username, QuantityBought, TotalSpent, GramPriceAtBuy)
            VALUES
                (@UserID,@Username, @QuantityBought,@TotalSpent,@GramPriceAtBuy)";
                var ps = new[]
                {
            new SqlParameter("@UserID",          userId),
            new SqlParameter("@Username",        username),
            new SqlParameter("@QuantityBought",  quantity),
            new SqlParameter("@TotalSpent",      totalSpent),
            new SqlParameter("@GramPriceAtBuy",  gramPrice)
        };
                ExecuteNonQuery(insert, ps);
            }
            else
            {
                // –––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––
                // Already have a row (even if Qty is 0 after selling) → accumulate
                var row = existing.Rows[0];
                decimal oldQty = Convert.ToDecimal(row["QuantityBought"]);
                decimal oldSpent = Convert.ToDecimal(row["TotalSpent"]);

                decimal newQty = oldQty + quantity;
                decimal newSpent = oldSpent + totalSpent;
                // recompute average buy price if you care, or just leave GramPriceAtBuy unchanged


                string update = @"
                UPDATE dbo.InvestmentDetails
                SET
                QuantityBought  = @NewQuantity,
                TotalSpent      = @NewTotal
                WHERE UserID = @UserID";
                var ps = new[]
                {
            new SqlParameter("@NewQuantity", newQty),
            new SqlParameter("@NewTotal",    newSpent),

            new SqlParameter("@UserID",      userId)
        };
                ExecuteNonQuery(update, ps);
            }
        }





        // Record sell
        public void AddSell(int investmentId, decimal quantitySold, decimal totalReceived)
        {
            // fetch original
            var table = ExecuteReader("SELECT QuantityBought, TotalSpent, GramPriceAtBuy FROM InvestmentDetails WHERE InvestmentID=@ID", new SqlParameter("@ID", investmentId));
            if (table.Rows.Count == 0) throw new Exception("Invalid investment");
            var row = table.Rows[0];
            decimal qtyBought = Convert.ToDecimal(row["QuantityBought"]);
            decimal spent = Convert.ToDecimal(row["TotalSpent"]);
            decimal buyPrice = Convert.ToDecimal(row["GramPriceAtBuy"]);
            decimal newQty = qtyBought - quantitySold;
            decimal profit = totalReceived - (quantitySold * buyPrice);
            string q = @"UPDATE dbo.InvestmentDetails SET
                          QuantityBought=@QuantityBought,
                          QuantitySold=@QuantitySold,
                          TotalReceived=@TotalReceived,
                          Profit=@Profit,
                          SellDate=GETDATE()
                          WHERE InvestmentID=@ID";
            var ps = new[] {
                new SqlParameter("@QuantityBought", newQty),
                new SqlParameter("@QuantitySold", quantitySold),
                new SqlParameter("@TotalReceived", totalReceived),
                new SqlParameter("@Profit", profit),
                new SqlParameter("@ID", investmentId)
            };
            ExecuteNonQuery(q, ps);
        }



        public DataTable GetInvestment(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd;

                if (userId == 0)
                {
                    // Get all investments
                    cmd = new SqlCommand("SELECT * FROM InvestmentDetails", conn);
                }
                else
                {
                    // Get specific user's investments
                    cmd = new SqlCommand("SELECT * FROM InvestmentDetails WHERE UserID = @UserID", conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                }

                DataTable dt = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }

                return dt;


            }
        }

        public DataTable SearchInvestmentsByUsername(string usernameFilter)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                if (string.IsNullOrWhiteSpace(usernameFilter))
                {
                    cmd.CommandText = "SELECT * FROM dbo.InvestmentDetails";
                }
                else
                {
                    cmd.CommandText = @"
                SELECT * 
                FROM dbo.InvestmentDetails
                WHERE Username LIKE '%' + @Filter + '%'";
                    cmd.Parameters.AddWithValue("@Filter", usernameFilter);
                }
                var dt = new DataTable();
                using (var da = new SqlDataAdapter(cmd))
                    da.Fill(dt);
                return dt;
            }
        }




        public DataTable GetProductsByDate(DateTime date, string sortOrder = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                ProductBuyID,
                UserID,
                ProductName,
                Karat,
                Price,
                Quantity,
                (Price * Quantity) AS TotalAmount,
                OrderDate,
                PaymentMethod,
                Username
            FROM dbo.ProductsBuy
            WHERE CAST(OrderDate AS DATE) = @OrderDate";

                if (!string.IsNullOrEmpty(sortOrder))
                {
                    // sortOrder = "DESC" or "ASC"
                    query += $" ORDER BY TotalAmount {sortOrder}";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderDate", date.Date);

                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                return dt;
            }
        }

        public decimal GetTotalSellByDate(DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT ISNULL(SUM(Price * Quantity),0) 
                         FROM dbo.ProductsBuy 
                         WHERE CAST(OrderDate AS DATE) = @OrderDate";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderDate", date.Date);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return Convert.ToDecimal(result);
            }
        }


        // Get all users except Admin
        public DataTable GetAllUsersExceptAdmin()
        {
            string query = @"
        SELECT UserID, Username, Role, Email, Address, Mobile, CreatedDate, UpdatedDate, IsActive
        FROM dbo.tblUser
        WHERE Role <> 'Admin'";
            return ExecuteReader(query);
        }

        // Search users by username, email, or mobile (excluding Admin)
        public DataTable SearchUsers(string keyword)
        {
            string query = @"
        SELECT UserID, Username, Role, Email, Address, Mobile, CreatedDate, UpdatedDate, IsActive
        FROM dbo.tblUser
        WHERE Role <> 'Admin' 
        AND (Username LIKE '%' + @Keyword + '%' 
             OR Email LIKE '%' + @Keyword + '%' 
             OR Mobile LIKE '%' + @Keyword + '%')";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Keyword", keyword ?? "")
            };
            return ExecuteReader(query, parameters);
        }

        // Toggle user IsActive status
        public void ToggleUserActive(int userId, bool isActive)
        {
            string query = "UPDATE dbo.tblUser SET IsActive = @IsActive, UpdatedDate = GETDATE() WHERE UserID = @UserID";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@IsActive", isActive ? 1 : 0),
        new SqlParameter("@UserID", userId)
            };
            ExecuteNonQuery(query, parameters);
        }


        //product related codes
        // ==================== Product CRUD ====================

        // Create (Insert Product)
        public void AddProduct(string name, string category, decimal price, int quantity)
        {
            string query = @"
        INSERT INTO dbo.Product (ProductName, Category, Price, Quantity, Created_at)
        VALUES (@Name, @Category, @Price, @Quantity, GETDATE())";

            SqlParameter[] parameters =
            {
        new SqlParameter("@Name", name),
        new SqlParameter("@Category", category),
        new SqlParameter("@Price", price),
        new SqlParameter("@Quantity", quantity)
    };

            ExecuteNonQuery(query, parameters);
        }

        // Read (Get All Products)
        public DataTable GetAllProducts()
        {
            string query = @"SELECT Id, ProductName, Category, Price, Quantity, Created_at, Updated_at 
                     FROM dbo.Product ORDER BY Id DESC";
            return ExecuteReader(query);
        }

        // Update Product
        public void UpdateProduct(int id, string name, string category, decimal price, int quantity)
        {
            string query = @"
        UPDATE dbo.Product
        SET ProductName = @Name,
            Category = @Category,
            Price = @Price,
            Quantity = @Quantity,
            Updated_at = GETDATE()
        WHERE Id = @Id";

            SqlParameter[] parameters =
            {
        new SqlParameter("@Id", id),
        new SqlParameter("@Name", name),
        new SqlParameter("@Category", category),
        new SqlParameter("@Price", price),
        new SqlParameter("@Quantity", quantity)
    };

            ExecuteNonQuery(query, parameters);
        }

        // Delete Product
        public void DeleteProduct(int id)
        {
            string query = @"DELETE FROM dbo.Product WHERE Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            ExecuteNonQuery(query, parameters);
        }

        // Search Products
        public DataTable SearchProducts(string keyword)
        {
            string query = @"
        SELECT Id, ProductName, Category, Price, Quantity, Created_at, Updated_at
        FROM dbo.Product
        WHERE ProductName LIKE '%' + @Keyword + '%' 
           OR Category LIKE '%' + @Keyword + '%'";
            SqlParameter[] parameters = { new SqlParameter("@Keyword", keyword) };
            return ExecuteReader(query, parameters);
        }


        public DataTable GetAllSales()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT [ProductBuyID],
                                    [UserID],
                                    [ProductName],
                                    [Karat],
                                    [Price],
                                    [Quantity],
                                    [OrderDate],
                                    [PaymentMethod],
                                    [Username]
                             FROM [dbo].[ProductsBuy]";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching sales data: " + ex.Message);
            }
            return dt;
        }




    }
}

