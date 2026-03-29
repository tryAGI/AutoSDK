//HintName: G.Models.GuardrailActions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Actions to take when guardrail checks fail or pass
    /// </summary>
    public sealed partial class GuardrailActions
    {
        /// <summary>
        /// Whether to deny the request when guardrail check fails<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deny")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deny { get; set; }

        /// <summary>
        /// Whether the guardrail check should be performed asynchronously<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Async { get; set; }

        /// <summary>
        /// Actions to take when guardrail check passes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GuardrailActionsOnSuccess OnSuccess { get; set; }

        /// <summary>
        /// Actions to take when guardrail check fails
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_fail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GuardrailActionsOnFail OnFail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailActions" /> class.
        /// </summary>
        /// <param name="deny">
        /// Whether to deny the request when guardrail check fails<br/>
        /// Default Value: false
        /// </param>
        /// <param name="async">
        /// Whether the guardrail check should be performed asynchronously<br/>
        /// Default Value: false
        /// </param>
        /// <param name="onSuccess">
        /// Actions to take when guardrail check passes
        /// </param>
        /// <param name="onFail">
        /// Actions to take when guardrail check fails
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailActions(
            bool deny,
            bool async,
            global::G.GuardrailActionsOnSuccess onSuccess,
            global::G.GuardrailActionsOnFail onFail)
        {
            this.Deny = deny;
            this.Async = async;
            this.OnSuccess = onSuccess ?? throw new global::System.ArgumentNullException(nameof(onSuccess));
            this.OnFail = onFail ?? throw new global::System.ArgumentNullException(nameof(onFail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailActions" /> class.
        /// </summary>
        public GuardrailActions()
        {
        }
    }
}