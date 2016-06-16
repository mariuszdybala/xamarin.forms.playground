using System;
using Realms;

namespace Playground.Models
{
    public class Person : RealmObject
    {
        public string Name { get; set; }
        public RealmList<Dog> Dogs { get; } 
    }
}

