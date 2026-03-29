//HintName: G.Models.NewsResults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Container for news results.
    /// </summary>
    public sealed partial class NewsResults
    {
        /// <summary>
        /// The type identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// List of news results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public global::System.Collections.Generic.IList<global::G.NewsResult>? Results { get; set; }

        /// <summary>
        /// Whether results were modified by Goggles.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mutated_by_goggles")]
        public bool? MutatedByGoggles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewsResults" /> class.
        /// </summary>
        /// <param name="type">
        /// The type identifier.
        /// </param>
        /// <param name="results">
        /// List of news results.
        /// </param>
        /// <param name="mutatedByGoggles">
        /// Whether results were modified by Goggles.
        /// </param>
        public NewsResults(
            string? type,
            global::System.Collections.Generic.IList<global::G.NewsResult>? results,
            bool? mutatedByGoggles)
        {
            this.Type = type;
            this.Results = results;
            this.MutatedByGoggles = mutatedByGoggles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewsResults" /> class.
        /// </summary>
        public NewsResults()
        {
        }
    }
}