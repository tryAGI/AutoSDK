//HintName: G.Models.CustomLLMModelHeaders.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom headers to send with requests. These headers can override default OpenAI headers except for Authorization (which should be specified using a custom-llm credential).<br/>
    /// Example: {"X-Custom-Header":"value"}
    /// </summary>
    public sealed partial class CustomLLMModelHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}