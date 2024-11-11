//HintName: G.Models.FineTuningJobError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// For fine-tuning jobs that have `failed`, this will contain more information on the cause of the failure.
    /// </summary>
    public sealed partial class FineTuningJobError
    {
        /// <summary>
        /// A machine-readable error code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// A human-readable error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The parameter that was invalid, usually `training_file` or `validation_file`. This field will be null if the failure was not parameter-specific.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("param", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Param { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobError" /> class.
        /// </summary>
        /// <param name="code">
        /// A machine-readable error code.
        /// </param>
        /// <param name="message">
        /// A human-readable error message.
        /// </param>
        /// <param name="param">
        /// The parameter that was invalid, usually `training_file` or `validation_file`. This field will be null if the failure was not parameter-specific.
        /// </param>
        public FineTuningJobError(
            string code,
            string message,
            string? param)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Param = param ?? throw new global::System.ArgumentNullException(nameof(param));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobError" /> class.
        /// </summary>
        public FineTuningJobError()
        {
        }
    }
}