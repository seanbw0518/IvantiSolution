# IvantiSolution

### **Description:**

This simple API provides 2 endpoints, /TriangleCoords & /TriangleRowColumn.
 - /TriangleCoords will return the 3 pairs of int coordinates given a char row and int column
 - /TriangleRowColumn will return a char row and int column given 3 pairs of int coordinates
   **Note:** vertex 1 (v1x, v1y) is the top-left vertex, vertex 2 is at the right angle, and vertex 3 is the bottom-right vertex.
  See the Swagger front end for all the information
Valid inputs will also return a result "VALID" whereas invalid ones return a relevant error message, e.g., providing a row as 'X' is not an available row.
I haven't made a custom frontend, as discussed in my last interview I don't have too much experience with frontend so that could be skipped.
You can open the solution in VisualStudio to run the unit tests I created.

### **To run the API:**

1. Download the repo
2. Navigate to the IvantiSolution directory (the one with the .sln file in it)
3. Open the command prompt at this location and type "dotnet run"
4. After it builds, it should provide 2 localhost addresses, copy either one and paste it into your browser.
5. Add /swagger to the end and hit enter
6. You should see the Swagger front end where you can test the two endpoints: /TriangleCoords & /TriangleRowColumn
7. Click the "Try it out" button under each endpoint, input the parameters, and click Execute. The response is shown below.

### **Dependencies:**

This runs using .NET 6.0 and ASP.NET. The front end is all provided by Swagger (the default you get when creating a new ASP.NET project in Visual Studio). This should be enough to run it, let me know if not!

*I look forward to speaking with you in the next interview! :)*
