//HintName: G.Models.Personality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Personality
    {
        /// <summary>
        /// This is the unique identifier for the personality.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the organization this personality belongs to.<br/>
        /// If null, this is a Vapi-provided default personality available to all organizations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId")]
        public global::System.Guid? OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the personality was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the personality was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// This is the name of the personality (e.g., "Confused Carl", "Rude Rob").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// This is the full assistant configuration for this personality.<br/>
        /// It defines the tester's voice, model, behavior via system prompt, and other settings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateAssistantDTO Assistant { get; set; } = default!;

        /// <summary>
        /// Optional folder path for organizing personalities.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Maps to GitOps resource folder structure.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Personality" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the personality.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the personality was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the personality was last updated.
        /// </param>
        /// <param name="name">
        /// This is the name of the personality (e.g., "Confused Carl", "Rude Rob").
        /// </param>
        /// <param name="assistant">
        /// This is the full assistant configuration for this personality.<br/>
        /// It defines the tester's voice, model, behavior via system prompt, and other settings.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the organization this personality belongs to.<br/>
        /// If null, this is a Vapi-provided default personality available to all organizations.
        /// </param>
        /// <param name="path">
        /// Optional folder path for organizing personalities.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Maps to GitOps resource folder structure.
        /// </param>
        public Personality(
            global::System.Guid id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string name,
            global::G.CreateAssistantDTO assistant,
            global::System.Guid? orgId,
            string? path)
        {
            this.Id = id;
            this.OrgId = orgId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Assistant = assistant ?? throw new global::System.ArgumentNullException(nameof(assistant));
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Personality" /> class.
        /// </summary>
        public Personality()
        {
        }
    }
}