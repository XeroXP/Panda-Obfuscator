﻿using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Protections.StringEncoding
{
    public class StringEncodingProtection : PandaProtection
    {
        public override string Name => "String Encoding";

        public override string Description => "Protecting your string with Base64 Encryption method";

        public override string Id => "panda.StringEncoding";

        public override string Author => "CodeOfDark";

        public override void Execute(PandaContext pandaContext)
        {
            StringEncoding.Encoding(pandaContext);
        }

        public override void Register(PandaContext pandaContext)
        {
            pandaContext.register.RegisterModule(this); //Need this to register Module
        }
    }
}
