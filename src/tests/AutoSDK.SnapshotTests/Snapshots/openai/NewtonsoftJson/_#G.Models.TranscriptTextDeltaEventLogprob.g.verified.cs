//HintName: G.Models.TranscriptTextDeltaEventLogprob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptTextDeltaEventLogprob
    {
        /// <summary>
        /// The token that was used to generate the log probability.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// The log probability of the token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprob")]
        public double? Logprob { get; set; }

        /// <summary>
        /// The bytes that were used to generate the log probability.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes")]
        public byte[]? Bytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextDeltaEventLogprob" /> class.
        /// </summary>
        /// <param name="token">
        /// The token that was used to generate the log probability.
        /// </param>
        /// <param name="logprob">
        /// The log probability of the token.
        /// </param>
        /// <param name="bytes">
        /// The bytes that were used to generate the log probability.
        /// </param>
        public TranscriptTextDeltaEventLogprob(
            string? token,
            double? logprob,
            byte[]? bytes)
        {
            this.Token = token;
            this.Logprob = logprob;
            this.Bytes = bytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextDeltaEventLogprob" /> class.
        /// </summary>
        public TranscriptTextDeltaEventLogprob()
        {
        }
    }
}