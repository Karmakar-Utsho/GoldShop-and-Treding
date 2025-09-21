# Jewellery Shop Management System (JSMS)

A comprehensive desktop application built with C# and database integration for managing jewelry shop operations, including inventory management, sales tracking, customer management, and investment features.

## 📋 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Technology Stack](#technology-stack)
- [System Architecture](#system-architecture)
- [Installation](#installation)
- [Usage](#usage)
- [Database Schema](#database-schema)
- [User Roles](#user-roles)
- [Screenshots](#screenshots)
- [Contributing](#contributing)
- [License](#license)

## 🏪 Overview

The Jewellery Shop Management System is a powerful digital solution designed to streamline and automate jewelry business operations. It provides role-based access for both administrators and customers, featuring real-time data synchronization across multiple branches and comprehensive business management capabilities.

**Key Benefits:**
- Automates routine business tasks
- Reduces operational errors  
- Enhances customer experience
- Provides detailed analytics and reporting
- Supports multi-branch operations

## ✨ Features

### 🔐 Authentication & User Management
- **User Registration**: New user signup with personal details
- **Role-based Login**: Separate access for Admin and Customer roles
- **Password Recovery**: Email-based password reset functionality
- **Branch Selection**: Users can select preferred branch locations
- **Profile Management**: View and edit personal information

### 👨‍💼 Admin Features

#### Sales & Revenue Management
- **Product Sales Tracking**: Complete sales history with user details, product info, pricing, and payment methods
- **Advanced Filtering**: Sort by price (high/low) and filter by specific dates
- **Revenue Analytics**: Real-time calculation of total sales and payment method breakdown
- **Report Generation**: Printable detailed sales reports for analysis

#### Customer Management
- **Customer Database**: Comprehensive customer profiles with contact information and account activity
- **Search Functionality**: Quick customer lookup by username, email, or other details
- **Role Management**: User role classification and management
- **Activity Tracking**: Monitor account creation and update history

#### Product Management
- **Inventory Control**: Complete CRUD operations for products
- **Product Catalog**: Detailed product listings with categories, prices, and quantities
- **Search & Filter**: Quick product search by name or keywords
- **Stock Management**: Real-time inventory tracking

#### Financial Management
- **Bill Management**: Automated invoice generation with print capabilities
- **Investment Tracking**: Gold investment management with real-time market pricing
- **Payment Processing**: Multiple payment method support (Cash, Bkash, Nagad, COD)

#### Quality Control
- **Review Management**: Customer review moderation with approval system
- **Rating System**: Star-based rating collection and display

### 🛍️ Customer Features

#### Shopping Experience
- **Product Browsing**: Featured and non-featured item catalogs
- **Product Variants**: Multiple options for jewelry pieces (18K/22K gold)
- **Visual Preview**: Product image display for informed selection
- **Smart Cart**: Add to cart with quantity controls and real-time stock checking

#### Investment Platform
- **Gold Investment**: Buy gold in standard weights (1g, 5g, 10g)
- **Market Price Integration**: Real-time gold price display
- **Investment Tracking**: Monitor purchase history and current holdings
- **Gold Selling**: Sell invested gold with current market rate calculations

#### User Experience
- **Profile Management**: Update personal information and profile pictures
- **Order Management**: Review and modify cart contents before checkout
- **Payment Options**: Multiple secure payment methods
- **Review System**: Submit ratings and feedback for products/services

## 💻 Technology Stack

- **Frontend**: C# Windows Forms (.NET Framework)
- **Backend**: C# with Object-Oriented Programming principles
- **Database**: SQL Server with stored procedures
- **Architecture**: Desktop application with database integration
- **Development Environment**: Visual Studio

## 🏗️ System Architecture

The system follows a layered architecture approach:

1. **Presentation Layer**: Windows Forms UI
2. **Business Logic Layer**: C# classes implementing business rules
3. **Data Access Layer**: SQL Server database operations
4. **Database Layer**: Relational database with optimized schema

## 📊 Database Schema

### Core Tables
- **USER_TABLE**: User authentication and profile information
- **PRODUCT_TABLE**: Product inventory and catalog
- **PRODUCT_BUY_TABLE**: Sales transaction records
- **INVESTMENT_TABLE**: Gold investment tracking
- **REVIEW_TABLE**: Customer feedback and ratings
- **PROFILE_TABLE**: Extended user profile information
- **CONFIG_TABLE**: System configuration settings

## 👥 User Roles

### Administrator
- Full system access and control
- Sales and revenue monitoring
- Customer and product management
- Investment oversight
- Review moderation
- Report generation

### Customer
- Product browsing and purchasing
- Cart and order management
- Gold investment features
- Profile management
- Review submission
- Multi-payment options

## 🚀 Installation

1. **Prerequisites**
   - Windows 10/11
   - .NET Framework 4.7.2 or higher
   - SQL Server 2017 or higher
   - Visual Studio 2019 or higher (for development)

2. **Database Setup**
   ```sql
   -- Run the provided SQL scripts to create tables
   -- Import sample data if needed
   -- Configure connection string in app.config
   ```

3. **Application Setup**
   ```bash
   git clone <repository-url>
   cd jewellery-shop-management
   # Open solution in Visual Studio
   # Build and run the application
   ```

## 📱 Usage

### For Administrators
1. Login with admin credentials
2. Access the admin dashboard
3. Manage products, customers, and sales
4. Generate reports and monitor analytics
5. Review and approve customer feedback

### For Customers
1. Register or login to your account
2. Browse and select products
3. Add items to cart with desired specifications
4. Choose payment method and complete purchase
5. Invest in gold or manage existing investments
6. Submit reviews and manage profile

## 📸 Screenshots

The system includes intuitive interfaces for:

- Login and Registration pages
<img width="907" height="578" alt="image" src="https://github.com/user-attachments/assets/66afca3b-eeb7-454f-afe8-26a683e2953b" />
  
- Admin dashboard and management panels
 <img width="940" height="582" alt="image" src="https://github.com/user-attachments/assets/4de85a68-e25e-4e91-8e8d-f2e7210f0e39" />

- Customer shopping interface
 <img width="959" height="615" alt="image" src="https://github.com/user-attachments/assets/1360a49c-b4b5-4457-a52c-e7ce11ff5eb9" />

- Product catalogs and detailed views
 <img width="953" height="565" alt="image" src="https://github.com/user-attachments/assets/341d4ac2-b23b-400e-8cbb-e3683b89c294" />

- Payment processing screens
<img width="952" height="691" alt="image" src="https://github.com/user-attachments/assets/68ba0ec1-3950-4749-86a0-da3527ba398d" />

- Investment management interface
  <img width="948" height="355" alt="image" src="https://github.com/user-attachments/assets/f8ffdcbe-cfb3-4bd2-8407-7304ad2c615c" />

- Review and rating system
  <img width="853" height="584" alt="image" src="https://github.com/user-attachments/assets/bce42faa-932f-42bf-bf26-e3dc59852ddb" />


## 🤝 Contributing

This project was developed as part of CSC2210: Object Oriented Programming 2 course at American International University-Bangladesh (AIUB).

### Team Members
- **UTSHO KARMAKAR** (23-53327-3)
- **WASHIF SHADMAN GALIB** (23-55056-3)  
- **MD. RAKIBUL HASSAN** (23-52453-2)
- **MD. ABDUL MUBIN BISWAS** (23-53892-3)

**Supervised By:** Dr. Md. Iftekharul Mobin

## 📝 License

This project is developed for educational purposes as part of university coursework. 

## 📞 Support

For questions or support regarding this system, please contact the development team or refer to the project documentation.

---

*This system demonstrates the practical application of Object-Oriented Programming principles in developing real-world business solutions for jewelry retail management.*
