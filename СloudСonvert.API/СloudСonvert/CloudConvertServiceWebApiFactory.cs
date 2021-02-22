using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;

namespace СloudСonvert.API.СloudСonvert
{
  public static class CloudConvertServiceWebApiFactory
  {
    public static ICloudConvertServiceWebApi CreateWebApi(string serverUrl)
    {
      return RestService.For<ICloudConvertServiceWebApi>(serverUrl, new RefitSettings
      {
        HttpMessageHandlerFactory = () => new WebApiHandler(loggingEnabled: false),
        ContentSerializer = new NewtonsoftJsonContentSerializer()
      });
    }
  }
}
