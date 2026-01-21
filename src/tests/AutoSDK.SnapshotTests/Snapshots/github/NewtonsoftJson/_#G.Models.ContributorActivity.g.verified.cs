//HintName: G.Models.ContributorActivity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contributor Activity
    /// </summary>
    public sealed partial class ContributorActivity
    {
        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Author { get; set; } = default!;

        /// <summary>
        /// Example: 135
        /// </summary>
        /// <example>135</example>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Example: [{"w":"1367712000","a":6898,"d":77,"c":10}]
        /// </summary>
        /// <example>[{"w":"1367712000","a":6898,"d":77,"c":10}]</example>
        [global::Newtonsoft.Json.JsonProperty("weeks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ContributorActivityWeek> Weeks { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContributorActivity" /> class.
        /// </summary>
        /// <param name="author">
        /// A GitHub user.
        /// </param>
        /// <param name="total">
        /// Example: 135
        /// </param>
        /// <param name="weeks">
        /// Example: [{"w":"1367712000","a":6898,"d":77,"c":10}]
        /// </param>
        public ContributorActivity(
            global::G.NullableSimpleUser? author,
            int total,
            global::System.Collections.Generic.IList<global::G.ContributorActivityWeek> weeks)
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Total = total;
            this.Weeks = weeks ?? throw new global::System.ArgumentNullException(nameof(weeks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContributorActivity" /> class.
        /// </summary>
        public ContributorActivity()
        {
        }
    }
}