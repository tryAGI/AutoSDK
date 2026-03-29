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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TypeJsonConverter))]
        public global::G.MessagesRequestContextManagementEditsItemsOneOf0Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_at_least")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeast, object>))]
        public global::G.OneOf<global::G.MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeast, object>? ClearAtLeast { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_tool_inputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsJsonConverter))]
        public global::G.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs? ClearToolInputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_tools")]
        public global::System.Collections.Generic.IList<string>? ExcludeTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep")]
        public global::G.MessagesRequestContextManagementEditsItemsOneOf0Keep? Keep { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerJsonConverter))]
        public global::G.MessagesRequestContextManagementEditsItemsOneOf0Trigger? Trigger { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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