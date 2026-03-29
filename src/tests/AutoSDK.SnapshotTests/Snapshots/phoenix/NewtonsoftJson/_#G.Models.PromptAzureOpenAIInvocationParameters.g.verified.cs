//HintName: G.Models.PromptAzureOpenAIInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAzureOpenAIInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"azure_openai"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "azure_openai";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_openai", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptAzureOpenAIInvocationParametersContent AzureOpenai { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAzureOpenAIInvocationParameters" /> class.
        /// </summary>
        /// <param name="azureOpenai"></param>
        /// <param name="type"></param>
        public PromptAzureOpenAIInvocationParameters(
            global::G.PromptAzureOpenAIInvocationParametersContent azureOpenai,
            string type = "azure_openai")
        {
            this.Type = type;
            this.AzureOpenai = azureOpenai ?? throw new global::System.ArgumentNullException(nameof(azureOpenai));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAzureOpenAIInvocationParameters" /> class.
        /// </summary>
        public PromptAzureOpenAIInvocationParameters()
        {
        }
    }
}