//HintName: G.Models.LogRequestHeaders.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request headers (only present when debug logging is enabled)<br/>
    /// Example: {"Content-Type":"application/json","Authorization":"Bearer hashed_value"}
    /// </summary>
    public sealed partial class LogRequestHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}