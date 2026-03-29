//HintName: G.Models.SquadMemberDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SquadMemberDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantDestinations")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.TransferDestinationAssistant, global::G.HandoffDestinationAssistant>>? AssistantDestinations { get; set; }

        /// <summary>
        /// This is the assistant that will be used for the call. To use a transient assistant, use `assistant` instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// This is the assistant that will be used for the call. To use an existing assistant, use `assistantId` instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// This can be used to override the assistant's settings and provide values for it's template variables.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantOverrides")]
        public global::G.AssistantOverrides? AssistantOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SquadMemberDTO" /> class.
        /// </summary>
        /// <param name="assistantDestinations"></param>
        /// <param name="assistantId">
        /// This is the assistant that will be used for the call. To use a transient assistant, use `assistant` instead.
        /// </param>
        /// <param name="assistant">
        /// This is the assistant that will be used for the call. To use an existing assistant, use `assistantId` instead.
        /// </param>
        /// <param name="assistantOverrides">
        /// This can be used to override the assistant's settings and provide values for it's template variables.
        /// </param>
        public SquadMemberDTO(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.TransferDestinationAssistant, global::G.HandoffDestinationAssistant>>? assistantDestinations,
            string? assistantId,
            global::G.CreateAssistantDTO? assistant,
            global::G.AssistantOverrides? assistantOverrides)
        {
            this.AssistantDestinations = assistantDestinations;
            this.AssistantId = assistantId;
            this.Assistant = assistant;
            this.AssistantOverrides = assistantOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SquadMemberDTO" /> class.
        /// </summary>
        public SquadMemberDTO()
        {
        }
    }
}