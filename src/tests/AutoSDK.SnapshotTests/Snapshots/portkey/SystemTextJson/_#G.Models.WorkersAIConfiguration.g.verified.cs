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
        [global::System.Text.Json.Serialization.JsonPropertyName("workers_ai_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkersAiAccountId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkersAIConfiguration" /> class.
        /// </summary>
        /// <param name="workersAiAccountId">
        /// Cloudflare Workers AI account ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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