//HintName: G.Models.ValidatorLog.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Log entry from a single validator execution.
    /// </summary>
    public sealed partial class ValidatorLog
    {
        /// <summary>
        /// The class name of the validator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validatorName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ValidatorName { get; set; }

        /// <summary>
        /// The registry id of the validator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registeredName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RegisteredName { get; set; }

        /// <summary>
        /// A unique identifier for the validator instance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instanceId")]
        public string? InstanceId { get; set; }

        /// <summary>
        /// The JSON path to the validated property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("propertyPath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PropertyPath { get; set; }

        /// <summary>
        /// The value before validation was applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueBeforeValidation")]
        public string? ValueBeforeValidation { get; set; }

        /// <summary>
        /// The value after validation was applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueAfterValidation")]
        public string? ValueAfterValidation { get; set; }

        /// <summary>
        /// The output from a single Validator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validationResult")]
        public global::G.ValidationResult? ValidationResult { get; set; }

        /// <summary>
        /// When validation started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// When validation ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatorLog" /> class.
        /// </summary>
        /// <param name="validatorName">
        /// The class name of the validator.
        /// </param>
        /// <param name="registeredName">
        /// The registry id of the validator.
        /// </param>
        /// <param name="propertyPath">
        /// The JSON path to the validated property.
        /// </param>
        /// <param name="instanceId">
        /// A unique identifier for the validator instance.
        /// </param>
        /// <param name="valueBeforeValidation">
        /// The value before validation was applied.
        /// </param>
        /// <param name="valueAfterValidation">
        /// The value after validation was applied.
        /// </param>
        /// <param name="validationResult">
        /// The output from a single Validator.
        /// </param>
        /// <param name="startTime">
        /// When validation started.
        /// </param>
        /// <param name="endTime">
        /// When validation ended.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidatorLog(
            string validatorName,
            string registeredName,
            string propertyPath,
            string? instanceId,
            string? valueBeforeValidation,
            string? valueAfterValidation,
            global::G.ValidationResult? validationResult,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime)
        {
            this.ValidatorName = validatorName ?? throw new global::System.ArgumentNullException(nameof(validatorName));
            this.RegisteredName = registeredName ?? throw new global::System.ArgumentNullException(nameof(registeredName));
            this.InstanceId = instanceId;
            this.PropertyPath = propertyPath ?? throw new global::System.ArgumentNullException(nameof(propertyPath));
            this.ValueBeforeValidation = valueBeforeValidation;
            this.ValueAfterValidation = valueAfterValidation;
            this.ValidationResult = validationResult;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatorLog" /> class.
        /// </summary>
        public ValidatorLog()
        {
        }
    }
}