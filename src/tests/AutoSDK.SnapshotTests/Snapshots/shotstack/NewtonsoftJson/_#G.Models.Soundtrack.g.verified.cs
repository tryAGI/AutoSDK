//HintName: G.Models.Soundtrack.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A music or audio file in mp3 format that plays for the duration of the rendered video or the length of the audio file, which ever is shortest.
    /// </summary>
    public sealed partial class Soundtrack
    {
        /// <summary>
        /// The URL of the mp3 audio file. The URL must be publicly accessible or include credentials.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/music.mp3
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/music.mp3</example>
        [global::Newtonsoft.Json.JsonProperty("src", Required = global::Newtonsoft.Json.Required.Always)]
        public string Src { get; set; } = default!;

        /// <summary>
        /// The effect to apply to the audio file &lt;ul&gt;<br/>
        ///   &lt;li&gt;`fadeIn` - fade volume in only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeOut` - fade volume out only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeInFadeOut` - fade volume in and out&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effect")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SoundtrackEffectJsonConverter))]
        public global::G.SoundtrackEffect? Effect { get; set; }

        /// <summary>
        /// Set the volume for the soundtrack between 0 and 1 where 0 is muted and 1 is full volume (defaults to 1).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Soundtrack" /> class.
        /// </summary>
        /// <param name="src">
        /// The URL of the mp3 audio file. The URL must be publicly accessible or include credentials.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/music.mp3
        /// </param>
        /// <param name="effect">
        /// The effect to apply to the audio file &lt;ul&gt;<br/>
        ///   &lt;li&gt;`fadeIn` - fade volume in only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeOut` - fade volume out only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeInFadeOut` - fade volume in and out&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="volume">
        /// Set the volume for the soundtrack between 0 and 1 where 0 is muted and 1 is full volume (defaults to 1).
        /// </param>
        public Soundtrack(
            string src,
            global::G.SoundtrackEffect? effect,
            double? volume)
        {
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Effect = effect;
            this.Volume = volume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Soundtrack" /> class.
        /// </summary>
        public Soundtrack()
        {
        }
    }
}