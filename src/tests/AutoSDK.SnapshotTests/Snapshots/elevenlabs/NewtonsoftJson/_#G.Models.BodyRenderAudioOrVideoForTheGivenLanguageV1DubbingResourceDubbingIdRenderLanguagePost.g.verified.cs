//HintName: G.Models.BodyRenderAudioOrVideoForTheGivenLanguageV1DubbingResourceDubbingIdRenderLanguagePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyRenderAudioOrVideoForTheGivenLanguageV1DubbingResourceDubbingIdRenderLanguagePost
    {
        /// <summary>
        /// The type of the render. One of ['mp4', 'aac', 'mp3', 'wav', 'aaf', 'tracks_zip', 'clips_zip']
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("render_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RenderType2 RenderType { get; set; } = default!;

        /// <summary>
        /// Whether to normalize the volume of the rendered audio.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("normalize_volume")]
        public bool? NormalizeVolume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRenderAudioOrVideoForTheGivenLanguageV1DubbingResourceDubbingIdRenderLanguagePost" /> class.
        /// </summary>
        /// <param name="renderType">
        /// The type of the render. One of ['mp4', 'aac', 'mp3', 'wav', 'aaf', 'tracks_zip', 'clips_zip']
        /// </param>
        /// <param name="normalizeVolume">
        /// Whether to normalize the volume of the rendered audio.<br/>
        /// Default Value: false
        /// </param>
        public BodyRenderAudioOrVideoForTheGivenLanguageV1DubbingResourceDubbingIdRenderLanguagePost(
            global::G.RenderType2 renderType,
            bool? normalizeVolume)
        {
            this.RenderType = renderType;
            this.NormalizeVolume = normalizeVolume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRenderAudioOrVideoForTheGivenLanguageV1DubbingResourceDubbingIdRenderLanguagePost" /> class.
        /// </summary>
        public BodyRenderAudioOrVideoForTheGivenLanguageV1DubbingResourceDubbingIdRenderLanguagePost()
        {
        }
    }
}