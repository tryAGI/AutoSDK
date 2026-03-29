//HintName: G.Models.StoreConfig2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for a store.
    /// </summary>
    public sealed partial class StoreConfig2
    {
        /// <summary>
        /// Contextualize files with metadata<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextualization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<bool?, global::G.ContextualizationConfig>))]
        public global::G.AnyOf<bool?, global::G.ContextualizationConfig>? Contextualization { get; set; }

        /// <summary>
        /// Whether to save original content in the store. When False, only vectors are indexed without the original content (index-only mode). This is useful for data privacy. Note: Reranking is not supported when content is not saved.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_content")]
        public bool? SaveContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreConfig2" /> class.
        /// </summary>
        /// <param name="contextualization">
        /// Contextualize files with metadata<br/>
        /// Default Value: false
        /// </param>
        /// <param name="saveContent">
        /// Whether to save original content in the store. When False, only vectors are indexed without the original content (index-only mode). This is useful for data privacy. Note: Reranking is not supported when content is not saved.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreConfig2(
            global::G.AnyOf<bool?, global::G.ContextualizationConfig>? contextualization,
            bool? saveContent)
        {
            this.Contextualization = contextualization;
            this.SaveContent = saveContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreConfig2" /> class.
        /// </summary>
        public StoreConfig2()
        {
        }
    }
}