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
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Log probability of the token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Logprob { get; set; }

        /// <summary>
        /// UTF-8 bytes of the token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        public global::System.Collections.Generic.IList<double>? Bytes { get; set; }

        /// <summary>
        /// Top alternative tokens with probabilities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatTokenLogprobTopLogprobsItems> TopLogprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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