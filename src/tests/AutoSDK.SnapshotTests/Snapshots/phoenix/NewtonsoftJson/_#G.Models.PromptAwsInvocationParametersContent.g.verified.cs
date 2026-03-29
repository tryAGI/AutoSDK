//HintName: G.Models.PromptAwsInvocationParametersContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAwsInvocationParametersContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAwsInvocationParametersContent" /> class.
        /// </summary>
        /// <param name="maxTokens"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        public PromptAwsInvocationParametersContent(
            int? maxTokens,
            double? temperature,
            double? topP)
        {
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.TopP = topP;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAwsInvocationParametersContent" /> class.
        /// </summary>
        public PromptAwsInvocationParametersContent()
        {
        }
    }
}