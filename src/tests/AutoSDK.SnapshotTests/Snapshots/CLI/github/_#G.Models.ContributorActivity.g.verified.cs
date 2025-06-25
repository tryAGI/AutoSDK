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
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? Author { get; set; }

        /// <summary>
        /// Example: 135
        /// </summary>
        /// <example>135</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weeks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ContributorActivityWeek> Weeks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        /// Example: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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