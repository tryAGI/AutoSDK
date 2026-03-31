//HintName: G.Models.JoinLivekitRoomRequestAudioConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for the input audio fed into the avatar's video generator
    /// </summary>
    public sealed partial class JoinLivekitRoomRequestAudioConfig
    {
        /// <summary>
        /// Sample rate in Hz of the audio sent to the avatar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SampleRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinLivekitRoomRequestAudioConfig" /> class.
        /// </summary>
        /// <param name="sampleRate">
        /// Sample rate in Hz of the audio sent to the avatar.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JoinLivekitRoomRequestAudioConfig(
            double sampleRate)
        {
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinLivekitRoomRequestAudioConfig" /> class.
        /// </summary>
        public JoinLivekitRoomRequestAudioConfig()
        {
        }
    }
}