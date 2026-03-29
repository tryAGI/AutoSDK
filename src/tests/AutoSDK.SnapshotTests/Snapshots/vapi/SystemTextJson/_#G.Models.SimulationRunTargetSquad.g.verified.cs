//HintName: G.Models.SimulationRunTargetSquad.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationRunTargetSquad
    {
        /// <summary>
        /// Type of target
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SimulationRunTargetSquadTypeJsonConverter))]
        public global::G.SimulationRunTargetSquadType Type { get; set; }

        /// <summary>
        /// ID of an existing squad to test against. Cannot be combined with inline squad.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadId")]
        public global::System.Guid? SquadId { get; set; }

        /// <summary>
        /// Inline squad configuration to test against. Cannot be combined with squadId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squad")]
        public global::G.CreateSquadDTO? Squad { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunTargetSquad" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of target
        /// </param>
        /// <param name="squadId">
        /// ID of an existing squad to test against. Cannot be combined with inline squad.
        /// </param>
        /// <param name="squad">
        /// Inline squad configuration to test against. Cannot be combined with squadId.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationRunTargetSquad(
            global::G.SimulationRunTargetSquadType type,
            global::System.Guid? squadId,
            global::G.CreateSquadDTO? squad)
        {
            this.Type = type;
            this.SquadId = squadId;
            this.Squad = squad;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunTargetSquad" /> class.
        /// </summary>
        public SimulationRunTargetSquad()
        {
        }
    }
}