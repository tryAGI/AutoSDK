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
        public bool? Skip { get; set; }

        /// <summary>
        /// Whether the name of the property is used in determining the object vector.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorizePropertyName")]
        public bool? VectorizePropertyName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyModuleConfig2" /> class.
        /// </summary>
        /// <param name="skip">
        /// If true, the whole property will NOT be included in vectorization.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="vectorizePropertyName">
        /// Whether the name of the property is used in determining the object vector.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertyModuleConfig2(
            bool? skip,
            bool? vectorizePropertyName)
        {
            this.Skip = skip;
            this.VectorizePropertyName = vectorizePropertyName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyModuleConfig2" /> class.
        /// </summary>
        public PropertyModuleConfig2()
        {
        }
    }
}