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
        [global::Newtonsoft.Json.JsonProperty("formula_parse_error", Required = global::Newtonsoft.Json.Required.Always)]
        public bool FormulaParseError { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_parse_error", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SampleParseError { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("truncated_observation_error", Required = global::Newtonsoft.Json.Required.Always)]
        public bool TruncatedObservationError { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unresponsive_reward_error", Required = global::Newtonsoft.Json.Required.Always)]
        public bool UnresponsiveRewardError { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invalid_variable_error", Required = global::Newtonsoft.Json.Required.Always)]
        public bool InvalidVariableError { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("other_error", Required = global::Newtonsoft.Json.Required.Always)]
        public bool OtherError { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("python_grader_server_error", Required = global::Newtonsoft.Json.Required.Always)]
        public bool PythonGraderServerError { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("python_grader_server_error_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string? PythonGraderServerErrorType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("python_grader_runtime_error", Required = global::Newtonsoft.Json.Required.Always)]
        public bool PythonGraderRuntimeError { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("python_grader_runtime_error_details", Required = global::Newtonsoft.Json.Required.Always)]
        public string? PythonGraderRuntimeErrorDetails { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_grader_server_error", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ModelGraderServerError { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_grader_refusal_error", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ModelGraderRefusalError { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_grader_parse_error", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ModelGraderParseError { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_grader_server_error_details", Required = global::Newtonsoft.Json.Required.Always)]
        public string? ModelGraderServerErrorDetails { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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