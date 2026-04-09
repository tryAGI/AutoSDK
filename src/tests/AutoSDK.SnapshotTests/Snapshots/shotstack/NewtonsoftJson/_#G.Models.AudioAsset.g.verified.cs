//HintName: G.Models.AudioAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The AudioAsset is used to add sound effects and audio at specific intervals on the timeline. The src must be a publicly accessible URL to an audio resource such  as an mp3 file.
    /// </summary>
    public sealed partial class AudioAsset
    {
        /// <summary>
        /// The type of asset - set to `audio` for audio assets.<br/>
        /// Default Value: audio
        /// </summary>
        /// <default>global::G.AudioAssetType.Audio</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AudioAssetTypeJsonConverter))]
        public global::G.AudioAssetType Type { get; set; } = global::G.AudioAssetType.Audio;

        /// <summary>
        /// The audio source URL. The URL must be publicly accessible or include credentials.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/sound.mp3
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/sound.mp3</example>
        [global::Newtonsoft.Json.JsonProperty("src", Required = global::Newtonsoft.Json.Required.Always)]
        public string Src { get; set; } = default!;

        /// <summary>
        /// The start trim point of the audio clip, in seconds (defaults to 0). Audio will start from the in trim point. The audio will play until the file ends or the Clip length is reached.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trim")]
        public double? Trim { get; set; }

        /// <summary>
        /// Set the volume of the audio clip. Use a number or an array of [Tween](./#tocs_tween) objects to create custom volume transitions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("volume")]
        public global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? Volume { get; set; }

        /// <summary>
        /// Adjust the playback speed of the audio clip between 0 (paused) and 10 (10x normal speed), where 1 is normal speed (defaults to 1). Adjusting the speed will also adjust the duration of the clip and may require you to  adjust the Clip length. For example, if you set speed to 0.5, the clip will need to be 2x as long to play the entire audio (i.e. original length / 0.5). If you set speed to 2, the clip will need to be half as long to play the entire audio (i.e. original length / 2).<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// The effect to apply to the audio asset &lt;ul&gt;<br/>
        ///   &lt;li&gt;`fadeIn` - fade volume in only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeOut` - fade volume out only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeInFadeOut` - fade volume in and out&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effect")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AudioAssetEffectJsonConverter))]
        public global::G.AudioAssetEffect? Effect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioAsset" /> class.
        /// </summary>
        /// <param name="src">
        /// The audio source URL. The URL must be publicly accessible or include credentials.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/sound.mp3
        /// </param>
        /// <param name="trim">
        /// The start trim point of the audio clip, in seconds (defaults to 0). Audio will start from the in trim point. The audio will play until the file ends or the Clip length is reached.
        /// </param>
        /// <param name="volume">
        /// Set the volume of the audio clip. Use a number or an array of [Tween](./#tocs_tween) objects to create custom volume transitions.
        /// </param>
        /// <param name="speed">
        /// Adjust the playback speed of the audio clip between 0 (paused) and 10 (10x normal speed), where 1 is normal speed (defaults to 1). Adjusting the speed will also adjust the duration of the clip and may require you to  adjust the Clip length. For example, if you set speed to 0.5, the clip will need to be 2x as long to play the entire audio (i.e. original length / 0.5). If you set speed to 2, the clip will need to be half as long to play the entire audio (i.e. original length / 2).<br/>
        /// Example: 1
        /// </param>
        /// <param name="effect">
        /// The effect to apply to the audio asset &lt;ul&gt;<br/>
        ///   &lt;li&gt;`fadeIn` - fade volume in only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeOut` - fade volume out only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeInFadeOut` - fade volume in and out&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="type">
        /// The type of asset - set to `audio` for audio assets.<br/>
        /// Default Value: audio
        /// </param>
        public AudioAsset(
            string src,
            double? trim,
            global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? volume,
            float? speed,
            global::G.AudioAssetEffect? effect,
            global::G.AudioAssetType type = global::G.AudioAssetType.Audio)
        {
            this.Type = type;
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Trim = trim;
            this.Volume = volume;
            this.Speed = speed;
            this.Effect = effect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioAsset" /> class.
        /// </summary>
        public AudioAsset()
        {
        }
    }
}