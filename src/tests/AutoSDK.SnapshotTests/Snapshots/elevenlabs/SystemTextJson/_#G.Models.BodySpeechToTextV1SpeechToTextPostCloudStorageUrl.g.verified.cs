//HintName: G.Models.BodySpeechToTextV1SpeechToTextPostCloudStorageUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The valid AWS S3, Cloudflare R2 or Google Cloud Storage URL of the file to transcribe. Exactly one of the file or cloud_storage_url parameters must be provided. The file must be a valid publicly accessible cloud storage URL. The file size must be less than 2GB. URL can be pre-signed.
    /// </summary>
    public sealed partial class BodySpeechToTextV1SpeechToTextPostCloudStorageUrl
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}