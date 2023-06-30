using Microsoft.AspNetCore.Mvc;
using System.Data.Common;

namespace IvantiSolution.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TriangleRowColumnController : ControllerBase
    {
        int maxCoord = 60;

        /// <summary>
        /// Gets the row, column pair given a set of 3 coordinates
        /// </summary>
        /// <param name="v1x"></param>
        /// <param name="v1y"></param>
        /// <param name="v2x"></param>
        /// <param name="v2y"></param>
        /// <param name="v3x"></param>
        /// <param name="v3y"></param>
        /// <returns></returns>
        [HttpGet(Name = "GetTriangleRowColumn")]
        public TriangleRowColumn Get(int v1x, int v1y, int v2x, int v2y, int v3x, int v3y)
        {
            TriangleRowColumn rowColumn;

            //check invalid user input
            if (v1x % 10 != 0 || v1y % 10 != 0 || v2x % 10 != 0 || v2y % 10 != 0 || v3x % 10 != 0 || v3y % 10 != 0)
            {
                rowColumn = new TriangleRowColumn();
                rowColumn.Result = "INVALID COORDINATES: Not divisible by 10";
            }
            else if (v1x < 0 || v1y < 0 || v2x < 0 || v2y < 0 || v3x < 0 || v3y < 0 ||
                     v1x > maxCoord-10 || v1y > maxCoord-10 || v2x > maxCoord || v2y > maxCoord || v3x > maxCoord || v3y > maxCoord)
            {
                rowColumn = new TriangleRowColumn();
                rowColumn.Result = "INVALID COORDINATES: Outside of range (0 - "+maxCoord+")";
            }
            else
            {
                rowColumn = new TriangleRowColumn();
                rowColumn.FindRowColumn(v1x, v1y, v2x, v2y, v3x, v3y);
            }

            return rowColumn;
        }
    }
}
