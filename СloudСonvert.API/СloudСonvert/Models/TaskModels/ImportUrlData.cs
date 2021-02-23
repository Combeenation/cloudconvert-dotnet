using System.Collections.Generic;
using Newtonsoft.Json;

namespace СloudСonvert.API.СloudСonvert.Models.TaskModels
{
  public class ImportUrlData : Import
  {
    [JsonProperty("url")]
    public string Url { get; set; }

    /// <summary>
    /// The filename of the input file, including extension. If none provided we will try to detect the filename from the URL.
    /// </summary>
    [JsonProperty("filename")]
    public string Filename { get; set; }

    [JsonProperty("headers")]
    public Dictionary<string, string> Headers { get; set; }

  }
}
