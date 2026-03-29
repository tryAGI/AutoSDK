//HintName: G.Models.CreateEvaluationPipelineResponse4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvaluationPipelineResponse4
    {
        /// <summary>
        /// Example: Dataset group not found
        /// </summary>
        /// <example>Dataset group not found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineResponse4" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Dataset group not found
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvaluationPipelineResponse4(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineResponse4" /> class.
        /// </summary>
        public CreateEvaluationPipelineResponse4()
        {
        }
    }
}