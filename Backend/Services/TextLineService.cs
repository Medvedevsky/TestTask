using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class TextLineService
    {
        public ActionResult<IEnumerable<string>> Data()
        {

            List<string> lines = new List<string>()
            {
                "My name is Linus and I am your God",
                "Microsoft is not evil.",
                "Hello World heheheh"
            };

            return lines;
        }
    }
}
