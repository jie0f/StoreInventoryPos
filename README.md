# StoreInventoryPos

**StoreInventoryPos** is a comprehensive Windows Forms (WinForms) application built in C# for managing retail store operations such as inventory, sales, promotions, refunds, and reporting.

---

## 🚀 Features

- 🔐 **User Roles**: Admin, Manager, and Staff with custom dashboards
- 💼 **Inventory Management**: Track products by name, quantity, size, and price
- 💵 **Sales Processing**: Record sales, apply promo codes, and choose payment types
- 🔁 **Refund Management**: Manage and track refunds with reasons and related sales
- 📊 **Sales and Refund Reports**: Generate searchable and filterable reports
- 🔍 **Search & Filter**: Search by Sale ID or product name
- 🖨️ **Print Support**: Print receipts or reports (integrated via `System.Drawing.Printing`)
- 🗃️ **Database Integration**: Uses SQL Server for all data storage and relationships

---

## 🛠️ Tech Stack

- **Frontend**: Windows Forms (.NET Framework)
- **Backend**: C#
- **Database**: Microsoft SQL Server
- **Data Access**: ADO.NET using `SqlConnection`, `SqlCommand`, and `SqlDataAdapter`

---

## 📁 Project Structure

StoreInventoryPos/
│
├── Forms/
│ ├── adminDashboard.cs
│ ├── managerDashboard.cs
│ ├── staffDashboard.cs
│
├── DataAccess.cs // SQL interaction logic
├── Users.cs // Static role/user session data
├── Program.cs // Entry point
├── App.config // DB connection string
└── README.md
