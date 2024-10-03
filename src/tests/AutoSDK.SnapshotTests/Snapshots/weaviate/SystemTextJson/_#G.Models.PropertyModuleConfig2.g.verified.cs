//HintName: G.Models.PropertyModuleConfig2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// E.g. `text2vec-transformers`, `text2vec-openai`.
    /// </summary>
    public sealed partial class PropertyModuleConfig2
    {
        /// <summary>
        /// If true, the whole property will NOT be included in vectorization.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip")]
        public bool? Skip { get; set; } = false;

        /// <summary>
        /// Whether the name of the property is used in determining the object vector.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorizePropertyName")]
        public bool? VectorizePropertyName { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}