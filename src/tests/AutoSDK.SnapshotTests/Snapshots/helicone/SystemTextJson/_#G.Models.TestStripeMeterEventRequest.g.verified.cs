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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestStripeMeterEventRequest" /> class.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="customerId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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