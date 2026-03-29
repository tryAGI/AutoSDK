//HintName: G.Models.Snippet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Snippet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet_id")]
        public string? SnippetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Snippet" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="generationId"></param>
        /// <param name="snippetId"></param>
        /// <param name="duration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Snippet(
            string? audio,
            string? generationId,
            string? snippetId,
            double? duration)
        {
            this.Audio = audio;
            this.GenerationId = generationId;
            this.SnippetId = snippetId;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Snippet" /> class.
        /// </summary>
        public Snippet()
        {
        }
    }
}