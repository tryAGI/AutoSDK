//HintName: G.Models.ChatTokenLogprob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Token log probability information
    /// </summary>
    public sealed partial class ChatTokenLogprob
    {
        /// <summary>
        /// The token
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// Log probability of the token
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprob", Required = global::Newtonsoft.Json.Required.Always)]
        public double Logprob { get; set; } = default!;

        /// <summary>
        /// UTF-8 bytes of the token
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes")]
        public global::System.Collections.Generic.IList<double>? Bytes { get; set; }

        /// <summary>
        /// Top alternative tokens with probabilities
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_logprobs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatTokenLogprobTopLogprobsItems> TopLogprobs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTokenLogprob" /> class.
        /// </summary>
        /// <param name="token">
        /// The token
        /// </param>
        /// <param name="logprob">
        /// Log probability of the token
        /// </param>
        /// <param name="topLogprobs">
        /// Top alternative tokens with probabilities
        /// </param>
        /// <param name="bytes">
        /// UTF-8 bytes of the token
        /// </param>
        public ChatTokenLogprob(
            string token,
            double logprob,
            global::System.Collections.Generic.IList<global::G.ChatTokenLogprobTopLogprobsItems> topLogprobs,
            global::System.Collections.Generic.IList<double>? bytes)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Logprob = logprob;
            this.Bytes = bytes;
            this.TopLogprobs = topLogprobs ?? throw new global::System.ArgumentNullException(nameof(topLogprobs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTokenLogprob" /> class.
        /// </summary>
        public ChatTokenLogprob()
        {
        }
    }
}