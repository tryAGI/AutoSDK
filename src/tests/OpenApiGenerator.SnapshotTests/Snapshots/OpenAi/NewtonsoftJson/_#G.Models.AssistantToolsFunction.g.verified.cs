//HintName: G.Models.AssistantToolsFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantToolsFunction
    {
        /// <summary>
        /// The type of tool being defined: `function`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AssistantToolsFunctionType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FunctionObject? Function { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}