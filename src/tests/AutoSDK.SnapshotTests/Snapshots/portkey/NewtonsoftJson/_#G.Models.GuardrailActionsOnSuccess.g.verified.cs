//HintName: G.Models.GuardrailActionsOnSuccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Actions to take when guardrail check passes
    /// </summary>
    public sealed partial class GuardrailActionsOnSuccess
    {
        /// <summary>
        /// Feedback configuration for successful checks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GuardrailActionsOnSuccessFeedback Feedback { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailActionsOnSuccess" /> class.
        /// </summary>
        /// <param name="feedback">
        /// Feedback configuration for successful checks
        /// </param>
        public GuardrailActionsOnSuccess(
            global::G.GuardrailActionsOnSuccessFeedback feedback)
        {
            this.Feedback = feedback ?? throw new global::System.ArgumentNullException(nameof(feedback));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailActionsOnSuccess" /> class.
        /// </summary>
        public GuardrailActionsOnSuccess()
        {
        }
    }
}