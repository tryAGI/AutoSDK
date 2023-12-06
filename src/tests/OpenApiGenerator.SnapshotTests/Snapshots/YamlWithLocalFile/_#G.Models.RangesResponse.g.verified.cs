//HintName: G.Models.RangesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class RangesResponse
    {
        /// <summary>
        /// Example: comcast.net
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public required string? Domain { get; set; }

        /// <summary>
        /// Example: 37330
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_ranges")]
        public required string? NumRanges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranges")]
        public required object[]? Ranges { get; set; }

        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}