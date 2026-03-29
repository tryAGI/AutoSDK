//HintName: G.Models.ScheduledMessagesScheduleAgentMessageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesScheduleAgentMessageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_scheduled_at")]
        public string? NextScheduledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nextScheduledAt"></param>
        public ScheduledMessagesScheduleAgentMessageResponse(
            string id,
            string? nextScheduledAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.NextScheduledAt = nextScheduledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesScheduleAgentMessageResponse" /> class.
        /// </summary>
        public ScheduledMessagesScheduleAgentMessageResponse()
        {
        }
    }
}