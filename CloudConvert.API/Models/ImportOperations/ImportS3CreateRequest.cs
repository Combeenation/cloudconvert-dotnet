using System.Text.Json.Serialization;

namespace CloudConvert.API.Models.ImportOperations
{
  public class ImportS3CreateRequest
  {
    [JsonPropertyName("operation")]
    public string Operation { get; } = "import/s3";

    /// <summary>
    /// The Amazon S3 bucket where to download the file.
    /// </summary>
    [JsonPropertyName("bucket")]
    public string Bucket { get; set; }

    /// <summary>
    /// Specify the Amazon S3 endpoint, e.g. us-west-2 or eu-west-1.
    /// </summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    [JsonPropertyName("endpoint")]
    public string Endpoint { get; set; }

    /// <summary>
    /// S3 key of the input file (the filename in the bucket, including path).
    /// </summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>
    /// Alternatively to using key, you can specify a key prefix for importing multiple files.
    /// </summary>
    [JsonPropertyName("key_prefix")]
    public string Key_Prefix { get; set; }

    /// <summary>
    /// The Amazon S3 access key id.
    /// </summary>
    [JsonPropertyName("access_key_id")]
    public string Access_Key_Id { get; set; }

    /// <summary>
    /// The Amazon S3 secret access key.
    /// </summary>
    [JsonPropertyName("secret_access_key")]
    public string Secret_Access_Key { get; set; }

    /// <summary>
    /// Auth using temporary credentials.
    /// </summary>
    [JsonPropertyName("session_token")]
    public string Session_Token { get; set; }

    [JsonPropertyName("filename")]
    public string Filename { get; set; }
  }
}
