//HintName: G.Models.RunStepDetailsToolCallsRetrievalObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsRetrievalObject
    {
        /// <summary>
        /// The ID of the tool call object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of tool call. This is always going to be `retrieval` for this type of tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public RunStepDetailsToolCallsRetrievalObjectType Type { get; set; } = default!;

        /// <summary>
        /// For now, this is always going to be an empty object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrieval", Required = global::Newtonsoft.Json.Required.Always)]
        public RunStepDetailsToolCallsRetrievalObjectRetrieval Retrieval { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}