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
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MonitorGroupSpec> Groups { get; set; }

        /// <summary>
        /// Timedelta input.<br/>
        /// Default Value: {"days":7,"minutes":0,"hours":0}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        public global::G.TimedeltaInput? Interval { get; set; }

        /// <summary>
        /// Timedelta input.<br/>
        /// Default Value: {"days":0,"minutes":15,"hours":0}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stride")]
        public global::G.TimedeltaInput? Stride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorRequest" /> class.
        /// </summary>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="groups"></param>
        /// <param name="interval">
        /// Timedelta input.<br/>
        /// Default Value: {"days":7,"minutes":0,"hours":0}
        /// </param>
        /// <param name="stride">
        /// Timedelta input.<br/>
        /// Default Value: {"days":0,"minutes":15,"hours":0}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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