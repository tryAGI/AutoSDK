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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EventTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscribeApiAppEventOpenRequest" /> class.
        /// </summary>
        /// <param name="eventTypes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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