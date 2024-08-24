//HintName: G.Models.UploadDatasetImageFromGenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadDatasetImageFromGenRequest
    {
        /// <summary>
        /// The ID of the image to upload to the dataset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generatedImageId", Required = global::Newtonsoft.Json.Required.Always)]
        public string GeneratedImageId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}