//HintName: G.Models.UltravoxV1UploadSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The specification of how to acquire documents for uploaded documents source.
    /// </summary>
    public sealed partial class UltravoxV1UploadSpec
    {
        /// <summary>
        /// The IDs of uploaded documents. These documents must<br/>
        ///  have been previously uploaded using the document upload API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documentIds")]
        public global::System.Collections.Generic.IList<string>? DocumentIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1UploadSpec" /> class.
        /// </summary>
        /// <param name="documentIds">
        /// The IDs of uploaded documents. These documents must<br/>
        ///  have been previously uploaded using the document upload API.
        /// </param>
        public UltravoxV1UploadSpec(
            global::System.Collections.Generic.IList<string>? documentIds)
        {
            this.DocumentIds = documentIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1UploadSpec" /> class.
        /// </summary>
        public UltravoxV1UploadSpec()
        {
        }
    }
}