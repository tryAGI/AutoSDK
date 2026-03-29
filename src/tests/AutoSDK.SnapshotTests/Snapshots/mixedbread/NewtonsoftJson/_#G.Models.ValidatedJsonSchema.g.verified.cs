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
        [global::Newtonsoft.Json.JsonProperty("is_valid", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsValid { get; set; } = default!;

        /// <summary>
        /// List of validation errors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Errors { get; set; } = default!;

        /// <summary>
        /// The validated JSON schema
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object JsonSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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