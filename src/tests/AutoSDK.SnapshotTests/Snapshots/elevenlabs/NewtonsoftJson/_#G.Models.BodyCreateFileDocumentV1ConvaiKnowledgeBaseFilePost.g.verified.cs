//HintName: G.Models.BodyCreateFileDocumentV1ConvaiKnowledgeBaseFilePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateFileDocumentV1ConvaiKnowledgeBaseFilePost
    {
        /// <summary>
        /// Documentation that the agent will have access to in order to interact with users.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// Documentation that the agent will have access to in order to interact with users.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// A custom, human-readable name for the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateFileDocumentV1ConvaiKnowledgeBaseFilePost" /> class.
        /// </summary>
        /// <param name="file">
        /// Documentation that the agent will have access to in order to interact with users.
        /// </param>
        /// <param name="filename">
        /// Documentation that the agent will have access to in order to interact with users.
        /// </param>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
        public BodyCreateFileDocumentV1ConvaiKnowledgeBaseFilePost(
            byte[] file,
            string filename,
            string? name)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateFileDocumentV1ConvaiKnowledgeBaseFilePost" /> class.
        /// </summary>
        public BodyCreateFileDocumentV1ConvaiKnowledgeBaseFilePost()
        {
        }
    }
}