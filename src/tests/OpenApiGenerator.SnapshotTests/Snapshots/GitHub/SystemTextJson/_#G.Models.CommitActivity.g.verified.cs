//HintName: G.Models.CommitActivity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Commit Activity
    /// </summary>
    public sealed partial class CommitActivity
    {
        /// <summary>
        /// <br/>Example: [0, 3, 26, 20, 39, 1, 0]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Days { get; set; }

        /// <summary>
        /// <br/>Example: 89
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// <br/>Example: 1336280400
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("week")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Week { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}