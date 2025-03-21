//HintName: G.Models.RunStepDetailsToolCallsFunctionObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsFunctionObject
    {
        /// <summary>
        /// The definition of the function that was called.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepDetailsToolCallsFunctionObjectFunction Function { get; set; } = default!;

        /// <summary>
        /// The ID of the tool call object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of tool call. This is always going to be `function` for this type of tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RunStepDetailsToolCallsFunctionObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFunctionObject" /> class.
        /// </summary>
        /// <param name="function">
        /// The definition of the function that was called.
        /// </param>
        /// <param name="id">
        /// The ID of the tool call object.
        /// </param>
        /// <param name="type">
        /// The type of tool call. This is always going to be `function` for this type of tool call.
        /// </param>
        public RunStepDetailsToolCallsFunctionObject(
            global::G.RunStepDetailsToolCallsFunctionObjectFunction function,
            string id,
            global::G.RunStepDetailsToolCallsFunctionObjectType type)
        {
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFunctionObject" /> class.
        /// </summary>
        public RunStepDetailsToolCallsFunctionObject()
        {
        }
    }
}