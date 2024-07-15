//HintName: G.Models.ReferrerTraffic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Referrer Traffic
    /// </summary>
    public sealed partial class ReferrerTraffic
    {
        /// <summary>
        /// Example: Google
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referrer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Referrer { get; set; }

        /// <summary>
        /// Example: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Example: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uniques")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Uniques { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}