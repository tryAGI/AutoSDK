//HintName: G.Models.UploadDatasetImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadDatasetImageRequest
    {
        /// <summary>
        /// Has to be png, jpg, jpeg, or webp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Extension { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetImageRequest" /> class.
        /// </summary>
        /// <param name="extension">
        /// Has to be png, jpg, jpeg, or webp.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadDatasetImageRequest(
            string extension)
        {
            this.Extension = extension ?? throw new global::System.ArgumentNullException(nameof(extension));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetImageRequest" /> class.
        /// </summary>
        public UploadDatasetImageRequest()
        {
        }
    }
}