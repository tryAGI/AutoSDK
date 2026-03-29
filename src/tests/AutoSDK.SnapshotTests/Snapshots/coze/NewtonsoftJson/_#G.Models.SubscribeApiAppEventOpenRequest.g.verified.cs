//HintName: G.Models.SubscribeApiAppEventOpenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscribeApiAppEventOpenRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_types", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> EventTypes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscribeApiAppEventOpenRequest" /> class.
        /// </summary>
        /// <param name="eventTypes"></param>
        public SubscribeApiAppEventOpenRequest(
            global::System.Collections.Generic.IList<string> eventTypes)
        {
            this.EventTypes = eventTypes ?? throw new global::System.ArgumentNullException(nameof(eventTypes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscribeApiAppEventOpenRequest" /> class.
        /// </summary>
        public SubscribeApiAppEventOpenRequest()
        {
        }
    }
}