using System;
using Newtonsoft.Json;

namespace СloudСonvert.API.СloudСonvert.Models.TaskModels
{
  public partial class TaskCC
  {
    [JsonProperty("id")]
    public Guid Id { get; set; }

    [JsonProperty("operation")]
    public string Operation { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("credits")]
    public object Credits { get; set; }

    [JsonProperty("message")]
    public object Message { get; set; }

    [JsonProperty("code")]
    public object Code { get; set; }

    [JsonProperty("created_at")]
    public DateTimeOffset? Created_At { get; set; }

    [JsonProperty("started_at")]
    public DateTimeOffset? Started_At { get; set; }

    [JsonProperty("ended_at")]
    public DateTimeOffset? Ended_At { get; set; }

    [JsonProperty("payload")]
    public Payload Payload { get; set; }

    [JsonProperty("result")]
    public Result Result { get; set; }

    [JsonProperty("links")]
    public DatumLinks Links { get; set; }
  }
}
