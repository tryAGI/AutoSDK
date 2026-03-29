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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Type of input field determining its behavior and validation rules.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApplicationInputType InputType { get; set; } = default!;

        /// <summary>
        /// Human-readable description of the input field's purpose.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates if this input field is mandatory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Required { get; set; } = default!;

        /// <summary>
        /// Type-specific configuration options for input fields.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::G.ApplicationInputOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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