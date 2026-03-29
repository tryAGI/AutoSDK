//HintName: G.Models.ScanTextResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScanTextResponse
    {
        /// <summary>
        /// Findings indexed one-to-one with input payload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("findings")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.Finding>>? Findings { get; set; }

        /// <summary>
        /// Redacted payloads (if redaction was configured)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redactedPayload")]
        public global::System.Collections.Generic.IList<string>? RedactedPayload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanTextResponse" /> class.
        /// </summary>
        /// <param name="findings">
        /// Findings indexed one-to-one with input payload
        /// </param>
        /// <param name="redactedPayload">
        /// Redacted payloads (if redaction was configured)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScanTextResponse(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.Finding>>? findings,
            global::System.Collections.Generic.IList<string>? redactedPayload)
        {
            this.Findings = findings;
            this.RedactedPayload = redactedPayload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanTextResponse" /> class.
        /// </summary>
        public ScanTextResponse()
        {
        }
    }
}