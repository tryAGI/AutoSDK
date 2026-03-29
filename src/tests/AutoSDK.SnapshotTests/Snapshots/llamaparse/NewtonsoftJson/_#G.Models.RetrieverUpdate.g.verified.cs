//HintName: G.Models.RetrieverUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetrieverUpdate
    {
        /// <summary>
        /// A name for the retriever.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The pipelines this retriever uses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelines")]
        public global::System.Collections.Generic.IList<global::G.RetrieverPipeline>? Pipelines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieverUpdate" /> class.
        /// </summary>
        /// <param name="name">
        /// A name for the retriever.
        /// </param>
        /// <param name="pipelines">
        /// The pipelines this retriever uses.
        /// </param>
        public RetrieverUpdate(
            string? name,
            global::System.Collections.Generic.IList<global::G.RetrieverPipeline>? pipelines)
        {
            this.Name = name;
            this.Pipelines = pipelines;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieverUpdate" /> class.
        /// </summary>
        public RetrieverUpdate()
        {
        }
    }
}