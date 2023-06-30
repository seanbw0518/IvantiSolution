namespace IvantiSolution
{
    #pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class TriangleCoords
    #pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        public string? Result { get; set; }
        public int V1x { get; set; }
        public int V1y { get; set; }

        public int V2x { get; set; }
        public int V2y { get; set; }

        public int V3x { get; set; }
        public int V3y { get; set; }

        // this is overwritten so the unit test Assert.AreEqual checks for matching coords
        public override bool Equals(object? obj)
        {
            if (obj != null && obj is TriangleCoords)
            {
                if (this.V1x != (obj as TriangleCoords).V1x) return false;
                if (this.V1y != (obj as TriangleCoords).V1y) return false;
                if (this.V2x != (obj as TriangleCoords).V2x) return false;
                if (this.V2y != (obj as TriangleCoords).V2y) return false;
                if (this.V3x != (obj as TriangleCoords).V3x) return false;
                if (this.V3y != (obj as TriangleCoords).V3y) return false;
            }
            else
            {
                return false;
            }

            return true;

        }

        public void FindCoords(char row, int column)
        {
            int rowAsNum = Convert.ToInt32(char.ToLower(row)) - 96;

            // for triangles with right angle at top-right (even columns)
            if (column % 2 == 0)
            {
                var topLeftX = 10 * ((column / 2) - 1);
                var topLeftY = (rowAsNum * 10) - 10;

                var topRightX = topLeftX + 10;
                var topRightY = topLeftY;

                var bottomRightX = topRightX;
                var bottomRightY = topRightY + 10;

                V1x = topLeftX;
                V1y = topLeftY;

                V2x = topRightX;
                V2y = topRightY;

                V3x = bottomRightX;
                V3y = bottomRightY;
            }
            // for triangles with right angle at bottom-left (odd columns)
            else
            {
                var topLeftX = 10 * ((column - 1) / 2);
                var topLeftY = (rowAsNum * 10) - 10;

                var bottomLeftX = topLeftX;
                var bottomLeftY = topLeftY + 10;

                var bottomRightX = bottomLeftX + 10;
                var bottomRightY = bottomLeftY;

                V1x = topLeftX;
                V1y = topLeftY;

                V2x = bottomLeftX;
                V2y = bottomLeftY;

                V3x = bottomRightX;
                V3y = bottomRightY;
            }
        }

    }
}
