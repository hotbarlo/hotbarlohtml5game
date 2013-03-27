﻿using System;
using System.Collections.Generic;
using System.IO;

namespace DotLiquid.Custom
{
    public class Loop : DotLiquid.Tag
    {
        private int _max;

        public override void Initialize(string tagName, string markup, List<string> tokens)
        {
            base.Initialize(tagName, markup, tokens);
            _max = Convert.ToInt32(markup);
        }

        public override void Render(Context context, TextWriter result)
        {
            result.Write(new Random().Next(_max).ToString());
            base.Render(context, result);
        }
    }
}
