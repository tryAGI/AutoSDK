//HintName: G.Models.OtelTraceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from trace export request. Empty object indicates success.
    /// </summary>
    public sealed partial class OtelTraceResponse
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}