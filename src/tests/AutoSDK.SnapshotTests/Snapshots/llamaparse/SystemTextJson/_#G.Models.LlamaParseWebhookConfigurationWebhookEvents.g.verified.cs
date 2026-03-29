//HintName: G.Models.LlamaParseWebhookConfigurationWebhookEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Events that trigger this webhook. Options: 'parse.success' (job completed), 'parse.failure' (job failed), 'parse.partial' (some pages failed). If not specified, webhook fires for all events
    /// </summary>
    public sealed partial class LlamaParseWebhookConfigurationWebhookEvents
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}