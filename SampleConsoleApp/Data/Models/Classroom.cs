using SampleConsoleApp.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp.Data.Models
{
    public class Classroom : BaseModel
    {
        private static int id = 1;

        public Classroom()
        {
            Id = id;
            id++;
        }

        public string Name { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public List<Student> Students { get; set; } = new();
    }
}
