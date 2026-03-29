//HintName: G.Models.MetadataSendTelemetryRequestEventVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetadataSendTelemetryRequestEventVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MetadataSendTelemetryRequestEventVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public string Timestamp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MetadataSendTelemetryRequestEventVariant1Data Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequestEventVariant1" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="data"></param>
        /// <param name="type"></param>
        public MetadataSendTelemetryRequestEventVariant1(
            string timestamp,
            global::G.MetadataSendTelemetryRequestEventVariant1Data data,
            global::G.MetadataSendTelemetryRequestEventVariant1Type type)
        {
            this.Type = type;
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequestEventVariant1" /> class.
        /// </summary>
        public MetadataSendTelemetryRequestEventVariant1()
        {
        }
    }
}