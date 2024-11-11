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

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsStatusCheckConfiguration" /> class.
        /// </summary>
        /// <param name="context">
        /// The status check context name that must be present on the commit.
        /// </param>
        /// <param name="integrationId">
        /// The optional integration ID that this status check must originate from.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryRuleParamsStatusCheckConfiguration(
            string context,
            int? integrationId)
        {
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.IntegrationId = integrationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsStatusCheckConfiguration" /> class.
        /// </summary>
        public RepositoryRuleParamsStatusCheckConfiguration()
        {
        }
    }
}