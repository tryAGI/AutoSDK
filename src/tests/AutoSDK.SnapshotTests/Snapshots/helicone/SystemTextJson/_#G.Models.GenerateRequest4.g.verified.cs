//HintName: G.Models.GenerateRequest4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateRequest4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_id")]
        public string? PromptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logRequest")]
        public bool? LogRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useAIGateway")]
        public bool? UseAIGateway { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRequest4" /> class.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="environment"></param>
        /// <param name="promptId"></param>
        /// <param name="logRequest"></param>
        /// <param name="useAIGateway"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateRequest4(
            object? inputs,
            string? environment,
            string? promptId,
            bool? logRequest,
            bool? useAIGateway)
        {
            this.Inputs = inputs;
            this.Environment = environment;
            this.PromptId = promptId;
            this.LogRequest = logRequest;
            this.UseAIGateway = useAIGateway;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRequest4" /> class.
        /// </summary>
        public GenerateRequest4()
        {
        }
    }
}