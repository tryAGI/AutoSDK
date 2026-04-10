//HintName: G.Models.MessagesRequestContextManagementEditsItems0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestContextManagementEditsItems0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TypeJsonConverter))]
        public global::G.MessagesRequestContextManagementEditsItemsOneOf0Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clear_at_least")]
        public global::G.OneOf<global::G.MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeast, object>? ClearAtLeast { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clear_tool_inputs")]
        public global::G.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs? ClearToolInputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_tools")]
        public global::System.Collections.Generic.IList<string>? ExcludeTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keep")]
        public global::G.MessagesRequestContextManagementEditsItemsOneOf0Keep? Keep { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trigger")]
        public global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger? Trigger { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItems0" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="clearAtLeast"></param>
        /// <param name="clearToolInputs"></param>
        /// <param name="excludeTools"></param>
        /// <param name="keep"></param>
        /// <param name="trigger"></param>
        public MessagesRequestContextManagementEditsItems0(
            global::G.MessagesRequestContextManagementEditsItemsOneOf0Type type,
            global::G.OneOf<global::G.MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeast, object>? clearAtLeast,
            global::G.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs? clearToolInputs,
            global::System.Collections.Generic.IList<string>? excludeTools,
            global::G.MessagesRequestContextManagementEditsItemsOneOf0Keep? keep,
            global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger? trigger)
        {
            this.Type = type;
            this.ClearAtLeast = clearAtLeast;
            this.ClearToolInputs = clearToolInputs;
            this.ExcludeTools = excludeTools;
            this.Keep = keep;
            this.Trigger = trigger;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItems0" /> class.
        /// </summary>
        public MessagesRequestContextManagementEditsItems0()
        {
        }
    }
}