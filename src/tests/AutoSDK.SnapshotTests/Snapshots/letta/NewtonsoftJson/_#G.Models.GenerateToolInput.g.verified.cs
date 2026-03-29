//HintName: G.Models.GenerateToolInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateToolInput
    {
        /// <summary>
        /// Name of the tool to generate code for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// User prompt to generate code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Handle of the tool to generate code for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("handle")]
        public string? Handle { get; set; }

        /// <summary>
        /// Python source code to parse for JSON schema
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("starter_code")]
        public string? StarterCode { get; set; }

        /// <summary>
        /// List of validation errors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validation_errors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ValidationErrors { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateToolInput" /> class.
        /// </summary>
        /// <param name="toolName">
        /// Name of the tool to generate code for
        /// </param>
        /// <param name="prompt">
        /// User prompt to generate code
        /// </param>
        /// <param name="validationErrors">
        /// List of validation errors
        /// </param>
        /// <param name="handle">
        /// Handle of the tool to generate code for
        /// </param>
        /// <param name="starterCode">
        /// Python source code to parse for JSON schema
        /// </param>
        public GenerateToolInput(
            string toolName,
            string prompt,
            global::System.Collections.Generic.IList<string> validationErrors,
            string? handle,
            string? starterCode)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Handle = handle;
            this.StarterCode = starterCode;
            this.ValidationErrors = validationErrors ?? throw new global::System.ArgumentNullException(nameof(validationErrors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateToolInput" /> class.
        /// </summary>
        public GenerateToolInput()
        {
        }
    }
}