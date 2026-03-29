//HintName: G.Models.CustomInstructionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Input schema for creating or updating a custom instruction
    /// </summary>
    public sealed partial class CustomInstructionRequest
    {
        /// <summary>
        /// Name associated with the custom instruction<br/>
        /// Example: Currency custom instruction
        /// </summary>
        /// <example>Currency custom instruction</example>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// Prompt of the custom instruction<br/>
        /// Example: Have currency symbols before the numerical value (e.g. $100, €100)
        /// </summary>
        /// <example>Have currency symbols before the numerical value (e.g. $100, €100)</example>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Optional source language of the custom instruction<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::Newtonsoft.Json.JsonProperty("source_language")]
        public string? SourceLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomInstructionRequest" /> class.
        /// </summary>
        /// <param name="label">
        /// Name associated with the custom instruction<br/>
        /// Example: Currency custom instruction
        /// </param>
        /// <param name="prompt">
        /// Prompt of the custom instruction<br/>
        /// Example: Have currency symbols before the numerical value (e.g. $100, €100)
        /// </param>
        /// <param name="sourceLanguage">
        /// Optional source language of the custom instruction<br/>
        /// Example: en
        /// </param>
        public CustomInstructionRequest(
            string label,
            string prompt,
            string? sourceLanguage)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.SourceLanguage = sourceLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomInstructionRequest" /> class.
        /// </summary>
        public CustomInstructionRequest()
        {
        }
    }
}