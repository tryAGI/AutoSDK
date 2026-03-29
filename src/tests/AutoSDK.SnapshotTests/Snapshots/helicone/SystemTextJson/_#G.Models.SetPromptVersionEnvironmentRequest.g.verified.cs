//HintName: G.Models.SetPromptVersionEnvironmentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetPromptVersionEnvironmentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVersionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetPromptVersionEnvironmentRequest" /> class.
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="promptId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetPromptVersionEnvironmentRequest(
            string environment,
            string promptVersionId,
            string promptId)
        {
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.PromptVersionId = promptVersionId ?? throw new global::System.ArgumentNullException(nameof(promptVersionId));
            this.PromptId = promptId ?? throw new global::System.ArgumentNullException(nameof(promptId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetPromptVersionEnvironmentRequest" /> class.
        /// </summary>
        public SetPromptVersionEnvironmentRequest()
        {
        }
    }
}