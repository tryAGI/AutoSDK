//HintName: G.Models.ContextualizationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextualizationConfig
    {
        /// <summary>
        /// Include all metadata or specific fields in the contextualization. Supports dot notation for nested fields (e.g., 'author.name'). When True, all metadata is included (flattened). When a list, only specified fields are included.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>))]
        public global::G.AnyOf<bool?, global::System.Collections.Generic.IList<string>>? WithMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextualizationConfig" /> class.
        /// </summary>
        /// <param name="withMetadata">
        /// Include all metadata or specific fields in the contextualization. Supports dot notation for nested fields (e.g., 'author.name'). When True, all metadata is included (flattened). When a list, only specified fields are included.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextualizationConfig(
            global::G.AnyOf<bool?, global::System.Collections.Generic.IList<string>>? withMetadata)
        {
            this.WithMetadata = withMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextualizationConfig" /> class.
        /// </summary>
        public ContextualizationConfig()
        {
        }
    }
}