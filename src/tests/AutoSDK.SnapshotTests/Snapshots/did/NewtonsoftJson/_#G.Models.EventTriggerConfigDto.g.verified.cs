//HintName: G.Models.EventTriggerConfigDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EventTriggerConfigDto
    {
        /// <summary>
        /// Webhooks executed when the event occurs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhooks")]
        public global::System.Collections.Generic.IList<global::G.EventTriggerConfigDtoWebhook>? Webhooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventTriggerConfigDto" /> class.
        /// </summary>
        /// <param name="webhooks">
        /// Webhooks executed when the event occurs.
        /// </param>
        public EventTriggerConfigDto(
            global::System.Collections.Generic.IList<global::G.EventTriggerConfigDtoWebhook>? webhooks)
        {
            this.Webhooks = webhooks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventTriggerConfigDto" /> class.
        /// </summary>
        public EventTriggerConfigDto()
        {
        }
    }
}