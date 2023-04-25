using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.Arm;

namespace cnverter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Shapes_ConvertController : ControllerBase
    {

      
        [HttpGet]
        [Route("test/rectangle")]
        public  String GetArearectangle(string rectangle, double height, double width)
        {

            string shape = "";
            double area = 0;

           area = (height * width);

           
                for (int j = 0; j < height; j++)
                {
                    for (int k = 0; k < width; k++)
                    {
                        shape += ".  ";
                    }
                    shape += "\n";
                }
            return (shape);
            Console.WriteLine(".");

        }

        [HttpGet]
        [Route("api/area/squre")]
        public string GetAreasqure(string squre, double height, double width)
        {
            string shape = "";
            double area = 0;

            area = (height * width);


            for (int j = 0; j < height; j++)
            {
                for (int k = 0; k < width; k++)
                {
                    shape += ".  ";
                }
                shape += "\n";
            }
            return (shape);
            Console.WriteLine(".");



        }


        [HttpGet]
        [Route("api/area/triangle")]
        public string GetAreatriangle(string triangle, double height, double width)
        {
            double area = 0;

            area = (height * width) / 2;

            return area.ToString("\"dots needed for : ") +area;


        }


        [HttpGet]
        [Route("api/area/circle")]
        public string GetAreacircle(string circle, double R)
        {
            double area = 0;

            area = 3.141592653589793238 * R * R;

            return area.ToString("\"dots needed for : ") + area;

        }


        [HttpGet]
        [Route("api/area/parallelogram")]
        public string GetAreaparallelogram(string parallelogram, double height, double width)
        {
            double area = 0;

            area = height * width;

            return area.ToString("\"dots needed for  : ") + area;


        }
    }
}
