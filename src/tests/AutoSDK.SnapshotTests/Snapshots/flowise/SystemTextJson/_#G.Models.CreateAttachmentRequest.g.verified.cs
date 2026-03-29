//HintName: G.Models.CreateAttachmentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAttachmentRequest
    {
        /// <summary>
        /// Files to be uploaded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Files { get; set; }

        /// <summary>
        /// Return contents of the files in base64 format<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64")]
        public bool? Base64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAttachmentRequest" /> class.
        /// </summary>
        /// <param name="files">
        /// Files to be uploaded
        /// </param>
        /// <param name="base64">
        /// Return contents of the files in base64 format<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAttachmentRequest(
            global::System.Collections.Generic.IList<byte[]> files,
            bool? base64)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.Base64 = base64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAttachmentRequest" /> class.
        /// </summary>
        public CreateAttachmentRequest()
        {
        }
    }
}