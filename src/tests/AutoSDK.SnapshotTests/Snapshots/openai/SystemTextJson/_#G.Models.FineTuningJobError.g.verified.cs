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
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// A human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The parameter that was invalid, usually `training_file` or `validation_file`. This field will be null if the failure was not parameter-specific.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Param { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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