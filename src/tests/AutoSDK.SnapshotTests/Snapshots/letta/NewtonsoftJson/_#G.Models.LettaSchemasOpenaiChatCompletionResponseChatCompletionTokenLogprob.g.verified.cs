//HintName: G.Models.LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes")]
        public global::System.Collections.Generic.IList<long>? Bytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprob", Required = global::Newtonsoft.Json.Required.Always)]
        public double Logprob { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_logprobs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LettaSchemasOpenaiChatCompletionResponseTopLogprob> TopLogprobs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="logprob"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="bytes"></param>
        public LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob(
            string token,
            double logprob,
            global::System.Collections.Generic.IList<global::G.LettaSchemasOpenaiChatCompletionResponseTopLogprob> topLogprobs,
            global::System.Collections.Generic.IList<long>? bytes)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Bytes = bytes;
            this.Logprob = logprob;
            this.TopLogprobs = topLogprobs ?? throw new global::System.ArgumentNullException(nameof(topLogprobs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob" /> class.
        /// </summary>
        public LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob()
        {
        }
    }
}