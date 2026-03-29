//HintName: G.Models.CitedBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Citation information for a scholar result.
    /// </summary>
    public sealed partial class CitedBy
    {
        /// <summary>
        /// Total number of citations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Link to see all citing articles.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CitedBy" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of citations.
        /// </param>
        /// <param name="link">
        /// Link to see all citing articles.
        /// </param>
        public CitedBy(
            int? total,
            string? link)
        {
            this.Total = total;
            this.Link = link;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CitedBy" /> class.
        /// </summary>
        public CitedBy()
        {
        }
    }
}