//HintName: G.Models.PropertiesAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 音频格式支持：wav、mp3、ogg、m4a、aac、pcm，其中pcm仅支持24k 单通道目前限制单文件上传最大10MB，每次最多上传1个音频文件
    /// </summary>
    public sealed partial class PropertiesAudio
    {
        /// <summary>
        /// max 10M  二进制音频字节
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_bytes")]
        public byte[]? AudioBytes { get; set; }

        /// <summary>
        /// max 10M  二进制音频字节
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_bytesname")]
        public string? AudioBytesname { get; set; }

        /// <summary>
        /// 音频格式，pcm、m4a必传，其余可选
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesAudio" /> class.
        /// </summary>
        /// <param name="audioBytes">
        /// max 10M  二进制音频字节
        /// </param>
        /// <param name="audioBytesname">
        /// max 10M  二进制音频字节
        /// </param>
        /// <param name="format">
        /// 音频格式，pcm、m4a必传，其余可选
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertiesAudio(
            byte[]? audioBytes,
            string? audioBytesname,
            string? format)
        {
            this.AudioBytes = audioBytes;
            this.AudioBytesname = audioBytesname;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesAudio" /> class.
        /// </summary>
        public PropertiesAudio()
        {
        }
    }
}