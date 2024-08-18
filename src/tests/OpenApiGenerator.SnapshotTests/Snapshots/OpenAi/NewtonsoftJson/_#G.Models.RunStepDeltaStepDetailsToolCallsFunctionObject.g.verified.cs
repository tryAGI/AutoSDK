//HintName: G.Models.RunStepDeltaStepDetailsToolCallsFunctionObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsFunctionObject
    {
        /// <summary>
        /// The index of the tool call in the tool calls array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// The ID of the tool call object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type of tool call. This is always going to be `function` for this type of tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RunStepDeltaStepDetailsToolCallsFunctionObjectType Type { get; set; }

        /// <summary>
        /// The definition of the function that was called.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function")]
        public global::G.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}