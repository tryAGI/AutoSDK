//HintName: G.Models.OtlpSpanTraceState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// trace_state conveys information about request position in multiple distributed tracing graphs. It is a trace_state in w3c-trace-context format: https://www.w3.org/TR/trace-context/#tracestate-header<br/>
    /// See also https://github.com/w3c/distributed-tracing for more details about this field.
    /// </summary>
    public sealed partial class OtlpSpanTraceState
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}