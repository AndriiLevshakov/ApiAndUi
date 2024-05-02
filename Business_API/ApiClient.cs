using Newtonsoft.Json;
using RestSharp;
using static Core_API.ConfigurationManager;

namespace Business_API
{
    public class ApiClient
    {
        private readonly RestClient _client;

        public ApiClient()
        {
            _client = new RestClient(BaseUrl);
        }

        public RestResponse Get()
        {
            var request = new RestRequest(BaseUrl, Method.Get);

            return _client.Execute(request);
        }

        public List<User> GetUsers(RestResponse response)
        {
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<User>>(response.Content);
        }

        public RestResponse Post()
        {
            var request = new RestRequest(BaseUrl, Method.Post);

            request.AddJsonBody(RequestBody);

            return _client.Execute(request);
        }

        public RestResponse GetFromInvalidEndpoint()
        {
            var request = new RestRequest(InvalidEndpoint, Method.Get);

            return _client.Execute(request);
        }
    }
}

