﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class OracleUpdateQuery : OracleTemplateBase
    {
        protected override void ExecuteQuery()
        {
            Console.WriteLine("Update DB im Oracle .....");
        }
    }
}