//HintName: G.Models.BodyUploadMusicV1MusicUploadPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUploadMusicV1MusicUploadPost
    {
        /// <summary>
        /// The audio file to upload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// The audio file to upload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Whether to generate and return the composition plan for the uploaded song. If True, the response will include the composition_plan but will increase the latency.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extract_composition_plan")]
        public bool? ExtractCompositionPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadMusicV1MusicUploadPost" /> class.
        /// </summary>
        /// <param name="file">
        /// The audio file to upload.
        /// </param>
        /// <param name="filename">
        /// The audio file to upload.
        /// </param>
        /// <param name="extractCompositionPlan">
        /// Whether to generate and return the composition plan for the uploaded song. If True, the response will include the composition_plan but will increase the latency.<br/>
        /// Default Value: false
        /// </param>
        public BodyUploadMusicV1MusicUploadPost(
            byte[] file,
            string filename,
            bool? extractCompositionPlan)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ExtractCompositionPlan = extractCompositionPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadMusicV1MusicUploadPost" /> class.
        /// </summary>
        public BodyUploadMusicV1MusicUploadPost()
        {
        }
    }
}