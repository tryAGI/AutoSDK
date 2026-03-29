//HintName: G.Models.ImageSearchResults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Container for image search results.
    /// </summary>
    public sealed partial class ImageSearchResults
    {
        /// <summary>
        /// The type identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// List of image results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public global::System.Collections.Generic.IList<global::G.ImageResult>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchResults" /> class.
        /// </summary>
        /// <param name="type">
        /// The type identifier.
        /// </param>
        /// <param name="results">
        /// List of image results.
        /// </param>
        public ImageSearchResults(
            string? type,
            global::System.Collections.Generic.IList<global::G.ImageResult>? results)
        {
            this.Type = type;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchResults" /> class.
        /// </summary>
        public ImageSearchResults()
        {
        }
    }
}