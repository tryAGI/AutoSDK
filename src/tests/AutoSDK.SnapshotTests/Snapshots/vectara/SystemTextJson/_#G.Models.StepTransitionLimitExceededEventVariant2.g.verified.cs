//HintName: G.Models.StepTransitionLimitExceededEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StepTransitionLimitExceededEventVariant2
    {
        /// <summary>
        /// The type of event.<br/>
        /// Default Value: step_transition_limit_exceeded
        /// </summary>
        /// <default>"step_transition_limit_exceeded"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "step_transition_limit_exceeded";

        /// <summary>
        /// The maximum number of step transitions allowed<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition_limit")]
        public int? TransitionLimit { get; set; }

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: Agent exceeded maximum step transitions (10). Possible infinite loop between steps.
        /// </summary>
        /// <example>Agent exceeded maximum step transitions (10). Possible infinite loop between steps.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepTransitionLimitExceededEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event.<br/>
        /// Default Value: step_transition_limit_exceeded
        /// </param>
        /// <param name="message">
        /// Human-readable error message<br/>
        /// Example: Agent exceeded maximum step transitions (10). Possible infinite loop between steps.
        /// </param>
        /// <param name="transitionLimit">
        /// The maximum number of step transitions allowed<br/>
        /// Example: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepTransitionLimitExceededEventVariant2(
            string type,
            string message,
            int? transitionLimit)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.TransitionLimit = transitionLimit;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepTransitionLimitExceededEventVariant2" /> class.
        /// </summary>
        public StepTransitionLimitExceededEventVariant2()
        {
        }
    }
}