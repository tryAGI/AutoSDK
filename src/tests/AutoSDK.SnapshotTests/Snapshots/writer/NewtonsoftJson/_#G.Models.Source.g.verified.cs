//HintName: G.Models.Source.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A source snippet containing text and fileId from Knowledge Graph content.
    /// </summary>
    public sealed partial class Source
    {
        /// <summary>
        /// The unique identifier of the file in your Writer account.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// The exact text snippet from the source document that was used to support the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("snippet", Required = global::Newtonsoft.Json.Required.Always)]
        public string Snippet { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Source" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The unique identifier of the file in your Writer account.
        /// </param>
        /// <param name="snippet">
        /// The exact text snippet from the source document that was used to support the response.
        /// </param>
        public Source(
            string fileId,
            string snippet)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Snippet = snippet ?? throw new global::System.ArgumentNullException(nameof(snippet));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Source" /> class.
        /// </summary>
        public Source()
        {
        }
    }
}