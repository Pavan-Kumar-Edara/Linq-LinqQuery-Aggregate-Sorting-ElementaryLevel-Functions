using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace ConnectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Connection();
        }

        static void Connection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using(SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {
                    //connection.Open();
                    //if (connection.State == ConnectionState.Open)
                    //{
                    //    Console.WriteLine("Connection creation success!");
                    //}

                    string query = "select * from employee";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    //adapter.SelectCommand = new SqlCommand("Select * from Employee;");

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        var oneEmployee = from data in ds.Tables[0].AsEnumerable()
                                       where data.Field<string>("job").Equals("CLERK")
                                       select new
                                       {
                                           Ename = data.Field<string>("Ename"),
                                           job = data.Field<string>("job"),
                                       };
                        foreach (var emp in oneEmployee)
                        {
                            Console.WriteLine(emp.Ename+" "+ emp.job);
                        }
                    }

                  



                    //SqlDataAdapter adapter = new SqlDataAdapter();
                    //adapter.SelectCommand = new SqlCommand("Select * from Employee;");

                    //DataTable ds = new DataTable();
                    //adapter.Fill(ds);

                    //foreach (DataRow row in ds.Rows)
                    //{
                    //    Console.WriteLine(row[0] + " " + row[1] + " " + row[2]);
                    //}


                    //string query = "select * from employee;select * from countries;";
                    //SqlCommand cmd=new SqlCommand(query, connection);
                    //connection.Open();

                    //using (SqlDataReader reader = cmd.ExecuteReader())
                    //{
                    //    while (reader.Read())
                    //    {
                    //        Console.WriteLine("Name: " + reader["Ename"] + " job: " + reader["job"] + " mgr:" + reader["mgr"]);
                    //    }
                    //    Console.WriteLine("----------------------------------------------------------------------");
                    //    if(reader.NextResult())
                    //    {
                    //        Console.WriteLine(reader[0]+" " + reader[1]);
                    //    }
                    //}




                    //string query = "uspDeatils";
                    //SqlCommand cmd = new SqlCommand(query, connection);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //connection.Open();

                    //using (SqlDataReader reader = cmd.ExecuteReader()) 
                    //{
                    //    while (reader.Read())
                    //    {
                    //        Console.WriteLine("Name: " + reader["Ename"] + " job: " + reader["job"] + " mgr:" + reader["mgr"]);
                    //    }
                    //    Console.WriteLine(reader.FieldCount);
                    //    Console.WriteLine(reader.HasRows);
                    //    Console.WriteLine(reader.GetName(0));
                    //}





                    //Console.WriteLine("Enter Eno:");
                    //string eno=Console.ReadLine();

                    //Console.WriteLine("Enter Ename:");
                    //string ename=Console.ReadLine();

                    //Console.WriteLine("Enter job:");
                    //string job=Console.ReadLine();

                    //Console.WriteLine("Enter Mgr");
                    //string mgr=Console.ReadLine() ;

                    //Console.WriteLine("Enter Hiredate:");
                    //string date = Console.ReadLine();

                    //Console.WriteLine("Enter salary:");
                    //string salary=Console.ReadLine();

                    //Console.WriteLine("Enter commision:");
                    //string commision=Console.ReadLine();

                    //Console.WriteLine("Enter department:");
                    //string department=Console.ReadLine();

                    //string query = "Insert into employee values(@eno,@ename,@job,@mgr,@date,@sal,@comm,@dept)";
                    //SqlCommand cmd = new SqlCommand(query,connection);
                    //cmd.Parameters.AddWithValue("@eno", eno);
                    //cmd.Parameters.AddWithValue("@ename", ename);
                    //cmd.Parameters.AddWithValue("@job", job);
                    //cmd.Parameters.AddWithValue("@mgr", mgr);
                    //cmd.Parameters.AddWithValue("@date", date);
                    //cmd.Parameters.AddWithValue("@sal", salary);
                    //cmd.Parameters.AddWithValue("@comm", commision);
                    //cmd.Parameters.AddWithValue("dept", department);

                    //connection.Open();

                    //int rows=cmd.ExecuteNonQuery();
                    //if(rows>0)
                    //{
                    //    Console.WriteLine("Success");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("failure");
                    //}





                    //Console.WriteLine("Enter Name to Update:");
                    //string updatedName = Console.ReadLine();

                    //Console.WriteLine("Enter eno where to update ur name: ");
                    //string eno = Console.ReadLine();

                    //string Query = "update employee set ename=@updatedName where eno=@eno";
                    //SqlCommand cmd = new SqlCommand(Query, connection);
                    //cmd.Parameters.AddWithValue("@updatedName", updatedName);
                    //cmd.Parameters.AddWithValue("@eno", eno);
                    //connection.Open();


                    //int rows = cmd.ExecuteNonQuery();
                    //if (rows > 0)
                    //{
                    //    Console.WriteLine("Sucess");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Failure");
                    //}


                    //Console.WriteLine("Enter eno to delete row:");
                    //string eno = Console.ReadLine();

                    //string query = "delete from employee where eno=@eno";
                    //SqlCommand cmd = new SqlCommand(query, connection);
                    //cmd.Parameters.AddWithValue("@eno", eno);

                    //connection.Open();

                    //int rows=cmd.ExecuteNonQuery();
                    //if(rows > 0)
                    //{
                    //    Console.WriteLine("success");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Failure");
                    //}

                    //string query = "select count(Ename) from employee";
                    //SqlCommand cmd= new SqlCommand(query, connection);  
                    //connection.Open();

                    //int recordCount=(int)cmd.ExecuteScalar();
                    //Console.WriteLine(recordCount);

                    //string query = "select min(sal) from employee";
                    //SqlCommand cmd = new SqlCommand(query, connection);
                    //connection.Open();

                    //int recordCount = (int)cmd.ExecuteScalar();
                    //Console.WriteLine(recordCount);


                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }









            /*SqlConnection connection=new SqlConnection(connectionString);

            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connection creation success!");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }*/
        }

        
    }
}