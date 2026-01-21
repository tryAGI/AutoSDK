//HintName: G.Models.GetVoicesV2V2VoicesGetFineTuningState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the voice's fine tuning to filter by. Applicable only to professional voices clones. One of 'draft', 'not_verified', 'not_started', 'queued', 'fine_tuning', 'fine_tuned', 'failed', 'delayed'
    /// </summary>
    public sealed partial class GetVoicesV2V2VoicesGetFineTuningState
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}