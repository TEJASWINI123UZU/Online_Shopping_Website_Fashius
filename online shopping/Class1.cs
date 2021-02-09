using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace online_shopping
{
    public class Class1
    {
        public SqlConnection con=new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;User Instance=True");
        public SqlCommand cmd;
        public SqlCommand cmd1;
        public SqlDataAdapter da;
        public SqlDataReader dr;

    }
}