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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name associated with the custom instruction<br/>
        /// Example: Currency custom instruction
        /// </summary>
        /// <example>Currency custom instruction</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Prompt of the custom instruction<br/>
        /// Example: Have currency symbols before the numerical value (e.g. $100, €100)
        /// </summary>
        /// <example>Have currency symbols before the numerical value (e.g. $100, €100)</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Optional source language of the custom instruction<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language")]
        public string? SourceLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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