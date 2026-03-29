//HintName: G.Models.UpdateSimulationDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSimulationDTO
    {
        /// <summary>
        /// This is an optional friendly name for the simulation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the ID of the scenario to use for this simulation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenarioId")]
        public global::System.Guid? ScenarioId { get; set; }

        /// <summary>
        /// This is the ID of the personality to use for this simulation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personalityId")]
        public global::System.Guid? PersonalityId { get; set; }

        /// <summary>
        /// Optional folder path for organizing simulations.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Set to null to remove from folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSimulationDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is an optional friendly name for the simulation.
        /// </param>
        /// <param name="scenarioId">
        /// This is the ID of the scenario to use for this simulation.
        /// </param>
        /// <param name="personalityId">
        /// This is the ID of the personality to use for this simulation.
        /// </param>
        /// <param name="path">
        /// Optional folder path for organizing simulations.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Set to null to remove from folder.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSimulationDTO(
            string? name,
            global::System.Guid? scenarioId,
            global::System.Guid? personalityId,
            string? path)
        {
            this.Name = name;
            this.ScenarioId = scenarioId;
            this.PersonalityId = personalityId;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSimulationDTO" /> class.
        /// </summary>
        public UpdateSimulationDTO()
        {
        }
    }
}