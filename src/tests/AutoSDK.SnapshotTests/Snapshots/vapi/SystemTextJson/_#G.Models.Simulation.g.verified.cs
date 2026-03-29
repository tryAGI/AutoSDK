//HintName: G.Models.Simulation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Simulation
    {
        /// <summary>
        /// This is the unique identifier for the simulation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the organization this simulation belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the simulation was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the simulation was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// This is an optional friendly name for the simulation.<br/>
        /// Example: Eligible Path with Confused User
        /// </summary>
        /// <example>Eligible Path with Confused User</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the ID of the scenario to use for this simulation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenarioId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ScenarioId { get; set; }

        /// <summary>
        /// This is the ID of the personality to use for this simulation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personalityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PersonalityId { get; set; }

        /// <summary>
        /// Optional folder path for organizing simulations.<br/>
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
        /// Initializes a new instance of the <see cref="Simulation" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the simulation.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the organization this simulation belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the simulation was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the simulation was last updated.
        /// </param>
        /// <param name="scenarioId">
        /// This is the ID of the scenario to use for this simulation.
        /// </param>
        /// <param name="personalityId">
        /// This is the ID of the personality to use for this simulation.
        /// </param>
        /// <param name="name">
        /// This is an optional friendly name for the simulation.<br/>
        /// Example: Eligible Path with Confused User
        /// </param>
        /// <param name="path">
        /// Optional folder path for organizing simulations.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Maps to GitOps resource folder structure.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Simulation(
            global::System.Guid id,
            global::System.Guid orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Guid scenarioId,
            global::System.Guid personalityId,
            string? name,
            string? path)
        {
            this.Id = id;
            this.OrgId = orgId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
            this.ScenarioId = scenarioId;
            this.PersonalityId = personalityId;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Simulation" /> class.
        /// </summary>
        public Simulation()
        {
        }
    }
}