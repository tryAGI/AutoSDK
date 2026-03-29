//HintName: G.Models.CompleteMultipartUploadRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompleteMultipartUploadRequest
    {
        /// <summary>
        /// List of completed parts with their ETags
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MultipartUploadPart> Parts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteMultipartUploadRequest" /> class.
        /// </summary>
        /// <param name="parts">
        /// List of completed parts with their ETags
        /// </param>
        public CompleteMultipartUploadRequest(
            global::System.Collections.Generic.IList<global::G.MultipartUploadPart> parts)
        {
            this.Parts = parts ?? throw new global::System.ArgumentNullException(nameof(parts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteMultipartUploadRequest" /> class.
        /// </summary>
        public CompleteMultipartUploadRequest()
        {
        }
    }
}