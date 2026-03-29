//HintName: G.Models.CreatePersonalityDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePersonalityDTO
    {
        /// <summary>
        /// This is the name of the personality (e.g., "Confused Carl", "Rude Rob").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// This is the full assistant configuration for this personality.<br/>
        /// It defines the tester's voice, model, behavior via system prompt, and other settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateAssistantDTO Assistant { get; set; }

        /// <summary>
        /// Optional folder path for organizing personalities.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Maps to GitOps resource folder structure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePersonalityDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the personality (e.g., "Confused Carl", "Rude Rob").
        /// </param>
        /// <param name="assistant">
        /// This is the full assistant configuration for this personality.<br/>
        /// It defines the tester's voice, model, behavior via system prompt, and other settings.
        /// </param>
        /// <param name="path">
        /// Optional folder path for organizing personalities.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Maps to GitOps resource folder structure.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePersonalityDTO(
            string name,
            global::G.CreateAssistantDTO assistant,
            string? path)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Assistant = assistant ?? throw new global::System.ArgumentNullException(nameof(assistant));
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePersonalityDTO" /> class.
        /// </summary>
        public CreatePersonalityDTO()
        {
        }
    }
}