//HintName: G.Models.MetadataSendTelemetryRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetadataSendTelemetryRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MetadataSendTelemetryRequestServiceJsonConverter))]
        public global::G.MetadataSendTelemetryRequestService Service { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EventsItem> Events { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequest" /> class.
        /// </summary>
        /// <param name="events"></param>
        /// <param name="service"></param>
        public MetadataSendTelemetryRequest(
            global::System.Collections.Generic.IList<global::G.EventsItem> events,
            global::G.MetadataSendTelemetryRequestService service)
        {
            this.Service = service;
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequest" /> class.
        /// </summary>
        public MetadataSendTelemetryRequest()
        {
        }
    }
}