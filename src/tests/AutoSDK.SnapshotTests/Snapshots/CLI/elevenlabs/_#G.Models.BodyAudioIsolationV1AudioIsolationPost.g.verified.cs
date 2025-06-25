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
        /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
        /// Default Value: other<br/>
        /// Example: pcm_s16le_16
        /// </summary>
        /// <example>pcm_s16le_16</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormatJsonConverter))]
        public global::G.BodyAudioIsolationV1AudioIsolationPostFileFormat? FileFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        /// <param name="fileFormat">
        /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
        /// Default Value: other<br/>
        /// Example: pcm_s16le_16
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyAudioIsolationV1AudioIsolationPost(
            byte[] audio,
            string audioname,
            global::G.BodyAudioIsolationV1AudioIsolationPostFileFormat? fileFormat)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
            this.FileFormat = fileFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAudioIsolationV1AudioIsolationPost" /> class.
        /// </summary>
        public BodyAudioIsolationV1AudioIsolationPost()
        {
        }
    }
}