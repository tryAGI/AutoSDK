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
        [global::Newtonsoft.Json.JsonProperty("span_id")]
        public global::System.Guid? SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("checks")]
        public global::System.Collections.Generic.IList<global::G.Check>? Checks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsValidation" /> class.
        /// </summary>
        /// <param name="spanId"></param>
        /// <param name="checks"></param>
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