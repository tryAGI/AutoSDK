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
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Time { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CompletionTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensOverTime" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
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