//HintName: G.Models.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaSystemMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// System-generated metadata about the video.
    /// </summary>
    public sealed partial class IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaSystemMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fps")]
        public double? Fps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaSystemMetadata" /> class.
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="filename"></param>
        /// <param name="fps"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        public IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaSystemMetadata(
            double? duration,
            string? filename,
            double? fps,
            int? height,
            int? width)
        {
            this.Duration = duration;
            this.Filename = filename;
            this.Fps = fps;
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaSystemMetadata" /> class.
        /// </summary>
        public IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaSystemMetadata()
        {
        }
    }
}