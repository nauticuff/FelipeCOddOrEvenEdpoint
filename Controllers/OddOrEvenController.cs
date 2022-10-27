/*
Carlos Felipe
10/26/22
OddOrEven - Endpoint
CODE: This code tells a user if the integer entered is odd or even.
Peer review by : Jessie Lamzon
//Code works well and is with assignment requirements.  I really like how the code is structured, very clean and simple.  Goood job!
*/
using Microsoft.AspNetCore.Mvc;

namespace FelipeCOddOrEven.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    public string Instructions(){
        return "Type in oddoreven/Number to check";
    }

    [HttpGet]
    [Route("{num}")]
    public string OddOrEven(int num) => num % 2 == 0 ? $"{num} is an even number" : $"{num} is an odd number";
}
