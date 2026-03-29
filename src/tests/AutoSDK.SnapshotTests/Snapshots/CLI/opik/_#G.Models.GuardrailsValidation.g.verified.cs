//HintName: G.Models.GuardrailsValidation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public sealed partial class GuardrailsValidation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        public global::System.Guid? SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        public global::System.Collections.Generic.IList<global::G.Check>? Checks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsValidation" /> class.
        /// </summary>
        /// <param name="spanId"></param>
        /// <param name="checks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailsValidation(
            global::System.Guid? spanId,
            global::System.Collections.Generic.IList<global::G.Check>? checks)
        {
            this.SpanId = spanId;
            this.Checks = checks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsValidation" /> class.
        /// </summary>
        public GuardrailsValidation()
        {
        }
    }
}