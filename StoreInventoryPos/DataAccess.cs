using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using StoreInventoryPos;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WFAManagementPro
{
    class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        private readonly string connectionString = @"Data Source=JIEAF-PC\SQLEXPRESS;Initial Catalog=ShoeStorePOS;Persist Security Info=True;User ID=sa;Password=427342;";

        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(connectionString);
            this.Sqlcon.Open();
        }
        //
        /* private void QueryText(string query)
         {
             this.Sqlcom = new SqlCommand(query, this.Sqlcon);
         }

         public DataSet ExecuteQuery(string sql)
         {
             try
             {
                 this.QueryText(sql);
                 this.Sda = new SqlDataAdapter(this.Sqlcom);
                 this.Ds = new DataSet();
                 this.Sda.Fill(this.Ds);
                 return this.Ds;
             }
             catch (Exception exc)
             {
                 return null;
             }
         }

         public int ExecuteUpdateQuery(string sql)
         {
             this.QueryText(sql);
             int u = this.Sqlcom.ExecuteNonQuery();
             return u;
         }
        */
        //Query Function








        //////////////////////////////////// Login Validation////////////////////////////////
        public bool ValidateUser(string username, string password, out string role)
        {
            role = string.Empty;
            string sql = "SELECT Role FROM Users WHERE Username = @username AND Password = @password";
            SqlCommand cmd = new SqlCommand(sql, this.Sqlcon);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    role = reader["Role"].ToString();
                    return true;
                }
            }
            return false;
        }





        ///////////////////////////////////////User CRUD Query//////////////////////////////
        //Create User
        public int InsertUser(string username, string password, string fullname, string role)
        {
            string sql = "INSERT INTO Users (Username, Password,Fullname,Role) VALUES (@username, @password,@fullname,@role)";
            SqlCommand cmd = new SqlCommand(sql, this.Sqlcon);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@fullname", fullname);
            cmd.Parameters.AddWithValue("@role", role);

            return cmd.ExecuteNonQuery();
        }

        //Update User

        public int UpdateUser(string username, string fullname, string password, string role)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Fullname = @fullname, Password = @Password, Role = @Role WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Fullname", fullname);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);


                conn.Open();
                return cmd.ExecuteNonQuery();
            }
#pragma warning restore CS0618 // Type or member is obsolete
        }

        //Delete User

        public int DeleteUser(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Users WHERE Username = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        ///////////////////////////////////////Product CRUD Query /////////////////////////////
        //Create Product

        public int InsertProduct(string productname, double cost, double price, int quantity, string size)
        {
            string sql = "INSERT INTO Product (ProductName, Cost, Price, Quantity, Size) VALUES (@Productname, @Cost, @Price, @Quantity, @Size)";
            SqlCommand cmd = new SqlCommand(sql, this.Sqlcon);

            cmd.Parameters.AddWithValue("@ProductName", productname);
            cmd.Parameters.AddWithValue("@Cost", cost);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.Parameters.AddWithValue("@Size", size);

            return cmd.ExecuteNonQuery();
        }

        //Update Product
        public int UpdateProduct(string productID, string productname, string cost, string price, string quantity, string size)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Product SET ProductName = @productname, Cost = @cost, Price = @price, Quantity = @quantity, Size = @size WHERE ProductID = @productID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ProductID", int.Parse(productID));
                cmd.Parameters.AddWithValue("@ProductName", productname);
                cmd.Parameters.AddWithValue("@Cost", double.Parse(cost));
                cmd.Parameters.AddWithValue("@Price", double.Parse(price));
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(quantity));
                cmd.Parameters.AddWithValue("@Size", int.Parse(size));

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
        //Delete Product

        public int DeleteProduct(string productID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Product WHERE ProductID = @productID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", int.Parse(productID));
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        ///////////////////////////////////////PromoCode CRUD Query /////////////////////////////

        //Create Promo
        public int InsertCode(string code, string discountpercent)
        {
            string sql = "INSERT INTO PromoCode (Code, DiscountPercent) VALUES (@Code, @discountpercent)";
            SqlCommand cmd = new SqlCommand(sql, this.Sqlcon);

            cmd.Parameters.AddWithValue("@Code", code);
            cmd.Parameters.AddWithValue("@discountpercent", discountpercent);

            return cmd.ExecuteNonQuery();
        }

        //Upadte Promo
        public int UpdateCode(string code, string discountpercent)
        {
            string sql = "UPDATE PromoCode SET DiscountPercent = @discountpercent WHERE Code = @code";
            SqlCommand cmd = new SqlCommand(sql, this.Sqlcon);

            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@discountpercent", discountpercent);

            return cmd.ExecuteNonQuery();
        }


        //Delete Promo

        public int DeletePromoCode(string code)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM PromoCode WHERE Code = @code";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@code", code);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
        ///////////////////////////////////////Admin Search Query//////////////////////////////

        //SearchByUsername
        public DataTable SearchUsersByUsername(string username)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT Username,Password, Fullname, Role FROM Users WHERE Username LIKE @username";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@username", username + "%");

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
        ///////////////////////////////////////Manager Search Query//////////////////////////////

        //SearchByUsernameManager

        public DataTable SearchUsersByUsernameManager(string username)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT Username,Password, Fullname, Role FROM Users WHERE (Role = 'MANAGER' OR Role = 'STAFF') AND Username LIKE @username";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@username", username + "%");

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        //SearchByProductname

        public DataTable SearchByProductname(string productname)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ProductID,ProductName, Cost, Price,(Price - Cost) AS Profit, Quantity, Size FROM Product  WHERE ProductName LIKE @Productname";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@Productname", productname + "%");

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
        //SearchByProductnameStaff

        public DataTable SearchByProductnameStaff(string productname)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ProductID,ProductName, Price,Quantity, Size FROM Product  WHERE ProductName LIKE @Productname";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@Productname", productname + "%");

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        //SearchByPromoCode
        public DataTable SearchByPromoCode(string code)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM PromoCode WHERE Code LIKE @code";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@Code", code + "%");

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        ///////////////////////////////////////Get Query//////////////////////////////

        // Get all users (ADMIN))
        public DataTable getUser()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Users";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        // Get all users (MANAGER)
        public DataTable getUserManager()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT Username, Fullname, Role FROM users WHERE Role = 'MANAGER' OR Role = 'STAFF'";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        // Get all PromoCode
        public DataTable getPromo()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM PromoCode";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dataTable);
            }

            return dataTable;
        }


        //Product Without Profit
        public DataTable getProducts()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Product";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        //Product With Profit
        public DataTable getProduct()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ProductID,ProductName, Cost, Price,(Price - Cost) AS Profit, Quantity, Size FROM Product";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        //Product FOR POS
        public DataTable getProductPOS()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ProductID,ProductName, Price, Quantity, Size FROM Product";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable getProductPOS(string productName)
        {
            DataTable dataTable = new DataTable();

            string query = @"
        SELECT ProductID, ProductName, Price, Quantity, Size 
        FROM Product
        WHERE ProductName LIKE @ProductName
    ";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@ProductName", productName + "%");

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }


        //////////////////////////////////POS DATABASE////////////////////////////
        ///


        //Validate Promocode
        public bool ValidatePromo(string code, out int discount)
        {
            discount = 0;
            string sql = "SELECT DiscountPercent FROM PromoCode WHERE Code = @code";
            SqlCommand cmd = new SqlCommand(sql, this.Sqlcon);

            cmd.Parameters.AddWithValue("@code", code);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    discount = Convert.ToInt32(reader["DiscountPercent"]);
                    return true;
                }
            }
            return false;
        }
        public int InsertSale(string customerName, double totalAmount, string paymentType, string usedPromo, string paymentToken, DateTime saleDate)
        {
            string sql = @"INSERT INTO Sales (CustomerName, TotalAmount, PaymentType, UsedPromo, PaymentToken, Date) " +
                         "VALUES (@CustomerName, @TotalAmount, @PaymentType, @UsedPromo, @PaymentToken, @Date); SELECT CAST(SCOPE_IDENTITY() AS INT)";

            using (SqlCommand cmd = new SqlCommand(sql, Sqlcon))
            {
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                cmd.Parameters.AddWithValue("@PaymentType", paymentType);
                cmd.Parameters.AddWithValue("@UsedPromo", usedPromo);
                cmd.Parameters.AddWithValue("@PaymentToken", paymentToken);
                cmd.Parameters.AddWithValue("@Date", saleDate);

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int saleId))
                {
                    return saleId;
                }
                else
                {
                    throw new Exception("Failed to retrieve generated Sale ID.");
                }
            }
        }

        public void InsertUserSale(string username, int saleId)
        {
            string sql = "INSERT INTO UserSale (Username,SaleID) " +
                         "VALUES (@Username, @SaleID)";

            using (SqlCommand cmd = new SqlCommand(sql, Sqlcon))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@SaleID", saleId);
                cmd.ExecuteNonQuery();
            }
        }


        public void UpdateProductQuantity(int productId, int soldQuantity)
        {
            string query = "UPDATE Product SET Quantity = Quantity - @SoldQuantity WHERE ProductID = @ProductID";

            using (SqlCommand cmd = new SqlCommand(query, Sqlcon))
            {
                cmd.Parameters.AddWithValue("@SoldQuantity", soldQuantity);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.ExecuteNonQuery();
            }
        }


        public DataTable GetSalesByUser()
        {
            DataTable dataTable = new DataTable();

            string query = @"
    SELECT s.SaleID, s.CustomerName, s.TotalAmount, s.PaymentType, s.UsedPromo, s.PaymentToken, s.Date
    FROM UserSale us
    INNER JOIN Sales s ON us.SaleID = s.SaleID
    WHERE us.Username = @Username
    ORDER BY s.Date DESC
";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@Username", Users.Username);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        public void InsertSaleProduct(string productID, int saleId)
        {
            string sql = "INSERT INTO SaleProduct (ProductID,SaleID) " +
                         "VALUES (@ProductID, @SaleID)";

            using (SqlCommand cmd = new SqlCommand(sql, Sqlcon))
            {
                cmd.Parameters.AddWithValue("@ProductID", productID);
                cmd.Parameters.AddWithValue("@SaleID", saleId);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetSaleReport()
        {
            DataTable dataTable = new DataTable();

            string query = @"
        SELECT 
            s.SaleID, 
            s.CustomerName, 
            s.TotalAmount, 
            s.PaymentType, 
            s.UsedPromo, 
            s.PaymentToken, 
            s.Date,
            SUM(p.Price - p.Cost) AS TotalProfit
        FROM Sales s
        INNER JOIN SaleProduct sp ON s.SaleID = sp.SaleID
        INNER JOIN Product p ON sp.ProductID = p.ProductID
        GROUP BY 
            s.SaleID, 
            s.CustomerName, 
            s.TotalAmount, 
            s.PaymentType, 
            s.UsedPromo, 
            s.PaymentToken, 
            s.Date
        ORDER BY s.Date DESC;
";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            {

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
    
    public DataTable GetSaleReport(string saleId)
        {
            DataTable dataTable = new DataTable();

            string query = @"
        SELECT 
            s.SaleID, 
            s.CustomerName, 
            s.TotalAmount, 
            s.PaymentType, 
            s.UsedPromo, 
            s.PaymentToken, 
            s.Date,
            SUM(p.Price - p.Cost) AS TotalProfit
        FROM Sales s
        INNER JOIN SaleProduct sp ON s.SaleID = sp.SaleID
        INNER JOIN Product p ON sp.ProductID = p.ProductID
        WHERE s.SaleID LIKE @SaleID
        GROUP BY 
            s.SaleID, 
            s.CustomerName, 
            s.TotalAmount, 
            s.PaymentType, 
            s.UsedPromo, 
            s.PaymentToken, 
            s.Date
        ORDER BY s.Date DESC;
    ";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@SaleID",saleId + "%");

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        ///Insert Into Refund table/////////////////////
        public int InsertRefundAndGetId(decimal amount, string reason)
        {
            string query = @"
        INSERT INTO Refund (Amount, Reason)
        OUTPUT INSERTED.RefundID
        VALUES (@Amount, @Reason)";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Reason", reason);

                if (this.Sqlcon.State != ConnectionState.Open)
                    this.Sqlcon.Open();

                return (int)cmd.ExecuteScalar();
            }
        }
        ///Aggrigation To SaleID and RedundID/////////////////////
        public bool LinkSaleToRefund(string saleId, int refundId)
        {
            string query = @"
        INSERT INTO SaleRefund (SaleID, RefundID)
        VALUES (@SaleID, @RefundID)";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@SaleID", saleId);
                cmd.Parameters.AddWithValue("@RefundID", refundId);

                if (this.Sqlcon.State != ConnectionState.Open)
                    this.Sqlcon.Open(); 

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        ///Search Refund Report By SaleID///////////////////
        public DataTable GetRefundReport(string saleId = "")
        {
            DataTable dataTable = new DataTable();

            string query = @"
        SELECT 
            sr.SaleID,
            us.Username AS SoldBy,
            r.RefundID,
            r.Amount,
            r.Reason,
            p.ProductID,
            p.ProductName,
            p.Size,
            p.Price
        FROM SaleRefund sr
        INNER JOIN Refund r ON sr.RefundID = r.RefundID
        INNER JOIN UserSale us ON sr.SaleID = us.SaleID
        INNER JOIN SaleProduct sp ON sr.SaleID = sp.SaleID
        INNER JOIN Product p ON sp.ProductID = p.ProductID
        WHERE (@SaleID = '' OR sr.SaleID LIKE @SaleID + '%')
    ";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@SaleID", saleId);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        ///Check if a sale has been refunded?????????????

        public bool IsSaleRefunded(string saleId)
        {
            string query = "SELECT COUNT(*) FROM SaleRefund WHERE SaleID = @SaleID";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@SaleID", saleId);

                if (this.Sqlcon.State != ConnectionState.Open)
                    this.Sqlcon.Open();

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }






    }
}
