//HintName: G.Models.ValidateNamespacePipelineResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ValidateNamespacePipelineResponse contains a validated pipeline.
    /// </summary>
    public sealed partial class ValidateNamespacePipelineResponse
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// The validated pipeline resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::G.ErrPipelineValidation>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateNamespacePipelineResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Included only in responses
        /// </param>
        /// <param name="errors">
        /// The validated pipeline resource.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidateNamespacePipelineResponse(
            bool? success,
            global::System.Collections.Generic.IList<global::G.ErrPipelineValidation>? errors)
        {
            this.Success = success;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateNamespacePipelineResponse" /> class.
        /// </summary>
        public ValidateNamespacePipelineResponse()
        {
        }
    }
}