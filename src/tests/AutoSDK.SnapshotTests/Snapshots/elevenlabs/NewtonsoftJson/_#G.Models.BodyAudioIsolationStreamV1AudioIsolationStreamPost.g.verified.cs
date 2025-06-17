﻿//HintName: G.Models.BodyAudioIsolationStreamV1AudioIsolationStreamPost.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("audio", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] Audio { get; set; } = default!;

        /// <summary>
        /// The audio file from which vocals/speech will be isolated from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audioname", Required = global::Newtonsoft.Json.Required.Always)]
        public string Audioname { get; set; } = default!;

        /// <summary>
        /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
        /// Default Value: other<br/>
        /// Example: pcm_s16le_16
        /// </summary>
        /// <example>pcm_s16le_16</example>
        [global::Newtonsoft.Json.JsonProperty("file_format")]
        public global::G.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat? FileFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="fileFormat">
        /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
        /// Default Value: other<br/>
        /// Example: pcm_s16le_16
        /// </param>
        public BodyAudioIsolationStreamV1AudioIsolationStreamPost(
            byte[] audio,
            string audioname,
            global::G.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat? fileFormat)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
            this.FileFormat = fileFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAudioIsolationStreamV1AudioIsolationStreamPost" /> class.
        /// </summary>
        public BodyAudioIsolationStreamV1AudioIsolationStreamPost()
        {
        }
    }
}