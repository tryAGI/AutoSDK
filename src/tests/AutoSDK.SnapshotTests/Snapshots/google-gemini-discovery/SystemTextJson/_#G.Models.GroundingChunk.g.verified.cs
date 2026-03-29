//HintName: G.Models.GroundingChunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A `GroundingChunk` represents a segment of supporting evidence that grounds the model's response. It can be a chunk from the web, a retrieved context from a file, or information from Google Maps.
    /// </summary>
    public sealed partial class GroundingChunk
    {
        /// <summary>
        /// Chunk from the web.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web")]
        public global::G.Web? Web { get; set; }

        /// <summary>
        /// Chunk from image search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::G.Image? Image { get; set; }

        /// <summary>
        /// Chunk from context retrieved by the file search tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrievedContext")]
        public global::G.RetrievedContext? RetrievedContext { get; set; }

        /// <summary>
        /// A grounding chunk from Google Maps. A Maps chunk corresponds to a single place.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maps")]
        public global::G.Maps? Maps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingChunk" /> class.
        /// </summary>
        /// <param name="web">
        /// Chunk from the web.
        /// </param>
        /// <param name="image">
        /// Chunk from image search.
        /// </param>
        /// <param name="retrievedContext">
        /// Chunk from context retrieved by the file search tool.
        /// </param>
        /// <param name="maps">
        /// A grounding chunk from Google Maps. A Maps chunk corresponds to a single place.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroundingChunk(
            global::G.Web? web,
            global::G.Image? image,
            global::G.RetrievedContext? retrievedContext,
            global::G.Maps? maps)
        {
            this.Web = web;
            this.Image = image;
            this.RetrievedContext = retrievedContext;
            this.Maps = maps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingChunk" /> class.
        /// </summary>
        public GroundingChunk()
        {
        }
    }
}