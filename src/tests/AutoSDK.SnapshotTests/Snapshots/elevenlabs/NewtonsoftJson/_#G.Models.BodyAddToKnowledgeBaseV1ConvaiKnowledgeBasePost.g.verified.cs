//HintName: G.Models.BodyAddToKnowledgeBaseV1ConvaiKnowledgeBasePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddToKnowledgeBaseV1ConvaiKnowledgeBasePost
    {
        /// <summary>
        /// A custom, human-readable name for the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL to a page of documentation that the agent will have access to in order to interact with users.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Documentation that the agent will have access to in order to interact with users.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// Documentation that the agent will have access to in order to interact with users.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddToKnowledgeBaseV1ConvaiKnowledgeBasePost" /> class.
        /// </summary>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
        /// <param name="url">
        /// URL to a page of documentation that the agent will have access to in order to interact with users.
        /// </param>
        /// <param name="file">
        /// Documentation that the agent will have access to in order to interact with users.
        /// </param>
        /// <param name="filename">
        /// Documentation that the agent will have access to in order to interact with users.
        /// </param>
        public BodyAddToKnowledgeBaseV1ConvaiKnowledgeBasePost(
            string? name,
            string? url,
            byte[]? file,
            string? filename)
        {
            this.Name = name;
            this.Url = url;
            this.File = file;
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddToKnowledgeBaseV1ConvaiKnowledgeBasePost" /> class.
        /// </summary>
        public BodyAddToKnowledgeBaseV1ConvaiKnowledgeBasePost()
        {
        }
    }
}