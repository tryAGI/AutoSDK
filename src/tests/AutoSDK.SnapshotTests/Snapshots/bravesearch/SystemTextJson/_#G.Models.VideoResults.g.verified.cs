//HintName: G.Models.VideoResults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Container for video results.
    /// </summary>
    public sealed partial class VideoResults
    {
        /// <summary>
        /// The type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// List of video results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::G.VideoResult>? Results { get; set; }

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
        /// Initializes a new instance of the <see cref="VideoResults" /> class.
        /// </summary>
        /// <param name="type">
        /// The type identifier.
        /// </param>
        /// <param name="results">
        /// List of video results.
        /// </param>
        /// <param name="mutatedByGoggles">
        /// Whether results were modified by Goggles.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoResults(
            string? type,
            global::System.Collections.Generic.IList<global::G.VideoResult>? results,
            bool? mutatedByGoggles)
        {
            this.Type = type;
            this.Results = results;
            this.MutatedByGoggles = mutatedByGoggles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResults" /> class.
        /// </summary>
        public VideoResults()
        {
        }
    }
}