using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
namespace Company.Function {
    public static class HttpTriggerCSharp {

        [FunctionName ("HttpTriggerCSharp")]
        public static IActionResult Run (
            [HttpTrigger (AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log) {
            log.LogInformation ("C# HTTP trigger function processed a request.");

            int customerId = Convert.ToInt32 (req.Query["customerId"]);
            return (ActionResult) new OkObjectResult (GetData (customerId));
        }

        public class CustomerModel {
            public int CustomerID { get; set; }
            public int NameStyle { get; set; }
            public string Title { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public string CompanyName { get; set; }
        }

        public static CustomerModel GetData (int customerId) {
            var connection = Environment.GetEnvironmentVariable ("coonectionString");
            CustomerModel customer = new CustomerModel ();
            using (SqlConnection conn = new SqlConnection (connection)) {
                var text = "SELECT CustomerID, NameStyle, FirstName, MiddleName, LastName, CompanyName  FROM SalesLT.Customer where CustomerID=" + customerId;
                SqlCommand cmd = new SqlCommand (text, conn);
                cmd.Parameters.AddWithValue ("@CustomerId", customerId);
                conn.Open ();
                using (SqlDataReader reader = cmd.ExecuteReader (CommandBehavior.SingleRow)) {
                    while (reader.Read () && reader.HasRows) {
                        customer.CustomerID = Convert.
                        ToInt32 (reader["CustomerID"].ToString ());
                        customer.FirstName = reader["FirstName"].ToString ();
                        customer.MiddleName = reader["MiddleName"].ToString ();
                        customer.LastName = reader["LastName"].ToString ();
                        customer.CompanyName = reader["CompanyName"].ToString ();
                    }
                    conn.Close ();
                }
            }
            return customer;
        }
    }
}