//HintName: G.Models.RunStepStreamEventVariant6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) is cancelled.
    /// </summary>
    public sealed partial class RunStepStreamEventVariant6
    {
        /// <summary>
        /// Represents a step in execution of a run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepObject Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.RunStepStreamEventVariant6Event Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepStreamEventVariant6" /> class.
        /// </summary>
        /// <param name="data">
        /// Represents a step in execution of a run.
        /// </param>
        /// <param name="event"></param>
        public RunStepStreamEventVariant6(
            global::G.RunStepObject data,
            global::G.RunStepStreamEventVariant6Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepStreamEventVariant6" /> class.
        /// </summary>
        public RunStepStreamEventVariant6()
        {
        }
    }
}