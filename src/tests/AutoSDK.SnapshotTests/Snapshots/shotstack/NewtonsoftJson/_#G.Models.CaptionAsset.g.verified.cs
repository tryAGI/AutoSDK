//HintName: G.Models.CaptionAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The CaptionAsset is used to add captions (subtitles) to a video. It uses a supplied SRT or VTT file which will<br/>
    /// be read and burnt to the video.<br/>
    /// Captions can be applied independently from a video or audio file for greater<br/>
    /// flexibility with styling and layout. For example you can scale, position or crop a video without modifying the<br/>
    /// captions.<br/>
    /// To sync captions with a video or audio file use a [Video](#tocs_videoasset") or [Audio](#tocs_audioasset") with<br/>
    /// matching start and end time.
    /// </summary>
    public sealed partial class CaptionAsset
    {
        /// <summary>
        /// The type of asset - set to `caption` for captions.<br/>
        /// Default Value: caption
        /// </summary>
        /// <default>global::G.CaptionAssetType.Caption</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CaptionAssetType Type { get; set; } = global::G.CaptionAssetType.Caption;

        /// <summary>
        /// The URL to an SRT or VTT subtitles file, or an alias reference to auto-generate captions from an audio or video clip. For file URLs, the URL must be publicly accessible or include credentials. For auto-captioning, use the format `alias://clip-name` where clip-name is the alias of an audio, video, or text-to-speech clip. The system will automatically transcribe the audio and detect the language.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/captions.srt
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/captions.srt</example>
        [global::Newtonsoft.Json.JsonProperty("src", Required = global::Newtonsoft.Json.Required.Always)]
        public string Src { get; set; } = default!;

        /// <summary>
        /// Font properties for captions text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("font")]
        public global::G.CaptionFont? Font { get; set; }

        /// <summary>
        /// Displays a background box behind the caption text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.CaptionBackground? Background { get; set; }

        /// <summary>
        /// The margin properties for captions. Margins are used to position the caption text and background on the screen.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("margin")]
        public global::G.CaptionMargin? Margin { get; set; }

        /// <summary>
        /// The start trim point of the captions, in seconds (defaults to 0). Remove the trim length from the start of the captions and allow it to be synced with video or audio. The captions will play until the file ends or the Clip length is reached.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("trim")]
        public double? Trim { get; set; }

        /// <summary>
        /// Adjust the playback speed of the captions between 0 (paused) and 10 (10x normal speed) where 1 is normal speed (defaults to 1). Adjusting the speed will also adjust the duration of the clip and may require you to  adjust the Clip length. For example, if you set speed to 0.5, the clip will need to be 2x as long to play the entire captions (i.e. original length / 0.5). If you set speed to 2, the clip will need to be half as long to play the entire captions (i.e. original length / 2).<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionAsset" /> class.
        /// </summary>
        /// <param name="src">
        /// The URL to an SRT or VTT subtitles file, or an alias reference to auto-generate captions from an audio or video clip. For file URLs, the URL must be publicly accessible or include credentials. For auto-captioning, use the format `alias://clip-name` where clip-name is the alias of an audio, video, or text-to-speech clip. The system will automatically transcribe the audio and detect the language.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/captions.srt
        /// </param>
        /// <param name="font">
        /// Font properties for captions text.
        /// </param>
        /// <param name="background">
        /// Displays a background box behind the caption text.
        /// </param>
        /// <param name="margin">
        /// The margin properties for captions. Margins are used to position the caption text and background on the screen.
        /// </param>
        /// <param name="trim">
        /// The start trim point of the captions, in seconds (defaults to 0). Remove the trim length from the start of the captions and allow it to be synced with video or audio. The captions will play until the file ends or the Clip length is reached.<br/>
        /// Example: 2
        /// </param>
        /// <param name="speed">
        /// Adjust the playback speed of the captions between 0 (paused) and 10 (10x normal speed) where 1 is normal speed (defaults to 1). Adjusting the speed will also adjust the duration of the clip and may require you to  adjust the Clip length. For example, if you set speed to 0.5, the clip will need to be 2x as long to play the entire captions (i.e. original length / 0.5). If you set speed to 2, the clip will need to be half as long to play the entire captions (i.e. original length / 2).<br/>
        /// Example: 1
        /// </param>
        /// <param name="type">
        /// The type of asset - set to `caption` for captions.<br/>
        /// Default Value: caption
        /// </param>
        public CaptionAsset(
            string src,
            global::G.CaptionFont? font,
            global::G.CaptionBackground? background,
            global::G.CaptionMargin? margin,
            double? trim,
            float? speed,
            global::G.CaptionAssetType type = global::G.CaptionAssetType.Caption)
        {
            this.Type = type;
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Font = font;
            this.Background = background;
            this.Margin = margin;
            this.Trim = trim;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionAsset" /> class.
        /// </summary>
        public CaptionAsset()
        {
        }
    }
}