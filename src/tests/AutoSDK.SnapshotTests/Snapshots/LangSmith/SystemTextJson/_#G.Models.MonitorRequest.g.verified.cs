//HintName: G.Models.MonitorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MonitorRequest
    {
        /// <summary>
        /// Default Value: UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; } = "UTC";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MonitorGroupSpec> Groups { get; set; }

        /// <summary>
        /// Timedelta input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stride")]
        public global::G.TimedeltaInput? Stride { get; set; }

        /// <summary>
        /// Timedelta input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        public global::G.TimedeltaInput? Interval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}