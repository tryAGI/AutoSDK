//HintName: G.Models.BodyAudioIsolationStreamV1AudioIsolationStreamPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAudioIsolationStreamV1AudioIsolationStreamPost
    {
        /// <summary>
        /// The audio file from which vocals/speech will be isolated from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Audio { get; set; }

        /// <summary>
        /// The audio file from which vocals/speech will be isolated from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audioname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAudioIsolationStreamV1AudioIsolationStreamPost" /> class.
        /// </summary>
        /// <param name="audio">
        /// The audio file from which vocals/speech will be isolated from.
        /// </param>
        /// <param name="audioname">
        /// The audio file from which vocals/speech will be isolated from.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyAudioIsolationStreamV1AudioIsolationStreamPost(
            byte[] audio,
            string audioname)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAudioIsolationStreamV1AudioIsolationStreamPost" /> class.
        /// </summary>
        public BodyAudioIsolationStreamV1AudioIsolationStreamPost()
        {
        }
    }
}