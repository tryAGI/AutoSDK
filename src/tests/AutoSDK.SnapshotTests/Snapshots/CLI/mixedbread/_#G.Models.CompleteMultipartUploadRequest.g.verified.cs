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
        [global::System.Text.Json.Serialization.JsonPropertyName("parts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MultipartUploadPart> Parts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteMultipartUploadRequest" /> class.
        /// </summary>
        /// <param name="parts">
        /// List of completed parts with their ETags
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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