//HintName: G.Models.AssistantStreamEventVariant11.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a [run](/docs/api-reference/runs/object) moves to a `cancelling` status.
    /// </summary>
    public sealed partial class AssistantStreamEventVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.AssistantStreamEventVariant11Event Event { get; set; }

        /// <summary>
        /// Represents an execution run on a [thread](/docs/api-reference/threads).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunObject Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant11" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="data">
        /// Represents an execution run on a [thread](/docs/api-reference/threads).
        /// </param>
        public AssistantStreamEventVariant11(
            global::G.RunObject data,
            global::G.AssistantStreamEventVariant11Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant11" /> class.
        /// </summary>
        public AssistantStreamEventVariant11()
        {
        }
    }
}