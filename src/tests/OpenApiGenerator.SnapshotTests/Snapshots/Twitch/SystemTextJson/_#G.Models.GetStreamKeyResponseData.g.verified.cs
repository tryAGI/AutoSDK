//HintName: G.Models.GetStreamKeyResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetStreamKeyResponseData
    {
        /// <summary>
        /// The channel’s stream key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StreamKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}