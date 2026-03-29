//HintName: G.Models.ApplicationInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for an individual input field in the application.
    /// </summary>
    public sealed partial class ApplicationInput
    {
        /// <summary>
        /// Identifier for the input field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Type of input field determining its behavior and validation rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApplicationInputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ApplicationInputType InputType { get; set; }

        /// <summary>
        /// Human-readable description of the input field's purpose.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates if this input field is mandatory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Required { get; set; }

        /// <summary>
        /// Type-specific configuration options for input fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApplicationInputOptionsJsonConverter))]
        public global::G.ApplicationInputOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInput" /> class.
        /// </summary>
        /// <param name="name">
        /// Identifier for the input field.
        /// </param>
        /// <param name="inputType">
        /// Type of input field determining its behavior and validation rules.
        /// </param>
        /// <param name="required">
        /// Indicates if this input field is mandatory.
        /// </param>
        /// <param name="description">
        /// Human-readable description of the input field's purpose.
        /// </param>
        /// <param name="options">
        /// Type-specific configuration options for input fields.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplicationInput(
            string name,
            global::G.ApplicationInputType inputType,
            bool required,
            string? description,
            global::G.ApplicationInputOptions? options)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.InputType = inputType;
            this.Description = description;
            this.Required = required;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInput" /> class.
        /// </summary>
        public ApplicationInput()
        {
        }
    }
}