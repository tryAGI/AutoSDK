//HintName: G.Models.GenerateScenariosDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateScenariosDTO
    {
        /// <summary>
        /// ID of the assistant to generate scenarios for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// ID of the squad to generate scenarios for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateScenariosDTO" /> class.
        /// </summary>
        /// <param name="assistantId">
        /// ID of the assistant to generate scenarios for
        /// </param>
        /// <param name="squadId">
        /// ID of the squad to generate scenarios for
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateScenariosDTO(
            string? assistantId,
            string? squadId)
        {
            this.AssistantId = assistantId;
            this.SquadId = squadId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateScenariosDTO" /> class.
        /// </summary>
        public GenerateScenariosDTO()
        {
        }
    }
}