//HintName: G.Models.KnowledgeBase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBase
    {
        /// <summary>
        /// The name of the knowledge base<br/>
        /// Example: My Knowledge Base
        /// </summary>
        /// <example>My Knowledge Base</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The provider of the knowledge base<br/>
        /// Example: google
        /// </summary>
        /// <example>google</example>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.KnowledgeBaseProviderJsonConverter))]
        public global::G.KnowledgeBaseProvider Provider { get; set; }

        /// <summary>
        /// The model to use for the knowledge base
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.KnowledgeBaseModelJsonConverter))]
        public global::G.KnowledgeBaseModel? Model { get; set; }

        /// <summary>
        /// A description of the knowledge base
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The file IDs associated with this knowledge base
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> FileIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBase" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the knowledge base<br/>
        /// Example: My Knowledge Base
        /// </param>
        /// <param name="description">
        /// A description of the knowledge base
        /// </param>
        /// <param name="fileIds">
        /// The file IDs associated with this knowledge base
        /// </param>
        /// <param name="provider">
        /// The provider of the knowledge base<br/>
        /// Example: google
        /// </param>
        /// <param name="model">
        /// The model to use for the knowledge base
        /// </param>
        public KnowledgeBase(
            string name,
            string description,
            global::System.Collections.Generic.IList<string> fileIds,
            global::G.KnowledgeBaseProvider provider,
            global::G.KnowledgeBaseModel? model)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Provider = provider;
            this.Model = model;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.FileIds = fileIds ?? throw new global::System.ArgumentNullException(nameof(fileIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBase" /> class.
        /// </summary>
        public KnowledgeBase()
        {
        }
    }
}