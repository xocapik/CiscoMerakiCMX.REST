using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using CiscoMerakiCMX.REST.Models;

namespace CiscoMerakiCMX.REST.Controllers
{
    public class EventsController : ApiController
    {
        //External Documentation: https://documentation.meraki.com/MR/Monitoring_and_Reporting/Scanning_API

        //Get from Meraki cloud app 
        const string VALIDATOR = "";
        //Set in Meraki cloud app
        const string SECRET = "";
        //Supported CMX version
        const string CMXVERSION = "2.0";


        /*
         * Used by the Meraki API to validate this REST service.
         */
        [HttpGet]
        public HttpResponseMessage GetValidator()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent(
                    VALIDATOR,
                    Encoding.UTF8,
                    "text/html"
                    )
            };
        }

        /*
         * Capture Meraki's push events. 
         */
        [HttpPost]
        public void AddDevice([FromBody]Root msg)
        {
            try
            {
                //Check Secret 
                if (msg.secret == SECRET)
                {
                    //Check version
                    if  (msg.version == CMXVERSION)
                    {
                        foreach (var observation in msg.data.observations)
                        {
                            //TODO: save in database or whatever 
                        }
                    }
                    else
                    {
                        //TODO:Log bad secret
                    }
                }
                else
                {
                    //TODO:Log bad version
                }
            }
            catch (Exception e)
            {
                //TODO:Log Exception
            }
        }
    }
}
