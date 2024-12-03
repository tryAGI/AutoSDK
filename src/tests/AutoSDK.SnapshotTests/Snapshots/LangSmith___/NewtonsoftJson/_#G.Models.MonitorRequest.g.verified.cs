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
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groups", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MonitorGroupSpec> Groups { get; set; } = default!;

        /// <summary>
        /// Timedelta input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interval")]
        public global::G.TimedeltaInput? Interval { get; set; }

        /// <summary>
        /// Timedelta input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stride")]
        public global::G.TimedeltaInput? Stride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorRequest" /> class.
        /// </summary>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="groups"></param>
        /// <param name="interval">
        /// Timedelta input.
        /// </param>
        /// <param name="stride">
        /// Timedelta input.
        /// </param>
        public MonitorRequest(
            global::System.Collections.Generic.IList<global::G.MonitorGroupSpec> groups,
            string? timezone,
            global::G.TimedeltaInput? interval,
            global::G.TimedeltaInput? stride)
        {
            this.Groups = groups ?? throw new global::System.ArgumentNullException(nameof(groups));
            this.Timezone = timezone;
            this.Interval = interval;
            this.Stride = stride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorRequest" /> class.
        /// </summary>
        public MonitorRequest()
        {
        }
    }
}