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
        [global::Newtonsoft.Json.JsonProperty("days", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Days { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 89
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 1336280400
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("week", Required = global::Newtonsoft.Json.Required.Always)]
        public int Week { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}