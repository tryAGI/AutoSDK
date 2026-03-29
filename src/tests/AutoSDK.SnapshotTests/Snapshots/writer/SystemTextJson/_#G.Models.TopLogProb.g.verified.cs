//HintName: G.Models.TopLogProb.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An array of mappings for each token to its top log probabilities, showing detailed prediction probabilities.
    /// </summary>
    public sealed partial class TopLogProb
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
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Logprob { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        public global::System.Collections.Generic.IList<int>? Bytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopLogProb" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="logprob"></param>
        /// <param name="bytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopLogProb(
            string token,
            double logprob,
            global::System.Collections.Generic.IList<int>? bytes)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Logprob = logprob;
            this.Bytes = bytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopLogProb" /> class.
        /// </summary>
        public TopLogProb()
        {
        }
    }
}