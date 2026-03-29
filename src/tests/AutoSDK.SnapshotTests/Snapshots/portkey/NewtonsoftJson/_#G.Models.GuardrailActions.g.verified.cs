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
        [global::Newtonsoft.Json.JsonProperty("deny", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deny { get; set; } = default!;

        /// <summary>
        /// Whether the guardrail check should be performed asynchronously<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("async", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Async { get; set; } = default!;

        /// <summary>
        /// Actions to take when guardrail check passes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_success", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GuardrailActionsOnSuccess OnSuccess { get; set; } = default!;

        /// <summary>
        /// Actions to take when guardrail check fails
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_fail", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GuardrailActionsOnFail OnFail { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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