//HintName: G.Models.JsonObjectToolChoiceValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A JSON object that specifies the tool to call. For example, `{"type": "function", "function": {"name": "get_current_weather"}}`
    /// </summary>
    public sealed partial class JsonObjectToolChoiceValue
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}