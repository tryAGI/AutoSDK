//HintName: G.Models.StreamingNewRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingNewRequest
    {
        /// <summary>
        /// Example: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public string? Quality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}