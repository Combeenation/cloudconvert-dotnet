using Newtonsoft.Json;

namespace СloudСonvert.API.СloudСonvert.Models.TaskModels
{
  public partial class ImportUpload
  {
    [JsonProperty("operation")]
    public string Operation { get; set; } = "import/upload";
  }
}
