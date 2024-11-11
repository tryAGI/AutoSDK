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
        [global::Newtonsoft.Json.JsonProperty("context", Required = global::Newtonsoft.Json.Required.Always)]
        public string Context { get; set; } = default!;

        /// <summary>
        /// The optional integration ID that this status check must originate from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_id")]
        public int? IntegrationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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