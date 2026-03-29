//HintName: G.Models.TokensOverTime.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokensOverTime
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensOverTime" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokensOverTime(
            global::System.DateTime time,
            double promptTokens,
            double completionTokens)
        {
            this.Time = time;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensOverTime" /> class.
        /// </summary>
        public TokensOverTime()
        {
        }
    }
}