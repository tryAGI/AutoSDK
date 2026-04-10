//HintName: G.Models.VideoAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The VideoAsset is used to create video sequences from video files. The src must be a publicly accessible URL to a video resource such as an mp4 file.
    /// </summary>
    public sealed partial class VideoAsset
    {
        /// <summary>
        /// The type of asset - set to `video` for videos.<br/>
        /// Default Value: video
        /// </summary>
        /// <default>global::G.VideoAssetType.Video</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VideoAssetTypeJsonConverter))]
        public global::G.VideoAssetType Type { get; set; } = global::G.VideoAssetType.Video;

        /// <summary>
        /// The video source URL. The URL must be publicly accessible or include credentials.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/video.mp4
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/video.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("src", Required = global::Newtonsoft.Json.Required.Always)]
        public string Src { get; set; } = default!;

        /// <summary>
        /// Set to `true` to force re-encoding of the video during preprocessing. This can help resolve compatibility issues, fix rotation problems, synchronize audio, or convert formats. The video will be processed to ensure optimal compatibility with the rendering engine.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("transcode")]
        public bool? Transcode { get; set; }

        /// <summary>
        /// The start trim point of the video clip, in seconds (defaults to 0). Videos will start from the in trim point. The video will play until the file ends or the Clip length is reached.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("trim")]
        public double? Trim { get; set; }

        /// <summary>
        /// Set the volume of the video clip. Use a number or an array of [Tween](./#tocs_tween) objects to create custom volume transitions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("volume")]
        public global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? Volume { get; set; }

        /// <summary>
        /// Preset volume effects to apply to the video asset &lt;ul&gt;<br/>
        ///   &lt;li&gt;`fadeIn` - fade volume in only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeOut` - fade volume out only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeInFadeOut` - fade volume in and out&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("volumeEffect")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VideoAssetVolumeEffectJsonConverter))]
        public global::G.VideoAssetVolumeEffect? VolumeEffect { get; set; }

        /// <summary>
        /// Adjust the playback speed of the video clip between 0 (paused) and 10 (10x normal speed) where 1 is normal speed (defaults to 1). Adjusting the speed will also adjust the duration of the clip and may require you to  adjust the Clip length. For example, if you set speed to 0.5, the clip will need to be 2x as long to play the entire video (i.e. original length / 0.5). If you set speed to 2, the clip will need to be half as long to play the entire video (i.e. original length / 2).<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// Crop the sides of an asset by a relative amount. The size of the crop is specified using a scale between 0 and 1, relative to the screen width - i.e a left crop of 0.5 will crop half of the asset from the left, a top crop  of 0.25 will crop the top by quarter of the asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crop")]
        public global::G.Crop? Crop { get; set; }

        /// <summary>
        /// Chroma key is a technique that replaces a specific color in a video with a different background image or video, enabling seamless integration of diverse environments. Commonly used for green screen and blue screen effects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chromaKey")]
        public global::G.ChromaKey? ChromaKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAsset" /> class.
        /// </summary>
        /// <param name="src">
        /// The video source URL. The URL must be publicly accessible or include credentials.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/video.mp4
        /// </param>
        /// <param name="transcode">
        /// Set to `true` to force re-encoding of the video during preprocessing. This can help resolve compatibility issues, fix rotation problems, synchronize audio, or convert formats. The video will be processed to ensure optimal compatibility with the rendering engine.<br/>
        /// Example: false
        /// </param>
        /// <param name="trim">
        /// The start trim point of the video clip, in seconds (defaults to 0). Videos will start from the in trim point. The video will play until the file ends or the Clip length is reached.<br/>
        /// Example: 2
        /// </param>
        /// <param name="volume">
        /// Set the volume of the video clip. Use a number or an array of [Tween](./#tocs_tween) objects to create custom volume transitions.
        /// </param>
        /// <param name="volumeEffect">
        /// Preset volume effects to apply to the video asset &lt;ul&gt;<br/>
        ///   &lt;li&gt;`fadeIn` - fade volume in only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeOut` - fade volume out only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeInFadeOut` - fade volume in and out&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="speed">
        /// Adjust the playback speed of the video clip between 0 (paused) and 10 (10x normal speed) where 1 is normal speed (defaults to 1). Adjusting the speed will also adjust the duration of the clip and may require you to  adjust the Clip length. For example, if you set speed to 0.5, the clip will need to be 2x as long to play the entire video (i.e. original length / 0.5). If you set speed to 2, the clip will need to be half as long to play the entire video (i.e. original length / 2).<br/>
        /// Example: 1
        /// </param>
        /// <param name="crop">
        /// Crop the sides of an asset by a relative amount. The size of the crop is specified using a scale between 0 and 1, relative to the screen width - i.e a left crop of 0.5 will crop half of the asset from the left, a top crop  of 0.25 will crop the top by quarter of the asset.
        /// </param>
        /// <param name="chromaKey">
        /// Chroma key is a technique that replaces a specific color in a video with a different background image or video, enabling seamless integration of diverse environments. Commonly used for green screen and blue screen effects.
        /// </param>
        /// <param name="type">
        /// The type of asset - set to `video` for videos.<br/>
        /// Default Value: video
        /// </param>
        public VideoAsset(
            string src,
            bool? transcode,
            double? trim,
            global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? volume,
            global::G.VideoAssetVolumeEffect? volumeEffect,
            float? speed,
            global::G.Crop? crop,
            global::G.ChromaKey? chromaKey,
            global::G.VideoAssetType type = global::G.VideoAssetType.Video)
        {
            this.Type = type;
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Transcode = transcode;
            this.Trim = trim;
            this.Volume = volume;
            this.VolumeEffect = volumeEffect;
            this.Speed = speed;
            this.Crop = crop;
            this.ChromaKey = chromaKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAsset" /> class.
        /// </summary>
        public VideoAsset()
        {
        }
    }
}