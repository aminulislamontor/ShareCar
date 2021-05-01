using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareCar.Data;
using ShareCar.Entity;

namespace ShareCar.Repository
{
    public class CarRequestRepo
    {
        CarRequest carRequest = new CarRequest();

        public List<CarRequest> GetAll()
        {
            var carRequest = new List<CarRequest>();
            var sql = "select * from carRequest";
            var dt = DataAccess.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                CarRequest h = ConvertToEntity(dt.Rows[index]);
                carRequest.Add(h);
            }
            return carRequest;
        }
        public CarRequest ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var h = new CarRequest();
            h.id = Convert.ToInt32(row["id"].ToString());
            h.time = row["time"].ToString();
            h.reason = row["reason"].ToString();
            h.address = row["address"].ToString();
            h.status = row["status"].ToString();
            return h;
        }
    }
    
}
