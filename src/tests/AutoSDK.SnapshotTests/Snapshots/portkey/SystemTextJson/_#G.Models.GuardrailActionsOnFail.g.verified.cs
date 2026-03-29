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
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GuardrailActionsOnFailFeedback Feedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailActionsOnFail" /> class.
        /// </summary>
        /// <param name="feedback">
        /// Feedback configuration for failed checks
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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