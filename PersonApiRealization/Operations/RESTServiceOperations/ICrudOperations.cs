using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApiRealization.Operations.RESTServiceOperations
{
    public  interface ICrudOperations
    {
        Task<IRestResponse> InsertOperation(object model);
        Task<IRestResponse> UpdateOperation(int id,object model);
        Task<IRestResponse> DeleteOperation(int id);
        Task<IRestResponse> GetAllElementsOperation();
        Task<object> GetElementByID(int id);
        Task<object> GetElementByEmail([EmailAddress] string email);
    }
}
