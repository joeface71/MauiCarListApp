using CarListApp.Maui.Models;
using SQLite;

namespace CarListApp.Maui.Services
{
    public class CarService
    {
        private SQLiteConnection conn;
        string _dbPath;

        public CarService(string dbPath)
        {
            _dbPath = dbPath;
        }


        private void Init()
        {
            if (conn != null)
            {
                return;
            }

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Car>();

        }
        public List<Car> GetCars()
        {
            try
            {
                Init();

            }
            catch (Exception)
            {

                throw;
            }

            return new List<Car>();
        }
    }
}
