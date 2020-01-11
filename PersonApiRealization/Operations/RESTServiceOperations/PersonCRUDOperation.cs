using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PersonApiRealization.Operations.RESTServiceOperations
{
    public  class PersonCRUDOperation :ICrudOperations
    {
        public  async Task<IRestResponse> InsertOperation(object model)
        {
            RestClient client = new RestClient("https://localhost:44357/api/person");
            RestRequest restRequest = new RestRequest();
            restRequest.Method = Method.POST;
            restRequest.RequestFormat = DataFormat.Json;
            var fomrmarted = JsonConvert.SerializeObject(model);
            JObject jObject = JObject.Parse(fomrmarted);
            restRequest.AddParameter("application/json", jObject, ParameterType.RequestBody);
            return await client.ExecuteAsync(restRequest,CancellationToken.None);
            
        }

        public async Task<IRestResponse> DeleteOperation(int id)
        {
            RestClient client = new RestClient($"https://localhost:44357/api/person/{id}");
            RestRequest request = new RestRequest(Method.DELETE);
            return await client.ExecuteAsync(request, CancellationToken.None);
        }

        public async Task<IRestResponse> GetAllElementsOperation()
        {
            RestClient client = new RestClient("https://localhost:44357/api/person");
            RestRequest restRequest = new RestRequest(Method.GET);
            return await client.ExecuteAsync(restRequest, CancellationToken.None);
        }

        public  Task<object> GetElementByEmail([EmailAddress] string email)
        {
            throw new NotImplementedException();
        }

        public  Task<object> GetElementByID(int id)
        {
            throw new NotImplementedException();
        }

    

        public async Task<IRestResponse> UpdateOperation(int id,object model)
        {
            RestClient client = new RestClient($"https://localhost:44357/api/person/{id}");
            RestRequest request = new RestRequest(Method.PUT);
            request.RequestFormat = DataFormat.Json;
            string JsonFormatedObject = JsonConvert.SerializeObject(model);
            JObject obj = JObject.Parse(JsonFormatedObject);
            request.AddParameter("application/json", obj, ParameterType.RequestBody);
            return await client.ExecuteAsync(request, CancellationToken.None);
        }
    }
}
