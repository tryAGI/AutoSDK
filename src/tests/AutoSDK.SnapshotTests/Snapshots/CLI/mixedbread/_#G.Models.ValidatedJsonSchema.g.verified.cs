//HintName: G.Models.ValidatedJsonSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result of validating a JSON schema.
    /// </summary>
    public sealed partial class ValidatedJsonSchema
    {
        /// <summary>
        /// Whether the schema is valid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_valid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsValid { get; set; }

        /// <summary>
        /// List of validation errors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Errors { get; set; }

        /// <summary>
        /// The validated JSON schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatedJsonSchema" /> class.
        /// </summary>
        /// <param name="isValid">
        /// Whether the schema is valid
        /// </param>
        /// <param name="errors">
        /// List of validation errors
        /// </param>
        /// <param name="jsonSchema">
        /// The validated JSON schema
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidatedJsonSchema(
            bool isValid,
            global::System.Collections.Generic.IList<string> errors,
            object jsonSchema)
        {
            this.IsValid = isValid;
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatedJsonSchema" /> class.
        /// </summary>
        public ValidatedJsonSchema()
        {
        }
    }
}