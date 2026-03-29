//HintName: G.Models.VideoSearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from the video search endpoint.
    /// </summary>
    public sealed partial class VideoSearchResponse
    {
        /// <summary>
        /// The type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Information about the original search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public global::G.Query? Query { get; set; }

        /// <summary>
        /// List of video results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::G.VideoResult>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSearchResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// The type identifier.
        /// </param>
        /// <param name="query">
        /// Information about the original search query.
        /// </param>
        /// <param name="results">
        /// List of video results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoSearchResponse(
            string? type,
            global::G.Query? query,
            global::System.Collections.Generic.IList<global::G.VideoResult>? results)
        {
            this.Type = type;
            this.Query = query;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSearchResponse" /> class.
        /// </summary>
        public VideoSearchResponse()
        {
        }
    }
}