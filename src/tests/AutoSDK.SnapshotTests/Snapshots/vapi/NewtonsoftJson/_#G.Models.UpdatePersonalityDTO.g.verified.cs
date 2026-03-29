//HintName: G.Models.UpdatePersonalityDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePersonalityDTO
    {
        /// <summary>
        /// This is the name of the personality.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the full assistant configuration for this personality.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// Optional folder path for organizing personalities.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Set to null to remove from folder.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePersonalityDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the personality.
        /// </param>
        /// <param name="assistant">
        /// This is the full assistant configuration for this personality.
        /// </param>
        /// <param name="path">
        /// Optional folder path for organizing personalities.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Set to null to remove from folder.
        /// </param>
        public UpdatePersonalityDTO(
            string? name,
            global::G.CreateAssistantDTO? assistant,
            string? path)
        {
            this.Name = name;
            this.Assistant = assistant;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePersonalityDTO" /> class.
        /// </summary>
        public UpdatePersonalityDTO()
        {
        }
    }
}