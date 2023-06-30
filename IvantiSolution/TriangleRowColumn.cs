namespace IvantiSolution
{
    #pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class TriangleRowColumn
    #pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        public string? Result { get; set; }
        public char Row { get; set; }

        public int Column { get; set; }

        // this is overwritten so the unit test Assert.AreEqual checks for matching coords
        public override bool Equals(object? obj)
        {
            if (obj != null && obj is TriangleRowColumn)
            {
                if (this.Row != (obj as TriangleRowColumn).Row) return false;
                if (this.Column != (obj as TriangleRowColumn).Column) return false;
            }
            else
            {
                return false;
            }

            return true;

        }

        public void FindRowColumn(int v1x, int v1y, int v2x, int v2y, int v3x, int v3y)
        {
            char row = Char.ToUpper((char)((v1y / 10) + 1 + 96));

            // odd column
            if (v2x == v1x)
            {
                if (v2y != v1y + 10 || v3x != v1x + 10 || v3y != v2y)
                {
                    Row = '-';
                    Column = -1;
                    Result = "INVALID COORDINATES";
                }
                else
                {
                    Row = row;
                    Column = (v1x / 5) + 1;
                    Result = "VALID";
                }
                
            }
            // even column
            else if (v2x == v1x + 10)
            {
                if (v2y != v1y || v3x != v1x + 10 || v3y != v1y + 10)
                {
                    Row = '-';
                    Column = -1;
                    Result = "INVALID COORDINATES";
                }
                else
                {
                    Row = row;
                    Column = (v1x / 5) + 2;
                    Result = "VALID";
                }
                
            }
            else
            {
                Row = '-';
                Column = -1;
                Result = "INVALID COORDINATES";
            }
        }
    }
}
