//HintName: G.Models.Speed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Set the playback speed of a video or audio file. Allows you to preserve the pitch of the audio so that it is sped up without sounding too high pitched or too low.
    /// </summary>
    public sealed partial class Speed
    {
        /// <summary>
        /// Adjust the playback speed of the video clip between 0 (paused) and 10 (10x normal speed) where 1 is normal speed (defaults to 1). Set values less than 1 to slow down the playback speed, i.e. set speed to 0.5 to play back at half speed. Set values greater than 1 to speed up the playback speed, i.e. set speed to 2 to play back at double speed.<br/>
        /// Example: 1.5F
        /// </summary>
        /// <example>1.5F</example>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public float? Speed1 { get; set; }

        /// <summary>
        /// Set whether to adjust the audio pitch or not. Set to false to make the audio sound higher or lower pitched. By default the pitch is preserved.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("preservePitch")]
        public bool? PreservePitch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Speed" /> class.
        /// </summary>
        /// <param name="speed1">
        /// Adjust the playback speed of the video clip between 0 (paused) and 10 (10x normal speed) where 1 is normal speed (defaults to 1). Set values less than 1 to slow down the playback speed, i.e. set speed to 0.5 to play back at half speed. Set values greater than 1 to speed up the playback speed, i.e. set speed to 2 to play back at double speed.<br/>
        /// Example: 1.5F
        /// </param>
        /// <param name="preservePitch">
        /// Set whether to adjust the audio pitch or not. Set to false to make the audio sound higher or lower pitched. By default the pitch is preserved.<br/>
        /// Example: false
        /// </param>
        public Speed(
            float? speed1,
            bool? preservePitch)
        {
            this.Speed1 = speed1;
            this.PreservePitch = preservePitch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Speed" /> class.
        /// </summary>
        public Speed()
        {
        }
    }
}