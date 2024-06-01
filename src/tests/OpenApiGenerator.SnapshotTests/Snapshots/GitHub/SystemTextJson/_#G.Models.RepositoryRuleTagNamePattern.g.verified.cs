//HintName: G.Models.RepositoryRuleTagNamePattern.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters to be used for the tag_name_pattern rule
    /// </summary>
    public sealed partial class RepositoryRuleTagNamePattern
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RepositoryRuleTagNamePatternTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required RepositoryRuleTagNamePatternType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public RepositoryRuleTagNamePatternParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}