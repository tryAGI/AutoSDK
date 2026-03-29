//HintName: G.Models.LogResponseBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response body (only present when debug logging is enabled or request failed). May be redacted for certain embedding models.<br/>
    /// Example: {"id":"chatcmpl-123","object":"chat.completion","created":1677652288}
    /// </summary>
    public sealed partial class LogResponseBody
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}