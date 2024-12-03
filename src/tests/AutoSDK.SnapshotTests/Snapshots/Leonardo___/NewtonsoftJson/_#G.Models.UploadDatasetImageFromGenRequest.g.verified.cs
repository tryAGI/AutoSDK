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

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetImageFromGenRequest" /> class.
        /// </summary>
        /// <param name="generatedImageId">
        /// The ID of the image to upload to the dataset.
        /// </param>
        public UploadDatasetImageFromGenRequest(
            string generatedImageId)
        {
            this.GeneratedImageId = generatedImageId ?? throw new global::System.ArgumentNullException(nameof(generatedImageId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetImageFromGenRequest" /> class.
        /// </summary>
        public UploadDatasetImageFromGenRequest()
        {
        }
    }
}