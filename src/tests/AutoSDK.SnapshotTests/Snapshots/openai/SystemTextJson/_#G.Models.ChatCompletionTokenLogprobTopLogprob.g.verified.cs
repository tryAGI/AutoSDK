//HintName: G.Models.ChatCompletionTokenLogprobTopLogprob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionTokenLogprobTopLogprob
    {
        /// <summary>
        /// A list of integers representing the UTF-8 bytes representation of the token. Useful in instances where characters are represented by multiple tokens and their byte representations must be combined to generate the correct text representation. Can be `null` if there is no bytes representation for the token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int>? Bytes { get; set; }

        /// <summary>
        /// The log probability of this token, if it is within the top 20 most likely tokens. Otherwise, the value `-9999.0` is used to signify that the token is very unlikely.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Logprob { get; set; }

        /// <summary>
        /// The token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTokenLogprobTopLogprob" /> class.
        /// </summary>
        /// <param name="bytes">
        /// A list of integers representing the UTF-8 bytes representation of the token. Useful in instances where characters are represented by multiple tokens and their byte representations must be combined to generate the correct text representation. Can be `null` if there is no bytes representation for the token.
        /// </param>
        /// <param name="logprob">
        /// The log probability of this token, if it is within the top 20 most likely tokens. Otherwise, the value `-9999.0` is used to signify that the token is very unlikely.
        /// </param>
        /// <param name="token">
        /// The token.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionTokenLogprobTopLogprob(
            global::System.Collections.Generic.IList<int>? bytes,
            double logprob,
            string token)
        {
            this.Bytes = bytes ?? throw new global::System.ArgumentNullException(nameof(bytes));
            this.Logprob = logprob;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionTokenLogprobTopLogprob" /> class.
        /// </summary>
        public ChatCompletionTokenLogprobTopLogprob()
        {
        }
    }
}