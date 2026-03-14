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
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The name of the step being transitioned from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_step", Required = global::Newtonsoft.Json.Required.Always)]
        public string FromStep { get; set; } = default!;

        /// <summary>
        /// The name of the step being transitioned to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to_step", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToStep { get; set; } = default!;

        /// <summary>
        /// The handoff message content for the LLM.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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