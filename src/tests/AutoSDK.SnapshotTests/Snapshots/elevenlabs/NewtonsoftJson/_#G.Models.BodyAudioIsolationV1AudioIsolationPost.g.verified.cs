//HintName: G.Models.BodyAudioIsolationV1AudioIsolationPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAudioIsolationV1AudioIsolationPost
    {
        /// <summary>
        /// The audio file from which vocals/speech will be isolated from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] Audio { get; set; } = default!;

        /// <summary>
        /// The audio file from which vocals/speech will be isolated from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audioname", Required = global::Newtonsoft.Json.Required.Always)]
        public string Audioname { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAudioIsolationV1AudioIsolationPost" /> class.
        /// </summary>
        /// <param name="audio">
        /// The audio file from which vocals/speech will be isolated from.
        /// </param>
        /// <param name="audioname">
        /// The audio file from which vocals/speech will be isolated from.
        /// </param>
        public BodyAudioIsolationV1AudioIsolationPost(
            byte[] audio,
            string audioname)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAudioIsolationV1AudioIsolationPost" /> class.
        /// </summary>
        public BodyAudioIsolationV1AudioIsolationPost()
        {
        }
    }
}