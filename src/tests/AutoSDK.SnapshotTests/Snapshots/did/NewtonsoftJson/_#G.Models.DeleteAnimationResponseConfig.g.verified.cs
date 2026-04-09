//HintName: G.Models.DeleteAnimationResponseConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The configuration that used to process the animation
    /// </summary>
    public sealed partial class DeleteAnimationResponseConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logo")]
        public global::G.AnyOf<global::G.DeleteAnimationResponseConfigLogo, bool?>? Logo { get; set; }

        /// <summary>
        /// URL to overlay video to add on the animated result<br/>
        /// Example: https://path.to.directory/movie.mp4
        /// </summary>
        /// <example>https://path.to.directory/movie.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("overlay")]
        public string? Overlay { get; set; }

        /// <summary>
        /// mutes the driver sound in the animated video result, defaults to true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mute")]
        public bool? Mute { get; set; }

        /// <summary>
        /// stitch back the animated result to the original image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stitch")]
        public bool? Stitch { get; set; }

        /// <summary>
        /// the amount of faces to animate when stitch: true. Defaults to 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_animated_faces")]
        public double? MaxAnimatedFaces { get; set; }

        /// <summary>
        /// the file format of the animated video result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DeleteAnimationResponseConfigResultFormatJsonConverter))]
        public global::G.DeleteAnimationResponseConfigResultFormat? ResultFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAnimationResponseConfig" /> class.
        /// </summary>
        /// <param name="logo"></param>
        /// <param name="overlay">
        /// URL to overlay video to add on the animated result<br/>
        /// Example: https://path.to.directory/movie.mp4
        /// </param>
        /// <param name="mute">
        /// mutes the driver sound in the animated video result, defaults to true
        /// </param>
        /// <param name="stitch">
        /// stitch back the animated result to the original image
        /// </param>
        /// <param name="maxAnimatedFaces">
        /// the amount of faces to animate when stitch: true. Defaults to 5
        /// </param>
        /// <param name="resultFormat">
        /// the file format of the animated video result
        /// </param>
        public DeleteAnimationResponseConfig(
            global::G.AnyOf<global::G.DeleteAnimationResponseConfigLogo, bool?>? logo,
            string? overlay,
            bool? mute,
            bool? stitch,
            double? maxAnimatedFaces,
            global::G.DeleteAnimationResponseConfigResultFormat? resultFormat)
        {
            this.Logo = logo;
            this.Overlay = overlay;
            this.Mute = mute;
            this.Stitch = stitch;
            this.MaxAnimatedFaces = maxAnimatedFaces;
            this.ResultFormat = resultFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAnimationResponseConfig" /> class.
        /// </summary>
        public DeleteAnimationResponseConfig()
        {
        }
    }
}