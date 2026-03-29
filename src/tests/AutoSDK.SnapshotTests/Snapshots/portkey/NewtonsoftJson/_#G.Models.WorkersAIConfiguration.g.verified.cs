//HintName: G.Models.WorkersAIConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkersAIConfiguration
    {
        /// <summary>
        /// Cloudflare Workers AI account ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workers_ai_account_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string WorkersAiAccountId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkersAIConfiguration" /> class.
        /// </summary>
        /// <param name="workersAiAccountId">
        /// Cloudflare Workers AI account ID
        /// </param>
        public WorkersAIConfiguration(
            string workersAiAccountId)
        {
            this.WorkersAiAccountId = workersAiAccountId ?? throw new global::System.ArgumentNullException(nameof(workersAiAccountId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkersAIConfiguration" /> class.
        /// </summary>
        public WorkersAIConfiguration()
        {
        }
    }
}