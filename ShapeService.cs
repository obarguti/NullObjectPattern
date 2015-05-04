namespace NullObjectPattern
{
    public class ShapeService
    {
        public IShape GetShapeById(int id)
        {
            var square = GetShapeFromDatabase(id);

            return square ?? new NullShape();
        }

        private IShape GetShapeFromDatabase(int id)
        {
            return null;
        }
    }
}
