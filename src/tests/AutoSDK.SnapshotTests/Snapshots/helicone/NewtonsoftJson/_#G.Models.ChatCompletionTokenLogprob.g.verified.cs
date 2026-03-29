//HintName: G.Models.ChatCompletionTokenLogprob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionTokenLogprob
    {
        /// <summary>
        /// The token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// A list of integers representing the UTF-8 bytes representation of the token.<br/>
        /// Useful in instances where characters are represented by multiple tokens and<br/>
        /// their byte representations must be combined to generate the correct text<br/>
        /// representation. Can be `null` if there is no bytes representation for the token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes")]
        public global::System.Collections.Generic.IList<double>? Bytes { get; set; }

        /// <summary>
        /// The log probability of this token, if it is within the top 20 most likely<br/>
        /// tokens. Otherwise, the value `-9999.0` is used to signify that the token is very<br/>
        /// unlikely.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprob", Required = global::Newtonsoft.Json.Required.Always)]
        public double Logprob { get; set; } = default!;

        /// <summary>
        /// List of the most likely tokens and their log probability, at this token<br/>
        /// position. In rare cases, there may be fewer than the number of requested<br/>
        /// `top_logprobs` returned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_logprobs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionTokenLogprobTopLogprob> TopLogprobs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTokenLogprob" /> class.
        /// </summary>
        /// <param name="token">
        /// The token.
        /// </param>
        /// <param name="logprob">
        /// The log probability of this token, if it is within the top 20 most likely<br/>
        /// tokens. Otherwise, the value `-9999.0` is used to signify that the token is very<br/>
        /// unlikely.
        /// </param>
        /// <param name="topLogprobs">
        /// List of the most likely tokens and their log probability, at this token<br/>
        /// position. In rare cases, there may be fewer than the number of requested<br/>
        /// `top_logprobs` returned.
        /// </param>
        /// <param name="bytes">
        /// A list of integers representing the UTF-8 bytes representation of the token.<br/>
        /// Useful in instances where characters are represented by multiple tokens and<br/>
        /// their byte representations must be combined to generate the correct text<br/>
        /// representation. Can be `null` if there is no bytes representation for the token.
        /// </param>
        public ChatCompletionTokenLogprob(
            string token,
            double logprob,
            global::System.Collections.Generic.IList<global::G.ChatCompletionTokenLogprobTopLogprob> topLogprobs,
            global::System.Collections.Generic.IList<double>? bytes)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Bytes = bytes;
            this.Logprob = logprob;
            this.TopLogprobs = topLogprobs ?? throw new global::System.ArgumentNullException(nameof(topLogprobs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTokenLogprob" /> class.
        /// </summary>
        public ChatCompletionTokenLogprob()
        {
        }
    }
}