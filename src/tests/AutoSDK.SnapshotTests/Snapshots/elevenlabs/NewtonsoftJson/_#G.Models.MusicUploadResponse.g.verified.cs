//HintName: G.Models.MusicUploadResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for music upload endpoint.<br/>
    /// Example: {"song_id":"jR4Xz8kL2mNpQ9wVtY1b"}
    /// </summary>
    public sealed partial class MusicUploadResponse
    {
        /// <summary>
        /// Unique identifier for the uploaded song
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("song_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SongId { get; set; } = default!;

        /// <summary>
        /// The composition plan extracted from the uploaded song. Only present if `extract_composition_plan` was True in the request body
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("composition_plan")]
        public global::G.MusicPrompt? CompositionPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicUploadResponse" /> class.
        /// </summary>
        /// <param name="songId">
        /// Unique identifier for the uploaded song
        /// </param>
        /// <param name="compositionPlan">
        /// The composition plan extracted from the uploaded song. Only present if `extract_composition_plan` was True in the request body
        /// </param>
        public MusicUploadResponse(
            string songId,
            global::G.MusicPrompt? compositionPlan)
        {
            this.SongId = songId ?? throw new global::System.ArgumentNullException(nameof(songId));
            this.CompositionPlan = compositionPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicUploadResponse" /> class.
        /// </summary>
        public MusicUploadResponse()
        {
        }
    }
}