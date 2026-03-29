//HintName: G.Models.GenerateTextToSoundResponseOutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate (e.g., mp3_22050_32, mp3_44100_128, pcm_44100). If not specified, defaults to mp3_44100_128.<br/>
    /// Default Value: mp3_44100_128
    /// </summary>
    public sealed partial class GenerateTextToSoundResponseOutputFormat
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}