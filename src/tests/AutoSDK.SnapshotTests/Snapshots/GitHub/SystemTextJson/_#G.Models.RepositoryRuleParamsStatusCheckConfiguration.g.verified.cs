//HintName: G.Models.RepositoryRuleParamsStatusCheckConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required status check
    /// </summary>
    public sealed partial class RepositoryRuleParamsStatusCheckConfiguration
    {
        /// <summary>
        /// The status check context name that must be present on the commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Context { get; set; }

        /// <summary>
        /// The optional integration ID that this status check must originate from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_id")]
        public int? IntegrationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}