//HintName: G.Models.ChatCompletionToken.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionToken
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Logprob { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("special")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Special { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionToken" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="logprob"></param>
        /// <param name="special"></param>
        /// <param name="text"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionToken(
            int id,
            float logprob,
            bool special,
            string text)
        {
            this.Id = id;
            this.Logprob = logprob;
            this.Special = special;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionToken" /> class.
        /// </summary>
        public ChatCompletionToken()
        {
        }
    }
}