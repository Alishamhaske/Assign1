using System.Data.SqlClient;

namespace Assign1.Models
{
    public class EmployeeAddDAL
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        IConfiguration configuration;
        public EmployeeAddDAL(IConfiguration configuration)
        {
            this.configuration = configuration;
            con = new SqlConnection(this.configuration.GetConnectionString("defaultConnection"));
        }

        //getemployee
        public IEnumerable<EmployeeAdd> GetEmployeeAdds() 
        {
        List<EmployeeAdd> employeeAdds = new List<EmployeeAdd>();
            string qry = "select * from EmployeeAdd";
            cmd=new SqlCommand(qry,con);
            con.Open();
            dr=cmd.ExecuteReader(); 
            if(dr.HasRows)
            {
                while(dr.Read()) 
                {
                EmployeeAdd employeeAdd = new EmployeeAdd();
                    employeeAdd.Id = Convert.ToInt32(dr["id"]);
                    employeeAdd.Name = dr["name"].ToString();
                    employeeAdd.Dept = dr["dept"].ToString();
                    employeeAdd.Salary = Convert.ToInt32(dr["salary"]);

                    employeeAdds.Add(employeeAdd);
                }
            }
            con.Close();
            return employeeAdds;
        }
        //search emp
        public EmployeeAdd GetEmployeeAddById(int id)
        {
            EmployeeAdd emp = new EmployeeAdd();
            string qry = "select * from EmployeeAdd where id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    emp.Id = Convert.ToInt32(dr["id"]);
                    emp.Name = dr["name"].ToString();
                    emp.Dept = dr["dept"].ToString();
                    emp.Salary = Convert.ToInt32(dr["salary"]);


                }
            }
            con.Close();
            return emp;
        }

        //add employee
        public int AddEmployeeAdd(EmployeeAdd employeeAdd)
        {
            int result = 0;
            string qry = "insert into EmployeeAdd values(@id,@name,@dept,@salary)";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", employeeAdd.Id);
            cmd.Parameters.AddWithValue("@name", employeeAdd.Name);
            cmd.Parameters.AddWithValue("@dept", employeeAdd.Dept);
            cmd.Parameters.AddWithValue("@salary", employeeAdd.Salary);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
    }
}
