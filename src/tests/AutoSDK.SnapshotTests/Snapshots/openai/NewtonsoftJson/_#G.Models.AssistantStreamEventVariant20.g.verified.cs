//HintName: G.Models.AssistantStreamEventVariant20.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a [run step](/docs/api-reference/run-steps/step-object) expires.
    /// </summary>
    public sealed partial class AssistantStreamEventVariant20
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.AssistantStreamEventVariant20Event Event { get; set; }

        /// <summary>
        /// Represents a step in execution of a run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepObject Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant20" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="data">
        /// Represents a step in execution of a run.
        /// </param>
        public AssistantStreamEventVariant20(
            global::G.RunStepObject data,
            global::G.AssistantStreamEventVariant20Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant20" /> class.
        /// </summary>
        public AssistantStreamEventVariant20()
        {
        }
    }
}