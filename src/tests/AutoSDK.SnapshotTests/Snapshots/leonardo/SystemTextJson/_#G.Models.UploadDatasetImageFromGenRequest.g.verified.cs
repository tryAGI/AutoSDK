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
        [global::System.Text.Json.Serialization.JsonPropertyName("generatedImageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GeneratedImageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetImageFromGenRequest" /> class.
        /// </summary>
        /// <param name="generatedImageId">
        /// The ID of the image to upload to the dataset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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