//HintName: G.Models.MetadataSendTelemetryRequestEventVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetadataSendTelemetryRequestEventVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MetadataSendTelemetryRequestEventVariant5Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public string Timestamp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MetadataSendTelemetryRequestEventVariant5Data Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequestEventVariant5" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="data"></param>
        /// <param name="type"></param>
        public MetadataSendTelemetryRequestEventVariant5(
            string timestamp,
            global::G.MetadataSendTelemetryRequestEventVariant5Data data,
            global::G.MetadataSendTelemetryRequestEventVariant5Type type)
        {
            this.Type = type;
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequestEventVariant5" /> class.
        /// </summary>
        public MetadataSendTelemetryRequestEventVariant5()
        {
        }
    }
}