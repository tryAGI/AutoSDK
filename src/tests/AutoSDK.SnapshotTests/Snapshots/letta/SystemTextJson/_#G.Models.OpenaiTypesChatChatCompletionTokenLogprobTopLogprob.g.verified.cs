//HintName: G.Models.OpenaiTypesChatChatCompletionTokenLogprobTopLogprob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenaiTypesChatChatCompletionTokenLogprobTopLogprob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        public global::System.Collections.Generic.IList<long>? Bytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Logprob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenaiTypesChatChatCompletionTokenLogprobTopLogprob" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="logprob"></param>
        /// <param name="bytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenaiTypesChatChatCompletionTokenLogprobTopLogprob(
            string token,
            double logprob,
            global::System.Collections.Generic.IList<long>? bytes)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Bytes = bytes;
            this.Logprob = logprob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenaiTypesChatChatCompletionTokenLogprobTopLogprob" /> class.
        /// </summary>
        public OpenaiTypesChatChatCompletionTokenLogprobTopLogprob()
        {
        }
    }
}