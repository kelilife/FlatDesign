using System.Collections.Generic;

using KeLi.FlatDesign.Example2.Models;

namespace KeLi.FlatDesign.Example2.Utils
{
    public class CustomerUtil
    {
        public static List<CustomerModel> GetCustomerModels()
        {
            return new List<CustomerModel>
            {
                new CustomerModel
                {
                    CustomerName = "Jim",
                    IsMale = true,
                    Phone = "13055668877",
                    Address = "Shanghai, China"
                },
                new CustomerModel
                {
                    CustomerName = "Sam",
                    IsMale = true,
                    Phone = "13587639888",
                    Address = "Shanghai, China"
                },
                new CustomerModel
                {
                    CustomerName = "Michelle",
                    IsMale = false,
                    Phone = "13687876565",
                    Address = "Washington, US"
                },
                new CustomerModel
                {
                    CustomerName = "Mary",
                    IsMale = false,
                    Phone = "13956871289",
                    Address = "Shanghai, China"
                }
            };
        }
    }
}