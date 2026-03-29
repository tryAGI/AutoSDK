//HintName: G.Models.CompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Modifies the likelihood of specified tokens appearing in a response.
    /// </summary>
    public sealed partial class CompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias
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
        /// Initializes a new instance of the <see cref="CompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias" /> class.
        /// </summary>
        /// <param name="token">
        /// A string of the chosen token ID. Value is an int from -100 to 100.
        /// </param>
        public CompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias(
            string? token)
        {
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias" /> class.
        /// </summary>
        public CompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias()
        {
        }
    }
}