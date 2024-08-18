//HintName: G.Models.RepositoryRuleCreation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Only allow users with bypass permission to create matching refs.
    /// </summary>
    public sealed partial class RepositoryRuleCreation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RepositoryRuleCreationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RepositoryRuleCreationType Type { get; set; } = global::G.RepositoryRuleCreationType.Creation;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}