//HintName: G.Models.CustomInstruction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// All enabled custom instructions for the style rule list
    /// </summary>
    public sealed partial class CustomInstruction
    {
        /// <summary>
        /// Unique identifier for the custom instruction<br/>
        /// Example: 68fdb803-c013-4e67-b62e-1aad0ab519cd
        /// </summary>
        /// <example>68fdb803-c013-4e67-b62e-1aad0ab519cd</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CustomInstruction" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the custom instruction<br/>
        /// Example: 68fdb803-c013-4e67-b62e-1aad0ab519cd
        /// </param>
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
        public CustomInstruction(
            string id,
            string label,
            string prompt,
            string? sourceLanguage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.SourceLanguage = sourceLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomInstruction" /> class.
        /// </summary>
        public CustomInstruction()
        {
        }
    }
}