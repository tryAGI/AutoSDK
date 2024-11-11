//HintName: G.Models.UploadInitImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadInitImageRequest
    {
        /// <summary>
        /// Has to be png, jpg, jpeg, or webp.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extension", Required = global::Newtonsoft.Json.Required.Always)]
        public string Extension { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadInitImageRequest" /> class.
        /// </summary>
        /// <param name="extension">
        /// Has to be png, jpg, jpeg, or webp.
        /// </param>
        public UploadInitImageRequest(
            string extension)
        {
            this.Extension = extension ?? throw new global::System.ArgumentNullException(nameof(extension));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadInitImageRequest" /> class.
        /// </summary>
        public UploadInitImageRequest()
        {
        }
    }
}