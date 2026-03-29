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
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the ID of the scenario to use for this simulation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scenarioId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ScenarioId { get; set; } = default!;

        /// <summary>
        /// This is the ID of the personality to use for this simulation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("personalityId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid PersonalityId { get; set; } = default!;

        /// <summary>
        /// Optional folder path for organizing simulations.<br/>
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