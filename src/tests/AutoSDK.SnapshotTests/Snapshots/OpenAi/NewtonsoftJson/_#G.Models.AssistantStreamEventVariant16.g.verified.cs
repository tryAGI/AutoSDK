//HintName: G.Models.AssistantStreamEventVariant16.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when parts of a [run step](/docs/api-reference/runs/step-object) are being streamed.
    /// </summary>
    public sealed partial class AssistantStreamEventVariant16
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.AssistantStreamEventVariant16Event Event { get; set; }

        /// <summary>
        /// Represents a run step delta i.e. any changed fields on a run step during streaming.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepDeltaObject Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant16" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="data">
        /// Represents a run step delta i.e. any changed fields on a run step during streaming.
        /// </param>
        public AssistantStreamEventVariant16(
            global::G.RunStepDeltaObject data,
            global::G.AssistantStreamEventVariant16Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant16" /> class.
        /// </summary>
        public AssistantStreamEventVariant16()
        {
        }
    }
}