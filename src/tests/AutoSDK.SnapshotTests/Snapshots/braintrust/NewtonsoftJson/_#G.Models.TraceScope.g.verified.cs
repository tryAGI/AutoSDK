//HintName: G.Models.TraceScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Process entire traces (all spans sharing the same root_span_id)
    /// </summary>
    public sealed partial class TraceScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TraceScopeTypeJsonConverter))]
        public global::G.TraceScopeType Type { get; set; }

        /// <summary>
        /// Consider trace complete after this many seconds of inactivity (default: 30)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("idle_seconds")]
        public double? IdleSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceScope" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="idleSeconds">
        /// Consider trace complete after this many seconds of inactivity (default: 30)
        /// </param>
        public TraceScope(
            global::G.TraceScopeType type,
            double? idleSeconds)
        {
            this.Type = type;
            this.IdleSeconds = idleSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceScope" /> class.
        /// </summary>
        public TraceScope()
        {
        }
    }
}