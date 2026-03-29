//HintName: G.Models.ChatTokenLogprobTopLogprobsItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatTokenLogprobTopLogprobsItems
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
        public global::System.Collections.Generic.IList<double>? Bytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTokenLogprobTopLogprobsItems" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="logprob"></param>
        /// <param name="bytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatTokenLogprobTopLogprobsItems(
            string token,
            double logprob,
            global::System.Collections.Generic.IList<double>? bytes)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Logprob = logprob;
            this.Bytes = bytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTokenLogprobTopLogprobsItems" /> class.
        /// </summary>
        public ChatTokenLogprobTopLogprobsItems()
        {
        }
    }
}