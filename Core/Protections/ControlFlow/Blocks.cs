﻿using Core.Helper.Generator.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Protections.ControlFlow
{
    public class Blocks
    {
        public List<Block> blocks = new List<Block>();
        private Generator generator = new Generator();
        public Block getBlock(int id)
        {
            return blocks.Single(block => block.ID == id);
        }

        public void Scramble(out Blocks incGroups)
        {
            Blocks groups = new Blocks();
            foreach (var group in blocks)
                groups.blocks.Insert(generator.Generate<int>(GeneratorType.Integer, groups.blocks.Count), group);
            incGroups = groups;
        }
    }
}
