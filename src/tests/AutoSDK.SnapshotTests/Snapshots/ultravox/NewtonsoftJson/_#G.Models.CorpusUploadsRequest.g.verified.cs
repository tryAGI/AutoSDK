//HintName: G.Models.CorpusUploadsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CorpusUploadsRequest
    {
        /// <summary>
        /// The MIME type of the file to be uploaded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mimeType", Required = global::Newtonsoft.Json.Required.Always)]
        public string MimeType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusUploadsRequest" /> class.
        /// </summary>
        /// <param name="mimeType">
        /// The MIME type of the file to be uploaded.
        /// </param>
        public CorpusUploadsRequest(
            string mimeType)
        {
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusUploadsRequest" /> class.
        /// </summary>
        public CorpusUploadsRequest()
        {
        }
    }
}