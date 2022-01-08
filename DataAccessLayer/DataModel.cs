using Dapper;
using NorthWind;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        List<Region> regions;
        public DataModel()
        {
            con = new SqlConnection(ConnectionString.ConStr);
            cmd = con.CreateCommand();
            regions = new List<Region>();
        }

        public Kullanici KullaniciGiris(string Isim, string sifre)
        {
            try
            {
                Kullanici k = null;
                cmd.CommandText = "SELECT * FROM Kullanicilar WHERE Isim=@e AND Sifre =@s";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@e", Isim);
                cmd.Parameters.AddWithValue("@s", sifre);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    k = new Kullanici();
                    k.ID = reader.GetInt32(0);
                    k.Isim = reader.GetString(1);
                    k.Soyad = reader.GetString(2);
                    k.Mail = reader.GetString(3);
                    k.Sifre = reader.GetString(4);
                    k.Durum = reader.GetBoolean(5);
                }
                return k;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public bool KullaniciKaydet(Kullanici k) 
        {
            try
            {
                cmd.CommandText = "INSERT INTO Kullanicilar (Isim,Soyad,Mail,Sifre,Durum) VALUES (@i,@so,@m,@s,@d)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@i", k.Isim);
                cmd.Parameters.AddWithValue("@so", k.Soyad);
                cmd.Parameters.AddWithValue("@m", k.Mail);
                cmd.Parameters.AddWithValue("@s", k.Sifre);
                cmd.Parameters.AddWithValue("@d", 1);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Product> GetProduct()
        {
            List<Product> products = new List<Product>();
            try
            {
                cmd.CommandText = "SELECT * FROM Products";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Product p = new Product();
                    p.ID = reader.GetInt32(0);
                    p.Name = reader.GetString(1);
                    p.Supplier_ID = reader.GetInt32(2);
                    p.Category_ID = reader.GetInt32(3);
                    p.QuentityPerUnit = reader.GetString(4);
                    p.UnitPrice = reader.GetDecimal(5);
                    p.UnitsInStock = reader.GetInt16(6);
                    p.UnitsOnOrder = reader.GetInt16(7);
                    p.Reorderlevel = reader.GetInt16(8);
                    p.Discontinued = reader.GetBoolean(9);
                    products.Add(p);
                }
                return products;
            }
            catch
            {
                return null;

            }
            finally
            {
                con.Close();
            }
        }

        public List<Category> GetCategory()
        {
            List<Category> Categories = new List<Category>();
            try
            {
                cmd.CommandText = "SELECT * FROM Categories";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Category c = new Category();
                    c.ID = reader.GetInt32(0);
                    c.Name = reader.GetString(1);
                    c.Description = reader.GetString(2);
                    Categories.Add(c);
                }
                return Categories;
            }
            catch
            {
                return null;

            }
            finally
            {
                con.Close();
            }
        }

        public List<Supplier> GetSupplier()
        {
            List<Supplier> suppliers = new List<Supplier>();
            try
            {
                cmd.CommandText = "SELECT * FROM Suppliers";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Supplier s = new Supplier();
                    s.ID = reader.GetInt32(0);
                    s.CompanyName = reader.GetString(1);
                    s.ContactName = reader.GetString(2);
                    s.ContactTitle = reader.GetString(3);
                    s.Address = reader.GetString(4);
                    s.City = reader.GetString(5);
                    s.Region = !reader.IsDBNull(6) ? reader.GetString(6) : "Yok";
                    s.PostalCode = reader.GetString(7);
                    s.Country = reader.GetString(8);
                    s.Phone = reader.GetString(9);
                    s.Fax = !reader.IsDBNull(10) ? reader.GetString(10) : "Yok";
                    s.HomePage = !reader.IsDBNull(11) ? reader.GetString(11) : "Yok";
                    suppliers.Add(s);
                }
                return suppliers;
            }
            catch
            {
                return null;

            }
            finally
            {
                con.Close();
            }
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                cmd.CommandText = "SELECT * FROM Customers";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Customer c = new Customer();
                    c.ID = reader.GetString(0);
                    c.CompanyName = reader.GetString(1);
                    c.ContactName = reader.GetString(2);
                    c.ContactTitle = reader.GetString(3);
                    c.Address = reader.GetString(4);
                    c.City = reader.GetString(5);
                    c.Region = !reader.IsDBNull(6) ? reader.GetString(6) : "Yok";
                    c.PostalCode = !reader.IsDBNull(7) ? reader.GetString(7) : "Yok";
                    c.Country = reader.GetString(8);
                    c.Phone = reader.GetString(9);
                    c.Fax = !reader.IsDBNull(10) ? reader.GetString(10) : "Yok";
                    customers.Add(c);
                }
                return customers;
            }
            catch
            {

                return null;

            }
            finally
            {
                con.Close();
            }
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                cmd.CommandText = "SELECT * FROM Employees";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employee e = new Employee();
                    e.ID = reader.GetInt32(0);
                    e.LastName = reader.GetString(1);
                    e.FirstName = reader.GetString(2);
                    e.Title = reader.GetString(3);
                    e.TitleOfCourtesy = reader.GetString(4);
                    e.BirthDate = reader.GetDateTime(5);
                    e.HireDate = reader.GetDateTime(6);
                    e.Address = reader.GetString(7);
                    e.City = reader.GetString(8);
                    e.Region = !reader.IsDBNull(9) ? reader.GetString(9) : "Yok";
                    e.PostalCode = reader.GetString(10);
                    e.Country = reader.GetString(11);
                    e.HomePhone = reader.GetString(12);
                    e.Extension = reader.GetString(13);
                    e.Photo = (byte[])reader.GetSqlBinary(14);
                    e.Notes = reader.GetString(15);
                    e.ReportsTo = !reader.IsDBNull(16) ? reader.GetInt32(16) : 0;
                    e.PhotoPath = reader.GetString(17);
                    employees.Add(e);
                }
                return employees;
            }
            catch
            {

                return null;

            }
            finally
            {
                con.Close();
            }
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            try
            {
                cmd.CommandText = "SELECT * FROM Orders";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Order o = new Order();
                    o.ID = reader.GetInt32(0);
                    o.CustomerID = reader.GetString(1);
                    o.EmployeeID = reader.GetInt32(2);
                    o.OrderDate = reader.GetDateTime(3);
                    o.RequiredDate = reader.GetDateTime(4);
                    o.ShippedDate = !reader.IsDBNull(5) ? reader.GetDateTime(5) : System.DateTime.Now;
                    o.ShipVia = reader.GetInt32(6);
                    o.Freight = reader.GetDecimal(7);
                    o.ShipName = reader.GetString(8);
                    o.ShipAddress = reader.GetString(9);
                    o.ShipCity = reader.GetString(10);
                    o.ShipRegion = !reader.IsDBNull(11) ? reader.GetString(11) : "yok";
                    o.ShipPostalCode = !reader.IsDBNull(12) ? reader.GetString(12) : "yok";
                    o.ShipCountry = reader.GetString(13);
                    orders.Add(o);
                }
                return orders;
            }
            catch
            {

                return null;

            }
            finally
            {
                con.Close();
            }
        }

        public List<Shipper> GetShipper()
        {
            List<Shipper> Shippers = new List<Shipper>();
            try
            {
                cmd.CommandText = "SELECT * FROM Shippers";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Shipper s = new Shipper();
                    s.ID = reader.GetInt32(0);
                    s.CompanyName = reader.GetString(1);
                    s.Phone = reader.GetString(2);
                    Shippers.Add(s);
                }
                return Shippers;
            }
            catch
            {
                return null;

            }
            finally
            {
                con.Close();
            }
        }

        public List<OrderDetails> GetOrderDetails()
        {
            List<OrderDetails> OrderDetails = new List<OrderDetails>();
            try
            {
                cmd.CommandText = "SELECT * FROM [Order Details]";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    OrderDetails o = new OrderDetails();
                    o.OrderID = reader.GetInt32(0);
                    o.ProductID = reader.GetInt32(1);
                    o.UnitPrice = reader.GetDecimal(2);
                    o.Quantity = reader.GetInt16(3);
                    o.Discount = (Single)reader.GetSqlSingle(4);
                    OrderDetails.Add(o);
                }
                return OrderDetails;
            }
            catch
            {
                return null;

            }
            finally
            {
                con.Close();
            }
        }

        public List<Region> GetRegion()
        {
            List<Region> regions = new List<Region>();
            try
            {
                cmd.CommandText = "SELECT * FROM Region";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Region r = new Region();
                    r.ID = reader.GetInt32(0);
                    r.RegionDescription = reader.GetString(1);
                    regions.Add(r);
                }
                return regions;
            }
            catch
            {
                return null;

            }
            finally
            {
                con.Close();
            }
        }
        public List<Territories> GetTerritories()
        {
            List<Territories> territories = new List<Territories>();
            try
            {
                cmd.CommandText = "SELECT * FROM Territories";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Territories t = new Territories();
                    t.ID = reader.GetString(0);
                    t.TerritoryDescription= reader.GetString(1);
                    t.RegionID = reader.GetInt32(2);
                    territories.Add(t);
                }
                return territories;
            }
            catch
            {
                return null;

            }
            finally
            {
                con.Close();
            }
        }

        public List<EmployeeTerritories> GetEmployeeTerritories()
        {
            List<EmployeeTerritories> ets = new List<EmployeeTerritories>();
            try
            {
                cmd.CommandText = "SELECT * FROM EmployeeTerritories";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EmployeeTerritories et = new EmployeeTerritories();
                    et.employeeID = reader.GetInt32(0);
                    et.territoryID = reader.GetString(1);
                    ets.Add(et);
                }
                return ets;
            }
            catch
            {
                return null;

            }
            finally
            {
                con.Close();
            }
        }

        public bool AddCategory(Category c)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Categories (CategoryName,Description) VALUES (@ad,@Aciklama)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ad", c.Name);
                cmd.Parameters.AddWithValue("@Aciklama", c.Description);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool AddProduct(Product p)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Products(ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued) VALUES (@productname,@supplierıd,@categoryıd,@quantityperunit,@unitprice,@unitsınstock,@unitsonorder,@reorderlevel,@discontinued)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@productname", p.Name);
                cmd.Parameters.AddWithValue("@supplierıd", p.Supplier_ID);
                cmd.Parameters.AddWithValue("@categoryıd", p.Category_ID);
                cmd.Parameters.AddWithValue("@quantityperunit", p.QuentityPerUnit);
                cmd.Parameters.AddWithValue("@unitprice", p.UnitPrice);
                cmd.Parameters.AddWithValue("@unitsınstock", p.UnitsInStock);
                cmd.Parameters.AddWithValue("@unitsonorder", p.UnitsOnOrder);
                cmd.Parameters.AddWithValue("@reorderlevel", p.Reorderlevel);
                cmd.Parameters.AddWithValue("@discontinued", p.Discontinued);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool AddSupplier(Supplier s)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Suppliers (CompanyName, ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax,HomePage) VALUES (@companyname, @contactname,@contacttitle,@address,@city,@region,@postalcode,@country,@phone,@fax,@homepage)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@companyname", s.CompanyName);
                cmd.Parameters.AddWithValue("@contactname", s.ContactName);
                cmd.Parameters.AddWithValue("@contacttitle", s.ContactTitle);
                cmd.Parameters.AddWithValue("@address", s.Address);
                cmd.Parameters.AddWithValue("@city", s.City);
                cmd.Parameters.AddWithValue("@region", s.Region);
                cmd.Parameters.AddWithValue("@postalcode", s.PostalCode);
                cmd.Parameters.AddWithValue("@country", s.Country);
                cmd.Parameters.AddWithValue("@phone", s.Phone);
                cmd.Parameters.AddWithValue("@fax", s.Fax);
                cmd.Parameters.AddWithValue("@homepage", s.HomePage);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool AddCustomer(Customer c)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Customers (CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax) VALUES (@customerid,@companyname,@contactname,@contacttitle,@address,@city,@region,@postalcode,@country,@phone,@fax)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@customerid", c.ID);
                cmd.Parameters.AddWithValue("@companyname", c.CompanyName);
                cmd.Parameters.AddWithValue("@contactname", c.ContactName);
                cmd.Parameters.AddWithValue("@contacttitle", c.ContactTitle);
                cmd.Parameters.AddWithValue("@address", c.Address);
                cmd.Parameters.AddWithValue("@city", c.City);
                cmd.Parameters.AddWithValue("@region", c.Region);
                cmd.Parameters.AddWithValue("@postalcode", c.PostalCode);
                cmd.Parameters.AddWithValue("@country", c.Country);
                cmd.Parameters.AddWithValue("@phone", c.Phone);
                cmd.Parameters.AddWithValue("@fax", c.Fax);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }

        #region Fotoğrafsız Çalışan Ekleme
        //public bool AddEmployee(Employee e)
        //{

        //    try
        //    {
        //        cmd.CommandText = "INSERT INTO Employees (LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Notes,ReportsTo) VALUES (@lastname,@firstname,@title,@titleofcourtesy,@birthdate,@hiredate,@address,@city,@region,@postalcode,@country,@homephone,@extension,@notes,@reportsto)";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@lastname", e.LastName);
        //        cmd.Parameters.AddWithValue("@firstname", e.FirstName);
        //        cmd.Parameters.AddWithValue("@title", e.Title);
        //        cmd.Parameters.AddWithValue("@titleofcourtesy", e.TitleOfCourtesy);
        //        cmd.Parameters.AddWithValue("@birthdate", e.BirthDate);
        //        cmd.Parameters.AddWithValue("@hiredate", e.HireDate);
        //        cmd.Parameters.AddWithValue("@address", e.Address);
        //        cmd.Parameters.AddWithValue("@city", e.City);
        //        cmd.Parameters.AddWithValue("@region", e.Region);
        //        cmd.Parameters.AddWithValue("@postalcode", e.PostalCode);
        //        cmd.Parameters.AddWithValue("@country", e.Country);
        //        cmd.Parameters.AddWithValue("@homephone", e.HomePhone);
        //        cmd.Parameters.AddWithValue("@extension", e.Extension);
        //       // cmd.Parameters.AddWithValue("@photo", e.Photo);
        //        cmd.Parameters.AddWithValue("@notes", e.Notes);
        //       cmd.Parameters.AddWithValue("@reportsto", e.ReportsTo);
        //       // cmd.Parameters.AddWithValue("@photopath", e.PhotoPath);
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //        return true;

        //    }
        //    catch
        //    {

        //        return false;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //} 
        #endregion

        public bool AddEmployee(Employee e)
        {

            try
            {
                cmd.CommandText = "INSERT INTO Employees (LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Notes,ReportsTo,PhotoPath,Photo) VALUES (@lastname,@firstname,@title,@titleofcourtesy,@birthdate,@hiredate,@address,@city,@region,@postalcode,@country,@homephone,@extension,@notes,@reportsto,@photopath,@photo)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@lastname", e.LastName);
                cmd.Parameters.AddWithValue("@firstname", e.FirstName);
                cmd.Parameters.AddWithValue("@title", e.Title);
                cmd.Parameters.AddWithValue("@titleofcourtesy", e.TitleOfCourtesy);
                cmd.Parameters.AddWithValue("@birthdate", e.BirthDate);
                cmd.Parameters.AddWithValue("@hiredate", e.HireDate);
                cmd.Parameters.AddWithValue("@address", e.Address);
                cmd.Parameters.AddWithValue("@city", e.City);
                cmd.Parameters.AddWithValue("@region", e.Region);
                cmd.Parameters.AddWithValue("@postalcode", e.PostalCode);
                cmd.Parameters.AddWithValue("@country", e.Country);
                cmd.Parameters.AddWithValue("@homephone", e.HomePhone);
                cmd.Parameters.AddWithValue("@extension", e.Extension);
                cmd.Parameters.AddWithValue("@photo", e.Photo);
                cmd.Parameters.AddWithValue("@notes", e.Notes);
                cmd.Parameters.AddWithValue("@reportsto", e.ReportsTo);
                cmd.Parameters.AddWithValue("@photopath", e.PhotoPath);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool AddOrder(Order o)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Orders (CustomerID,EmployeeID,OrderDate,RequiredDate,ShippedDate,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry) VALUES (@customerid,@employeeid,@orderdate,@requireddate,@shippeddate,@shipvia,@freight,@shipname,@shipaddress,@shipcity,@shipregion,@shippostalcode,@shipcountry)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@customerid", o.CustomerID);
                cmd.Parameters.AddWithValue("@employeeid", o.EmployeeID);
                cmd.Parameters.AddWithValue("@orderdate", o.OrderDate);
                cmd.Parameters.AddWithValue("@requireddate", o.RequiredDate);
                cmd.Parameters.AddWithValue("@shippeddate", o.ShippedDate);
                cmd.Parameters.AddWithValue("@shipvia", o.ShipVia);
                cmd.Parameters.AddWithValue("@freight", o.Freight);
                cmd.Parameters.AddWithValue("@shipname", o.ShipName);
                cmd.Parameters.AddWithValue("@shipaddress", o.ShipAddress);
                cmd.Parameters.AddWithValue("@shipcity", o.ShipCity);
                cmd.Parameters.AddWithValue("@shipregion", o.ShipRegion);
                cmd.Parameters.AddWithValue("@shippostalcode", o.ShipPostalCode);
                cmd.Parameters.AddWithValue("@shipcountry", o.ShipCountry);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool AddShipper(Shipper s)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Shippers (CompanyName,Phone) VALUES (@cn,@p)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cn", s.CompanyName);
                cmd.Parameters.AddWithValue("@p", s.Phone);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool AddOrderDetail(OrderDetails o)
        {
            try
            {
                cmd.CommandText = "INSERT INTO [Order Details] (OrderID,ProductID,UnitPrice,Quantity,Discount) VALUES (@orderid,@productid,@unitprice,@quantity,@discount)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@orderid", o.OrderID);
                cmd.Parameters.AddWithValue("@productid", o.ProductID);
                cmd.Parameters.AddWithValue("@unitprice", o.UnitPrice);
                cmd.Parameters.AddWithValue("@quantity", o.Quantity);
                cmd.Parameters.AddWithValue("@discount", o.Discount);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool AddRegion(Region r)
        {
           
           regions= GetRegion(); int s = 0;
            for (int i = 0; i < regions.Count; i++)
            {
                s = regions[i].ID;
            }
            try
            {
                cmd.CommandText = "INSERT INTO Region (RegionID,RegionDescription) VALUES (@id,@reg)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", s+1);
                cmd.Parameters.AddWithValue("@reg", r.RegionDescription);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {

                return false;
            }
            finally
            {
                con.Close();
            }
           
        }
        public bool AddTerritories(Territories t)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Territories (TerritoryID,TerritoryDescription,RegionID) VALUES (@id,@td,@rid)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", t.ID);
                cmd.Parameters.AddWithValue("@td", t.TerritoryDescription);
                cmd.Parameters.AddWithValue("@rid", t.RegionID);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool AddEmployeeTerritories(EmployeeTerritories et)
        {
            try
            {
                cmd.CommandText = "INSERT INTO EmployeeTerritories (EmployeeID,TerritoryID) VALUES (@e,@t)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@e", et.employeeID);
                cmd.Parameters.AddWithValue("@t", et.territoryID);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool EmailKontrol(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Geçerli bir mail adresi giriniz:");
                return false;
            }
        }

        //-------------

        public bool DeleteProduct(int id) 
        {
            try
            {
                con.Open();
                cmd.CommandText = "DELETE products WHERE ProductID=@id";
                con.Query<Product>(cmd.CommandText, new { @id = id }).ToList();
                

                return true;
            }
            catch 
            {
                return false;
                
            }
            finally 
            {
                con.Close();
            }
        }

        public bool DeleteCategory(int id) 
        {
            try
            {
                con.Open();
                cmd.CommandText = "Delete Categories WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                // con.Query<Category>(cmd.CommandText, new { @id = id}).ToList();
                return true;
            }
            catch 
            {
                return false;
            }
            finally 
            {
                con.Close();
            }
        }

    }
}
