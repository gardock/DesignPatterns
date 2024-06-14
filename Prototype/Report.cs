using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Report
    {
        public int ID { get; set; }
        public HeaderData Info { get; set; }

        public Report DeepCopy()
        {
            Report report = new Report();
            report.ID = ID;
            report.Info = new HeaderData()
            {
                Title = Info.Title,
                Author = Info.Author,
            };
            return report;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Info - Title : {Info.Title}, Info - Author : {Info.Author}";
        }
    }
}
