//HintName: G.Models.CollectionModuleConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// E.g. `text2vec-transformers`, `text2vec-openai`.
    /// </summary>
    public sealed partial class CollectionModuleConfig
    {
        /// <summary>
        /// Whether the name of the collection is used in determining the object vector.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorizeClassName")]
        public bool? VectorizeClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionModuleConfig" /> class.
        /// </summary>
        /// <param name="vectorizeClassName">
        /// Whether the name of the collection is used in determining the object vector.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionModuleConfig(
            bool? vectorizeClassName)
        {
            this.VectorizeClassName = vectorizeClassName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionModuleConfig" /> class.
        /// </summary>
        public CollectionModuleConfig()
        {
        }
    }
}