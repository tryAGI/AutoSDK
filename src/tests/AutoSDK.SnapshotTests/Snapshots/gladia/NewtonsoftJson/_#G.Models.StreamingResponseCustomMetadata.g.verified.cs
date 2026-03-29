//HintName: G.Models.StreamingResponseCustomMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom metadata given in the initial request<br/>
    /// Example: {"user":"John Doe"}
    /// </summary>
    public sealed partial class StreamingResponseCustomMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}