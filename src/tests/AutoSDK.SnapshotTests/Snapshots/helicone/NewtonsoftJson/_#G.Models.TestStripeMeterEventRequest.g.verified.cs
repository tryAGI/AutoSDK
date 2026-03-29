//HintName: G.Models.TestStripeMeterEventRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestStripeMeterEventRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customer_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CustomerId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestStripeMeterEventRequest" /> class.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="customerId"></param>
        public TestStripeMeterEventRequest(
            string eventName,
            string customerId)
        {
            this.EventName = eventName ?? throw new global::System.ArgumentNullException(nameof(eventName));
            this.CustomerId = customerId ?? throw new global::System.ArgumentNullException(nameof(customerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestStripeMeterEventRequest" /> class.
        /// </summary>
        public TestStripeMeterEventRequest()
        {
        }
    }
}