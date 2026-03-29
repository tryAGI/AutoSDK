//HintName: G.Models.GuardrailActionsOnFail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Actions to take when guardrail check fails
    /// </summary>
    public sealed partial class GuardrailActionsOnFail
    {
        /// <summary>
        /// Feedback configuration for failed checks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GuardrailActionsOnFailFeedback Feedback { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailActionsOnFail" /> class.
        /// </summary>
        /// <param name="feedback">
        /// Feedback configuration for failed checks
        /// </param>
        public GuardrailActionsOnFail(
            global::G.GuardrailActionsOnFailFeedback feedback)
        {
            this.Feedback = feedback ?? throw new global::System.ArgumentNullException(nameof(feedback));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailActionsOnFail" /> class.
        /// </summary>
        public GuardrailActionsOnFail()
        {
        }
    }
}