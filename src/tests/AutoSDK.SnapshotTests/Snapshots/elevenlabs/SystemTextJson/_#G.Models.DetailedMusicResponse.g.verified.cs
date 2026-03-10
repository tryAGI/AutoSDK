//HintName: G.Models.DetailedMusicResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for structured music generation endpoint<br/>
    /// Example: {"composition_plan":{"negative_global_styles":["metal","hip-hop","country"],"positive_global_styles":["pop","rock","jazz"],"sections":[{"duration_ms":10000,"lines":["Verse 1 lyrics"],"negative_local_styles":["metal","hip-hop","country"],"positive_local_styles":["pop","rock","jazz"],"section_name":"Verse 1"}]},"song_metadata":{"description":"My Song Description","genres":["pop","rock","jazz"],"is_explicit":false,"languages":["en","fr"],"title":"My Song"},"words_timestamps":[{"end_ms":1000,"start_ms":0,"word":"Verse"},{"end_ms":2000,"start_ms":1000,"word":"1"},{"end_ms":3000,"start_ms":2000,"word":"lyrics"}]}
    /// </summary>
    public sealed partial class DetailedMusicResponse
    {
        /// <summary>
        /// The composition plan used to generate the song<br/>
        /// Example: {"negative_global_styles":["metal","hip-hop","country"],"positive_global_styles":["pop","rock","jazz"],"sections":[{"duration_ms":10000,"lines":["Verse 1 lyrics"],"negative_local_styles":["metal","hip-hop","country"],"positive_local_styles":["pop","rock","jazz"],"section_name":"Verse 1"}]}
        /// </summary>
        /// <example>{"negative_global_styles":["metal","hip-hop","country"],"positive_global_styles":["pop","rock","jazz"],"sections":[{"duration_ms":10000,"lines":["Verse 1 lyrics"],"negative_local_styles":["metal","hip-hop","country"],"positive_local_styles":["pop","rock","jazz"],"section_name":"Verse 1"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("composition_plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MusicPrompt CompositionPlan { get; set; }

        /// <summary>
        /// The metadata of the generated song<br/>
        /// Example: {"description":"My Song Description","genres":["pop","rock","jazz"],"is_explicit":false,"languages":["en","fr"],"title":"My Song"}
        /// </summary>
        /// <example>{"description":"My Song Description","genres":["pop","rock","jazz"],"is_explicit":false,"languages":["en","fr"],"title":"My Song"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("song_metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SongMetadata SongMetadata { get; set; }

        /// <summary>
        /// The timestamps of the words in the generated song
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words_timestamps")]
        public global::System.Collections.Generic.IList<global::G.WordTimestamp>? WordsTimestamps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedMusicResponse" /> class.
        /// </summary>
        /// <param name="compositionPlan">
        /// The composition plan used to generate the song<br/>
        /// Example: {"negative_global_styles":["metal","hip-hop","country"],"positive_global_styles":["pop","rock","jazz"],"sections":[{"duration_ms":10000,"lines":["Verse 1 lyrics"],"negative_local_styles":["metal","hip-hop","country"],"positive_local_styles":["pop","rock","jazz"],"section_name":"Verse 1"}]}
        /// </param>
        /// <param name="songMetadata">
        /// The metadata of the generated song<br/>
        /// Example: {"description":"My Song Description","genres":["pop","rock","jazz"],"is_explicit":false,"languages":["en","fr"],"title":"My Song"}
        /// </param>
        /// <param name="wordsTimestamps">
        /// The timestamps of the words in the generated song
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetailedMusicResponse(
            global::G.MusicPrompt compositionPlan,
            global::G.SongMetadata songMetadata,
            global::System.Collections.Generic.IList<global::G.WordTimestamp>? wordsTimestamps)
        {
            this.CompositionPlan = compositionPlan ?? throw new global::System.ArgumentNullException(nameof(compositionPlan));
            this.SongMetadata = songMetadata ?? throw new global::System.ArgumentNullException(nameof(songMetadata));
            this.WordsTimestamps = wordsTimestamps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedMusicResponse" /> class.
        /// </summary>
        public DetailedMusicResponse()
        {
        }
    }
}