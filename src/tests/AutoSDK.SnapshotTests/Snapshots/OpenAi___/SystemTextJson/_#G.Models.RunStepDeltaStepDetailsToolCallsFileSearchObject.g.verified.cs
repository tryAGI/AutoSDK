//HintName: G.Models.RunStepDeltaStepDetailsToolCallsFileSearchObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsFileSearchObject
    {
        /// <summary>
        /// The index of the tool call in the tool calls array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The ID of the tool call object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type of tool call. This is always going to be `file_search` for this type of tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunStepDeltaStepDetailsToolCallsFileSearchObjectTypeJsonConverter))]
        public global::G.RunStepDeltaStepDetailsToolCallsFileSearchObjectType Type { get; set; }

        /// <summary>
        /// For now, this is always going to be an empty object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object FileSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsFileSearchObject" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the tool call in the tool calls array.
        /// </param>
        /// <param name="id">
        /// The ID of the tool call object.
        /// </param>
        /// <param name="type">
        /// The type of tool call. This is always going to be `file_search` for this type of tool call.
        /// </param>
        /// <param name="fileSearch">
        /// For now, this is always going to be an empty object.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunStepDeltaStepDetailsToolCallsFileSearchObject(
            int index,
            object fileSearch,
            string? id,
            global::G.RunStepDeltaStepDetailsToolCallsFileSearchObjectType type)
        {
            this.Index = index;
            this.FileSearch = fileSearch ?? throw new global::System.ArgumentNullException(nameof(fileSearch));
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsFileSearchObject" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsFileSearchObject()
        {
        }
    }
}