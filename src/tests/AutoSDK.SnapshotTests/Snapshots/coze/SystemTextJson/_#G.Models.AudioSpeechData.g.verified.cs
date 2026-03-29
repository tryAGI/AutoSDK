//HintName: G.Models.AudioSpeechData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioSpeechData
    {
        /// <summary>
        /// 音频时长，单位秒, 精确到毫秒
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ContentDuration")]
        public double? ContentDuration { get; set; }

        /// <summary>
        /// 语音的二进制
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public byte[]? Content { get; set; }

        /// <summary>
        /// 语音的二进制
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentname")]
        public string? Contentname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSpeechData" /> class.
        /// </summary>
        /// <param name="contentDuration">
        /// 音频时长，单位秒, 精确到毫秒
        /// </param>
        /// <param name="content">
        /// 语音的二进制
        /// </param>
        /// <param name="contentname">
        /// 语音的二进制
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioSpeechData(
            double? contentDuration,
            byte[]? content,
            string? contentname)
        {
            this.ContentDuration = contentDuration;
            this.Content = content;
            this.Contentname = contentname;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSpeechData" /> class.
        /// </summary>
        public AudioSpeechData()
        {
        }
    }
}