using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08_01.Models
{
    class DevArray
    {
        internal static Developer[] devArray = new Developer[] {new Junior("Oleg", "Fonov", 1, "Unit testing and integration testing. Report on state and progress." +
            " Encode, debug, document and maintain parts of the software. Participate in assessment and planning.", "SQl. ASP.NET MVC. Git. LINQ", "https://github.com/OlegFonov"),
            new Middle("Vasya", "Pupkin", 3, "Create API modules and support existing API modules. Participating in the improvement of corporate internal development frameworks." +
                " Perform coding, unit and systems testing. Validation of the team’s work code.", "SQl. WebAPI. ASP.NET Core. Git.", "https://github.com/VasyaPupkin"),
            new Senior("Petya", "Popov", 4, "Software application design and development. Provide accurate estimates for work elements. Participate in code peer reviews." +
                " Simplify the development process to provide high-quality policy solutions.", "Win Forms. WPF. WCF. LINQ. JavaScript. TFS. Git", "https://github.com/PetyaPopov"),
            new TeamLead("Oleg", "Kipov", 6, "Provides appropriate documentation for design decisions. Perform coding, unit and systems testing." +
                " Collaborate with team members throughout development lifecycle to improve overall product quality." +
                " Create and maintain unit tests and functional tests in collaboration with the testing team.", "ASP.NET. ASP.NET Core. GraphQL." +
                " RabbitMQ. ElasticSearch. DMS.", "https://github.com/OlegKirov"),
            new Architect("Leonid", "Krapin", 10, "Clarification of project requirements and communication with the customer. Technology research and prototyping." +
                " End product architecture. ee the context and coordinate the various technical areas.", "SQl. ASP.NET Identity. Oracle" +
                ". JSON. ODI. RabbitMQ. MongoDB.", "https://github.com/LeonidKrapin") };

        internal static void ArraySortExp()
        {
            for (int i = 1; i < devArray.Length; i++)
            {
                for (int j = 0; j < devArray.Length - i; j++)
                {
                    if (devArray[j].Experience < devArray[j + 1].Experience)
                    {
                        Developer temp = devArray[j];
                        devArray[j] = devArray[j + 1];
                        devArray[j + 1] = temp;
                    }
                }
            }
        }

        internal static void DevArrayOut()
        {
            for (int i = 0; i < devArray.Length; i++)
            {
                Console.WriteLine($"Employee №{i + 1}: \n{devArray[i]}\n");
            }
        }
    }
}
