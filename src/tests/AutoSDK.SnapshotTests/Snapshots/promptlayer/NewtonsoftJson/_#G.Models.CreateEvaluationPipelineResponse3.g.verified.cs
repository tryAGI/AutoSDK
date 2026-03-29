//HintName: G.Models.CreateEvaluationPipelineResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvaluationPipelineResponse3
    {
        /// <summary>
        /// Example: Access to this dataset group is not allowed
        /// </summary>
        /// <example>Access to this dataset group is not allowed</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineResponse3" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Access to this dataset group is not allowed
        /// </param>
        public CreateEvaluationPipelineResponse3(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluationPipelineResponse3" /> class.
        /// </summary>
        public CreateEvaluationPipelineResponse3()
        {
        }
    }
}