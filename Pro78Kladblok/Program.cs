using System;
using visionEntry =  Pro78Kladblok.vision;
using knowledgeEntry = Pro78Kladblok.knowledge;

namespace Pro78Kladblok
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            visionEntry.Entry vision = new visionEntry.Entry();
            vision.doStuff();
            
            
            knowledgeEntry.Entry knowledge = new knowledgeEntry.Entry();
            knowledge.doStuff();
            
            
        }
    }
}