//HintName: G.Models.IndexedAssetSystemMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// System-generated metadata about the indexed asset.
    /// </summary>
    public sealed partial class IndexedAssetSystemMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fps")]
        public double? Fps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public double? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedAssetSystemMetadata" /> class.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="duration"></param>
        /// <param name="fps"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="size"></param>
        public IndexedAssetSystemMetadata(
            string? filename,
            double? duration,
            double? fps,
            int? width,
            int? height,
            double? size)
        {
            this.Filename = filename;
            this.Duration = duration;
            this.Fps = fps;
            this.Width = width;
            this.Height = height;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedAssetSystemMetadata" /> class.
        /// </summary>
        public IndexedAssetSystemMetadata()
        {
        }
    }
}