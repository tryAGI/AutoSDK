//HintName: G.Models.RetrieveObjectUrlsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetrieveObjectUrlsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_mp3")]
        public string? AudioMp3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveObjectUrlsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="audioMp3"></param>
        /// <param name="transcript"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrieveObjectUrlsResponse(
            string? data,
            string? audioMp3,
            string? transcript)
        {
            this.Data = data;
            this.AudioMp3 = audioMp3;
            this.Transcript = transcript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveObjectUrlsResponse" /> class.
        /// </summary>
        public RetrieveObjectUrlsResponse()
        {
        }
    }
}