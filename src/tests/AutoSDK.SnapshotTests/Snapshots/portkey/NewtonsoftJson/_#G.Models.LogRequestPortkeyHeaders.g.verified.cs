//HintName: G.Models.LogRequestPortkeyHeaders.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Portkey-specific headers<br/>
    /// Example: {"x-portkey-trace-id":"trace-123","x-portkey-span-id":"span-456","x-portkey-metadata":"{\u0022key\u0022:\u0022value\u0022}"}
    /// </summary>
    public sealed partial class LogRequestPortkeyHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}