using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAPAS.APP.UI.DataStore
{
    public class OfferingDetails
    {
        public string OfferingId
        {
            get { return Guid.NewGuid().ToString(); }
        }
        public string Name { get; set; }
        public string Rate { get; set; }

        public bool CarrierRequired { get; set; }
        public string Time { get; set; }

        public bool SpecialDayOnly { get; set; }

        //public bool IsDaily { get; set; }

        public bool RequiresEnquiry { get; set; }

    }
    public class OfferingServiceClient 
    {
        public static List<OfferingDetails> OfferingMaster
        {
            get {

                return new List<OfferingDetails>()
                {
                    new OfferingDetails(){ Name="Archana",Rate="15"},

                    new OfferingDetails(){ Name="GanapathyHoomam",Rate="30",CarrierRequired=true,Time="Morning"},

                    new OfferingDetails(){ Name="PaalPaayasam",Rate="60",CarrierRequired=true,Time="Morning"},

                    new OfferingDetails(){ Name="Ghee Vilakku",Rate="10"},

                    new OfferingDetails(){ Name="Maala",Rate="10"},

                    new OfferingDetails(){ Name="Camphor",Rate="10"},

                    new OfferingDetails(){ Name="Vehicle Pooja",Rate="100"},

                    new OfferingDetails(){ Name="Thulabhaaram",Rate="100",Time="Morning"},

                    new OfferingDetails(){ Name="NellParra",Rate="100",SpecialDayOnly=true,RequiresEnquiry=true},

                    new OfferingDetails(){ Name="Chuttuvilakku",Rate="500",Time="Evening",SpecialDayOnly=true,RequiresEnquiry=true},

                    new OfferingDetails(){ Name="Neeranjanam",Rate="20"},
                };
            }
        }
    }
}
