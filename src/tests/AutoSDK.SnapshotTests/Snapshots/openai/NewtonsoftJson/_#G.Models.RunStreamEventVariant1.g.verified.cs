//HintName: G.Models.RunStreamEventVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a new [run](/docs/api-reference/runs/object) is created.
    /// </summary>
    public sealed partial class RunStreamEventVariant1
    {
        /// <summary>
        /// Represents an execution run on a [thread](/docs/api-reference/threads).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunObject Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.RunStreamEventVariant1Event Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStreamEventVariant1" /> class.
        /// </summary>
        /// <param name="data">
        /// Represents an execution run on a [thread](/docs/api-reference/threads).
        /// </param>
        /// <param name="event"></param>
        public RunStreamEventVariant1(
            global::G.RunObject data,
            global::G.RunStreamEventVariant1Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStreamEventVariant1" /> class.
        /// </summary>
        public RunStreamEventVariant1()
        {
        }
    }
}