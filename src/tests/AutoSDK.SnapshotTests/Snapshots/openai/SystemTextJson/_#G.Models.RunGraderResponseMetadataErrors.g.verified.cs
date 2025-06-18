//HintName: G.Models.RunGraderResponseMetadataErrors.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunGraderResponseMetadataErrors
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formula_parse_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FormulaParseError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_parse_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SampleParseError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncated_observation_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TruncatedObservationError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unresponsive_reward_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UnresponsiveRewardError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalid_variable_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool InvalidVariableError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("other_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OtherError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("python_grader_server_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PythonGraderServerError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("python_grader_server_error_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? PythonGraderServerErrorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("python_grader_runtime_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PythonGraderRuntimeError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("python_grader_runtime_error_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? PythonGraderRuntimeErrorDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_grader_server_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ModelGraderServerError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_grader_refusal_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ModelGraderRefusalError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_grader_parse_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ModelGraderParseError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_grader_server_error_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ModelGraderServerErrorDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGraderResponseMetadataErrors" /> class.
        /// </summary>
        /// <param name="formulaParseError"></param>
        /// <param name="sampleParseError"></param>
        /// <param name="truncatedObservationError"></param>
        /// <param name="unresponsiveRewardError"></param>
        /// <param name="invalidVariableError"></param>
        /// <param name="otherError"></param>
        /// <param name="pythonGraderServerError"></param>
        /// <param name="pythonGraderServerErrorType"></param>
        /// <param name="pythonGraderRuntimeError"></param>
        /// <param name="pythonGraderRuntimeErrorDetails"></param>
        /// <param name="modelGraderServerError"></param>
        /// <param name="modelGraderRefusalError"></param>
        /// <param name="modelGraderParseError"></param>
        /// <param name="modelGraderServerErrorDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunGraderResponseMetadataErrors(
            bool formulaParseError,
            bool sampleParseError,
            bool truncatedObservationError,
            bool unresponsiveRewardError,
            bool invalidVariableError,
            bool otherError,
            bool pythonGraderServerError,
            string? pythonGraderServerErrorType,
            bool pythonGraderRuntimeError,
            string? pythonGraderRuntimeErrorDetails,
            bool modelGraderServerError,
            bool modelGraderRefusalError,
            bool modelGraderParseError,
            string? modelGraderServerErrorDetails)
        {
            this.FormulaParseError = formulaParseError;
            this.SampleParseError = sampleParseError;
            this.TruncatedObservationError = truncatedObservationError;
            this.UnresponsiveRewardError = unresponsiveRewardError;
            this.InvalidVariableError = invalidVariableError;
            this.OtherError = otherError;
            this.PythonGraderServerError = pythonGraderServerError;
            this.PythonGraderServerErrorType = pythonGraderServerErrorType ?? throw new global::System.ArgumentNullException(nameof(pythonGraderServerErrorType));
            this.PythonGraderRuntimeError = pythonGraderRuntimeError;
            this.PythonGraderRuntimeErrorDetails = pythonGraderRuntimeErrorDetails ?? throw new global::System.ArgumentNullException(nameof(pythonGraderRuntimeErrorDetails));
            this.ModelGraderServerError = modelGraderServerError;
            this.ModelGraderRefusalError = modelGraderRefusalError;
            this.ModelGraderParseError = modelGraderParseError;
            this.ModelGraderServerErrorDetails = modelGraderServerErrorDetails ?? throw new global::System.ArgumentNullException(nameof(modelGraderServerErrorDetails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGraderResponseMetadataErrors" /> class.
        /// </summary>
        public RunGraderResponseMetadataErrors()
        {
        }
    }
}