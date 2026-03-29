//HintName: G.Models.UpdateGuardrailRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateGuardrailRequest
    {
        /// <summary>
        /// Updated name of the guardrail
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated array of guardrail checks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("checks")]
        public global::System.Collections.Generic.IList<global::G.GuardrailCheck>? Checks { get; set; }

        /// <summary>
        /// Actions to take when guardrail checks fail or pass
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actions")]
        public global::G.GuardrailActions? Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGuardrailRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Updated name of the guardrail
        /// </param>
        /// <param name="checks">
        /// Updated array of guardrail checks
        /// </param>
        /// <param name="actions">
        /// Actions to take when guardrail checks fail or pass
        /// </param>
        public UpdateGuardrailRequest(
            string? name,
            global::System.Collections.Generic.IList<global::G.GuardrailCheck>? checks,
            global::G.GuardrailActions? actions)
        {
            this.Name = name;
            this.Checks = checks;
            this.Actions = actions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGuardrailRequest" /> class.
        /// </summary>
        public UpdateGuardrailRequest()
        {
        }
    }
}