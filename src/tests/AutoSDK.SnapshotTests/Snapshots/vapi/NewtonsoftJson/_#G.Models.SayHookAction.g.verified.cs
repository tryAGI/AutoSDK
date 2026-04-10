//HintName: G.Models.SayHookAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SayHookAction
    {
        /// <summary>
        /// This is the type of action - must be "say"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SayHookActionTypeJsonConverter))]
        public global::G.SayHookActionType Type { get; set; }

        /// <summary>
        /// This is the prompt for the assistant to generate a response based on existing conversation.<br/>
        /// Can be a string or an array of chat messages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>>? Prompt { get; set; }

        /// <summary>
        /// This is the message to say
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exact")]
        public object? Exact { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SayHookAction" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of action - must be "say"
        /// </param>
        /// <param name="prompt">
        /// This is the prompt for the assistant to generate a response based on existing conversation.<br/>
        /// Can be a string or an array of chat messages.
        /// </param>
        /// <param name="exact">
        /// This is the message to say
        /// </param>
        public SayHookAction(
            global::G.SayHookActionType type,
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>>? prompt,
            object? exact)
        {
            this.Type = type;
            this.Prompt = prompt;
            this.Exact = exact;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SayHookAction" /> class.
        /// </summary>
        public SayHookAction()
        {
        }
    }
}