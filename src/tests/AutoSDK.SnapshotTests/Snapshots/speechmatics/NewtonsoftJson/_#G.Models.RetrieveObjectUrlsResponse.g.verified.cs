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
        [global::Newtonsoft.Json.JsonProperty("data")]
        public string? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_mp3")]
        public string? AudioMp3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveObjectUrlsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="audioMp3"></param>
        /// <param name="transcript"></param>
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