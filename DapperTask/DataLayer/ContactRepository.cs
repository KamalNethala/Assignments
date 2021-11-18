using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;
using System.Data;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;



namespace DataLayer
{
    public class ContactRepository : IContactRepository
    {
        private System.Data.IDbConnection db;



        public ContactRepository(string connString)
        {
            string s = string.Empty;
            string s1 = string.Empty;
            string s3 = string.Empty;

            this.db = new SqlConnection(connString);
            string s4 = string.Empty;
        }



        public Train Add(Train Train)
        {
            string s = string.Empty;
            string s1 = string.Empty;
            string s3 = string.Empty;
            this.db.Insert(Train);

            return Train;
        }
    }
}