//HintName: G.Models.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Modifies the likelihood of specified tokens appearing in a response.
    /// </summary>
    public sealed partial class ChatCompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias
    {
        /// <summary>
        /// A string of the chosen token ID. Value is an int from -100 to 100.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias" /> class.
        /// </summary>
        /// <param name="token">
        /// A string of the chosen token ID. Value is an int from -100 to 100.
        /// </param>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias(
            string? token)
        {
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias" /> class.
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias()
        {
        }
    }
}