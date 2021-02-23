using Newtonsoft.Json;

namespace СloudСonvert.API.СloudСonvert.Models.TaskModels
{
  public class ImportUploadData : Import
  {
    /// <summary>
    /// Redirect user to this URL after upload
    /// </summary>
    [JsonProperty("redirect")]
    public string Redirect { get; set; }
  }
}
