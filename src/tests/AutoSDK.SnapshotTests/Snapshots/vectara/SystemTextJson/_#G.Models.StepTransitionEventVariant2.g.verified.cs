//HintName: G.Models.StepTransitionEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StepTransitionEventVariant2
    {
        /// <summary>
        /// The type of event.<br/>
        /// Default Value: step_transition
        /// </summary>
        /// <default>"step_transition"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "step_transition";

        /// <summary>
        /// The name of the step being transitioned from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_step")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromStep { get; set; }

        /// <summary>
        /// The name of the step being transitioned to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_step")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToStep { get; set; }

        /// <summary>
        /// The handoff message content for the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepTransitionEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event.<br/>
        /// Default Value: step_transition
        /// </param>
        /// <param name="fromStep">
        /// The name of the step being transitioned from.
        /// </param>
        /// <param name="toStep">
        /// The name of the step being transitioned to.
        /// </param>
        /// <param name="content">
        /// The handoff message content for the LLM.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepTransitionEventVariant2(
            string type,
            string fromStep,
            string toStep,
            string content)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.FromStep = fromStep ?? throw new global::System.ArgumentNullException(nameof(fromStep));
            this.ToStep = toStep ?? throw new global::System.ArgumentNullException(nameof(toStep));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepTransitionEventVariant2" /> class.
        /// </summary>
        public StepTransitionEventVariant2()
        {
        }
    }
}