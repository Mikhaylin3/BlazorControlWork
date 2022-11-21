using MongoDB.Driver;

namespace BlazorControlWork.Data
{
    public class UnitService
    {
        public List<Unit> unit = new List<Unit>();
        public List<Unit> GetUnits()
        {
            return unit;
        }

        public List<Unit> SetUnits()
        {
            unit = Mongich.FindAll();
            return unit;
        }
    }
}
