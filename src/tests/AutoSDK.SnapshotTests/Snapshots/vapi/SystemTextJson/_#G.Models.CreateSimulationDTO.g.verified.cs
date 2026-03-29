//HintName: G.Models.CreateSimulationDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSimulationDTO
    {
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
        /// Initializes a new instance of the <see cref="CreateSimulationDTO" /> class.
        /// </summary>
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
        public CreateSimulationDTO(
            global::System.Guid scenarioId,
            global::System.Guid personalityId,
            string? name,
            string? path)
        {
            this.Name = name;
            this.ScenarioId = scenarioId;
            this.PersonalityId = personalityId;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSimulationDTO" /> class.
        /// </summary>
        public CreateSimulationDTO()
        {
        }
    }
}