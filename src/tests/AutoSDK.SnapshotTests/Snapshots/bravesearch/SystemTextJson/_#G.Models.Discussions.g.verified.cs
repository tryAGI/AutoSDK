//HintName: G.Models.Discussions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Container for discussion/forum results.
    /// </summary>
    public sealed partial class Discussions
    {
        /// <summary>
        /// The type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// List of discussion results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::G.DiscussionResult>? Results { get; set; }

        /// <summary>
        /// Whether results were modified by Goggles.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mutated_by_goggles")]
        public bool? MutatedByGoggles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Discussions" /> class.
        /// </summary>
        /// <param name="type">
        /// The type identifier.
        /// </param>
        /// <param name="results">
        /// List of discussion results.
        /// </param>
        /// <param name="mutatedByGoggles">
        /// Whether results were modified by Goggles.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Discussions(
            string? type,
            global::System.Collections.Generic.IList<global::G.DiscussionResult>? results,
            bool? mutatedByGoggles)
        {
            this.Type = type;
            this.Results = results;
            this.MutatedByGoggles = mutatedByGoggles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Discussions" /> class.
        /// </summary>
        public Discussions()
        {
        }
    }
}