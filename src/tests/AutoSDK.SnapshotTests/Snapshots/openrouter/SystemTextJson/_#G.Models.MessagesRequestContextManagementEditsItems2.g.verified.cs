//HintName: G.Models.MessagesRequestContextManagementEditsItems2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestContextManagementEditsItems2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf2TypeJsonConverter))]
        public global::G.MessagesRequestContextManagementEditsItemsOneOf2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pause_after_compaction")]
        public bool? PauseAfterCompaction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.MessagesRequestContextManagementEditsItemsOneOf2Trigger, object>))]
        public global::G.OneOf<global::G.MessagesRequestContextManagementEditsItemsOneOf2Trigger, object>? Trigger { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItems2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="instructions"></param>
        /// <param name="pauseAfterCompaction"></param>
        /// <param name="trigger"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestContextManagementEditsItems2(
            global::G.MessagesRequestContextManagementEditsItemsOneOf2Type type,
            string? instructions,
            bool? pauseAfterCompaction,
            global::G.OneOf<global::G.MessagesRequestContextManagementEditsItemsOneOf2Trigger, object>? trigger)
        {
            this.Type = type;
            this.Instructions = instructions;
            this.PauseAfterCompaction = pauseAfterCompaction;
            this.Trigger = trigger;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagementEditsItems2" /> class.
        /// </summary>
        public MessagesRequestContextManagementEditsItems2()
        {
        }
    }
}