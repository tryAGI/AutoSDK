//HintName: G.Models.CreateAzureChatCompletionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAzureChatCompletionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAzureChatCompletionResponse" /> class.
        /// </summary>
        /// <param name="output"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAzureChatCompletionResponse(
            string? output)
        {
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAzureChatCompletionResponse" /> class.
        /// </summary>
        public CreateAzureChatCompletionResponse()
        {
        }
    }
}