//HintName: G.Models.GuardrailsValidationPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public sealed partial class GuardrailsValidationPublic
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
        public global::System.Collections.Generic.IList<global::G.CheckPublic>? Checks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsValidationPublic" /> class.
        /// </summary>
        /// <param name="spanId"></param>
        /// <param name="checks"></param>
        public GuardrailsValidationPublic(
            global::System.Guid? spanId,
            global::System.Collections.Generic.IList<global::G.CheckPublic>? checks)
        {
            this.SpanId = spanId;
            this.Checks = checks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsValidationPublic" /> class.
        /// </summary>
        public GuardrailsValidationPublic()
        {
        }
    }
}