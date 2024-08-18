//HintName: G.Models.AssistantToolsCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantToolsCode
    {
        /// <summary>
        /// The type of tool being defined: `code_interpreter`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AssistantToolsCodeType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}