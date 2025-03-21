//HintName: G.Models.RunStepDetailsToolCallsFileSearchObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsFileSearchObject
    {
        /// <summary>
        /// For now, this is always going to be an empty object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_search", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepDetailsToolCallsFileSearchObjectFileSearch FileSearch { get; set; } = default!;

        /// <summary>
        /// The ID of the tool call object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of tool call. This is always going to be `file_search` for this type of tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RunStepDetailsToolCallsFileSearchObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFileSearchObject" /> class.
        /// </summary>
        /// <param name="fileSearch">
        /// For now, this is always going to be an empty object.
        /// </param>
        /// <param name="id">
        /// The ID of the tool call object.
        /// </param>
        /// <param name="type">
        /// The type of tool call. This is always going to be `file_search` for this type of tool call.
        /// </param>
        public RunStepDetailsToolCallsFileSearchObject(
            global::G.RunStepDetailsToolCallsFileSearchObjectFileSearch fileSearch,
            string id,
            global::G.RunStepDetailsToolCallsFileSearchObjectType type)
        {
            this.FileSearch = fileSearch ?? throw new global::System.ArgumentNullException(nameof(fileSearch));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFileSearchObject" /> class.
        /// </summary>
        public RunStepDetailsToolCallsFileSearchObject()
        {
        }
    }
}