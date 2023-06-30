using Microsoft.AspNetCore.Mvc;

namespace IvantiSolution.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TriangleCoordsController : ControllerBase
    {

        char[] rows = new char[6] { 'a', 'b', 'c', 'd', 'e', 'f' };
        int numOfColumns = 6;

        /// <summary>
        /// Gets the 3 vertex coordinates of a triangle given its row and column
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        [HttpGet(Name = "GetTriangleCoords")]
        public TriangleCoords Get(char row, int column)
        {
            TriangleCoords coords;

            // check invalid user input
            if (!rows.Contains(Char.ToLower(row)))
            {
                coords = new TriangleCoords();
                coords.Result = "INVALID ROW";
            }
            else if (column < 1 || column > numOfColumns)
            {
                coords = new TriangleCoords();
                coords.Result = "INVALID COLUMN";
            }
            else
            {
                coords = new TriangleCoords();

                coords.FindCoords(row, column);
                coords.Result = "VALID";
            }

            return coords;
        }
    }
}
