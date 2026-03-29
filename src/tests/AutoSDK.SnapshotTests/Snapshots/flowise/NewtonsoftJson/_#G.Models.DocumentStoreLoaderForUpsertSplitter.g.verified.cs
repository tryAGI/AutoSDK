//HintName: G.Models.DocumentStoreLoaderForUpsertSplitter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentStoreLoaderForUpsertSplitter
    {
        /// <summary>
        /// Name of the text splitter (camelCase)<br/>
        /// Example: recursiveCharacterTextSplitter
        /// </summary>
        /// <example>recursiveCharacterTextSplitter</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Configuration for the text splitter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForUpsertSplitter" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the text splitter (camelCase)<br/>
        /// Example: recursiveCharacterTextSplitter
        /// </param>
        /// <param name="config">
        /// Configuration for the text splitter
        /// </param>
        public DocumentStoreLoaderForUpsertSplitter(
            string? name,
            object? config)
        {
            this.Name = name;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForUpsertSplitter" /> class.
        /// </summary>
        public DocumentStoreLoaderForUpsertSplitter()
        {
        }
    }
}