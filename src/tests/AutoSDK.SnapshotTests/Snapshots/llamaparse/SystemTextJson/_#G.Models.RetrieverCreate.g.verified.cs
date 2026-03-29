//HintName: G.Models.RetrieverCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetrieverCreate
    {
        /// <summary>
        /// A name for the retriever tool. Will default to the pipeline name if not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The pipelines this retriever uses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelines")]
        public global::System.Collections.Generic.IList<global::G.RetrieverPipeline>? Pipelines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieverCreate" /> class.
        /// </summary>
        /// <param name="name">
        /// A name for the retriever tool. Will default to the pipeline name if not provided.
        /// </param>
        /// <param name="pipelines">
        /// The pipelines this retriever uses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrieverCreate(
            string name,
            global::System.Collections.Generic.IList<global::G.RetrieverPipeline>? pipelines)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Pipelines = pipelines;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieverCreate" /> class.
        /// </summary>
        public RetrieverCreate()
        {
        }
    }
}