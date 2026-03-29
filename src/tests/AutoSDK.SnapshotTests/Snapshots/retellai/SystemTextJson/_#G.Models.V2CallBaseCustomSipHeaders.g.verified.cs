//HintName: G.Models.V2CallBaseCustomSipHeaders.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom SIP headers to be added to the call.<br/>
    /// Example: {"X-Custom-Header":"Custom Value"}
    /// </summary>
    public sealed partial class V2CallBaseCustomSipHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}