//HintName: G.Models.CreateChatCompletionRequestCompoundCustomToolsWolframSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for the Wolfram tool integration.
    /// </summary>
    public sealed partial class CreateChatCompletionRequestCompoundCustomToolsWolframSettings
    {
        /// <summary>
        /// API key used to authorize requests to Wolfram services.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authorization")]
        public string? Authorization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestCompoundCustomToolsWolframSettings" /> class.
        /// </summary>
        /// <param name="authorization">
        /// API key used to authorize requests to Wolfram services.
        /// </param>
        public CreateChatCompletionRequestCompoundCustomToolsWolframSettings(
            string? authorization)
        {
            this.Authorization = authorization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestCompoundCustomToolsWolframSettings" /> class.
        /// </summary>
        public CreateChatCompletionRequestCompoundCustomToolsWolframSettings()
        {
        }
    }
}