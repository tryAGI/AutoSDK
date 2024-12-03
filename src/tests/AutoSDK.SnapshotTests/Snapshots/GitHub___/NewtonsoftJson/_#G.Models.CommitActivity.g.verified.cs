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
        /// Example: [0, 3, 26, 20, 39, 1, 0]
        /// </summary>
        /// <example>[0, 3, 26, 20, 39, 1, 0]</example>
        [global::Newtonsoft.Json.JsonProperty("days", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Days { get; set; } = default!;

        /// <summary>
        /// Example: 89
        /// </summary>
        /// <example>89</example>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Example: 1336280400
        /// </summary>
        /// <example>1336280400</example>
        [global::Newtonsoft.Json.JsonProperty("week", Required = global::Newtonsoft.Json.Required.Always)]
        public int Week { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitActivity" /> class.
        /// </summary>
        /// <param name="days">
        /// Example: [0, 3, 26, 20, 39, 1, 0]
        /// </param>
        /// <param name="total">
        /// Example: 89
        /// </param>
        /// <param name="week">
        /// Example: 1336280400
        /// </param>
        public CommitActivity(
            global::System.Collections.Generic.IList<int> days,
            int total,
            int week)
        {
            this.Days = days ?? throw new global::System.ArgumentNullException(nameof(days));
            this.Total = total;
            this.Week = week;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitActivity" /> class.
        /// </summary>
        public CommitActivity()
        {
        }
    }
}