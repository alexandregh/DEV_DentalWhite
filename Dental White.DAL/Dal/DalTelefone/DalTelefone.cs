using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Dental_White.DAL.Entity;
using Dental_White.DAL.Persistence;

namespace Dental_White.DAL.Dal.DalTelefone
{
    public class DalTelefone : ConexaoDentalWhite
    {
        //public Int16 FindDDD()
        //{
        //    try
        //    {
        //        base.OpenDBDentalWhite();
        //        CmdDB = new SqlCommand("select DDD from TBTelefone order by DDD", ConDB);
        //        DrDB = CmdDB.ExecuteReader();
        //        List<Int16> listaDDD = new List<Int16>();
        //        while(DrDB.Read())
        //        {
        //            Int16 ddd = new Int16();
        //            ddd = Convert.ToInt16(DrDB.);
        //            //listaDDD.Add(ddd);
                    
                    
        //        }
        //        return ddd;
        //    }
        //    catch(Exception ex)
        //    {

        //    }
        //    finally
        //    {
        //        base.CloseDBDentalWhite();
        //    }
        //}
    }
}