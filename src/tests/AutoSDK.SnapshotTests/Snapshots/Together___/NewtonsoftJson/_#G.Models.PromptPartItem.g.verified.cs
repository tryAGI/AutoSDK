//HintName: G.Models.PromptPartItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptPartItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public global::G.LogprobsPart? Logprobs { get; set; }

        /// <summary>
        /// Example: &lt;s&gt;[INST] What is the capital of France? [/INST]
        /// </summary>
        /// <example>&lt;s&gt;[INST] What is the capital of France? [/INST]</example>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptPartItem" /> class.
        /// </summary>
        /// <param name="logprobs"></param>
        /// <param name="text">
        /// Example: &lt;s&gt;[INST] What is the capital of France? [/INST]
        /// </param>
        public PromptPartItem(
            global::G.LogprobsPart? logprobs,
            string? text)
        {
            this.Logprobs = logprobs;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptPartItem" /> class.
        /// </summary>
        public PromptPartItem()
        {
        }
    }
}