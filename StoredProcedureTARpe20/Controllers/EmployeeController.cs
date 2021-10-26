using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoredProcedureTARpe20.Views

namespace StoredProcedureTARpe20.Controllers
{
    public partial class SearchPageWithoutDynamicSQL : System.Web.UI.Page
    {



        public ActionResult Index();
            return View();
 
        protected void btnSearch_Click(object.sender.EventArgs e)
        {
        string connectionStr = ConfigurationManager
            ConnectionStrings["connectionStr"] ConnectionString;
        using(SqlConnection con = new SqlConnection(connectionStr))
        {
            SqlCommand cmd = new SqlCommand();
            cmd Connection = con;
            cmd CommandText = "spSearchEmployees";
            cmd CommandType = CommandType StoredProcedure;

            #(inputFirstname.Value.Trim)() !="")
            {
                    SqlParameter param = new SqlParameter
                        ("@FirstName", inputFirstname.Value);
                    cmd.Parameters.Add(param);
            }
            #(inputLastname.Value.Trim)() !="")
            {
                    SqlParameter param = new SqlParameter
                        ("@LastName", inputLastname.Value);
                    cmd.Parameters.Add(param);
            }
            #(inputGender.Value.Trim)() !="")
            {
                    SqlParameter param = new SqlParameter
                        ("@Gender", inputGender.Value);
                    cmd.Parameters.Add(param);
            }
            #(inputSalary.Value.Trim)() !="")
            {
                SqlParameter param = new SqlParameter
                    ("@Salary", inputSalary.Value);
                cmd.Parameters.Add(param);
            }
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                gvSearchResults.DataSource = rdr;
                gvSearchResults.DataBind();
            }
        }

    }
}
