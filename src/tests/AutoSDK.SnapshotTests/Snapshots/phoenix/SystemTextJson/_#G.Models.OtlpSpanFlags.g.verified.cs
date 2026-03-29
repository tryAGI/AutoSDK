//HintName: G.Models.OtlpSpanFlags.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Flags, a bit field.<br/>
    /// Bits 0-7 (8 least significant bits) are the trace flags as defined in W3C Trace Context specification. To read the 8-bit W3C trace flag, use `flags &amp; SPAN_FLAGS_TRACE_FLAGS_MASK`.<br/>
    /// See https://www.w3.org/TR/trace-context-2/#trace-flags for the flag definitions.<br/>
    /// Bits 8 and 9 represent the 3 states of whether a span's parent is remote. The states are (unknown, is not remote, is remote).<br/>
    /// To read whether the value is known, use `(flags &amp; SPAN_FLAGS_CONTEXT_HAS_IS_REMOTE_MASK) != 0`.<br/>
    /// To read whether the span is remote, use `(flags &amp; SPAN_FLAGS_CONTEXT_IS_REMOTE_MASK) != 0`.<br/>
    /// When creating span messages, if the message is logically forwarded from another source with an equivalent flags fields (i.e., usually another OTLP span message), the field SHOULD be copied as-is. If creating from a source that does not have an equivalent flags field (such as a runtime representation of an OpenTelemetry span), the high 22 bits MUST be set to zero.<br/>
    /// Readers MUST NOT assume that bits 10-31 (22 most significant bits) will be zero.<br/>
    /// [Optional].
    /// </summary>
    public sealed partial class OtlpSpanFlags
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}