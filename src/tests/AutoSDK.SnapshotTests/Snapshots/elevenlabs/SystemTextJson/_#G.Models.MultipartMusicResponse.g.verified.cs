//HintName: G.Models.MultipartMusicResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Multipart response structure with JSON metadata and binary audio<br/>
    /// Example: {"audio":"[binary audio data]","metadata":{"composition_plan":{"negative_global_styles":["metal","hip-hop","country"],"positive_global_styles":["pop","rock","jazz"],"sections":[{"duration_ms":10000,"lines":["Verse 1 lyrics"],"negative_local_styles":["metal","hip-hop","country"],"positive_local_styles":["pop","rock","jazz"],"section_name":"Verse 1"}]},"song_metadata":{"description":"My Song Description","genres":["pop","rock","jazz"],"is_explicit":false,"languages":["en","fr"],"title":"My Song"},"words_timestamps":[{"end_ms":1000,"start_ms":0,"word":"Verse"},{"end_ms":2000,"start_ms":1000,"word":"1"},{"end_ms":3000,"start_ms":2000,"word":"lyrics"}]}}
    /// </summary>
    public sealed partial class MultipartMusicResponse
    {
        /// <summary>
        /// JSON metadata about the generated audio<br/>
        /// Example: {"composition_plan":{"negative_global_styles":["metal","hip-hop","country"],"positive_global_styles":["pop","rock","jazz"],"sections":[{"duration_ms":10000,"lines":["Verse 1 lyrics"],"negative_local_styles":["metal","hip-hop","country"],"positive_local_styles":["pop","rock","jazz"],"section_name":"Verse 1"}]},"song_metadata":{"description":"My Song Description","genres":["pop","rock","jazz"],"is_explicit":false,"languages":["en","fr"],"title":"My Song"},"words_timestamps":[{"end_ms":1000,"start_ms":0,"word":"Verse"},{"end_ms":2000,"start_ms":1000,"word":"1"},{"end_ms":3000,"start_ms":2000,"word":"lyrics"}]}
        /// </summary>
        /// <example>{"composition_plan":{"negative_global_styles":["metal","hip-hop","country"],"positive_global_styles":["pop","rock","jazz"],"sections":[{"duration_ms":10000,"lines":["Verse 1 lyrics"],"negative_local_styles":["metal","hip-hop","country"],"positive_local_styles":["pop","rock","jazz"],"section_name":"Verse 1"}]},"song_metadata":{"description":"My Song Description","genres":["pop","rock","jazz"],"is_explicit":false,"languages":["en","fr"],"title":"My Song"},"words_timestamps":[{"end_ms":1000,"start_ms":0,"word":"Verse"},{"end_ms":2000,"start_ms":1000,"word":"1"},{"end_ms":3000,"start_ms":2000,"word":"lyrics"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DetailedMusicResponse Metadata { get; set; }

        /// <summary>
        /// Binary audio data in the requested format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Audio { get; set; }

        /// <summary>
        /// Binary audio data in the requested format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audioname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartMusicResponse" /> class.
        /// </summary>
        /// <param name="metadata">
        /// JSON metadata about the generated audio<br/>
        /// Example: {"composition_plan":{"negative_global_styles":["metal","hip-hop","country"],"positive_global_styles":["pop","rock","jazz"],"sections":[{"duration_ms":10000,"lines":["Verse 1 lyrics"],"negative_local_styles":["metal","hip-hop","country"],"positive_local_styles":["pop","rock","jazz"],"section_name":"Verse 1"}]},"song_metadata":{"description":"My Song Description","genres":["pop","rock","jazz"],"is_explicit":false,"languages":["en","fr"],"title":"My Song"},"words_timestamps":[{"end_ms":1000,"start_ms":0,"word":"Verse"},{"end_ms":2000,"start_ms":1000,"word":"1"},{"end_ms":3000,"start_ms":2000,"word":"lyrics"}]}
        /// </param>
        /// <param name="audio">
        /// Binary audio data in the requested format
        /// </param>
        /// <param name="audioname">
        /// Binary audio data in the requested format
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultipartMusicResponse(
            global::G.DetailedMusicResponse metadata,
            byte[] audio,
            string audioname)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartMusicResponse" /> class.
        /// </summary>
        public MultipartMusicResponse()
        {
        }
    }
}