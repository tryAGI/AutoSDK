//HintName: G.Models.ResearchDtoClassVariant4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassVariant4
    {
        /// <summary>
        /// The unique identifier for the research request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("researchId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResearchId { get; set; }

        /// <summary>
        /// Milliseconds since epoch time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// The model used for the research request<br/>
        /// Default Value: exa-research
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResearchDtoClassVariant4ModelJsonConverter))]
        public global::G.ResearchDtoClassVariant4Model? Model { get; set; }

        /// <summary>
        /// The instructions given to this research request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResearchDtoClassVariant4StatusJsonConverter))]
        public global::G.ResearchDtoClassVariant4Status Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::G.ResearchEventDtoClass>? Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassVariant4" /> class.
        /// </summary>
        /// <param name="researchId">
        /// The unique identifier for the research request
        /// </param>
        /// <param name="createdAt">
        /// Milliseconds since epoch time
        /// </param>
        /// <param name="instructions">
        /// The instructions given to this research request
        /// </param>
        /// <param name="model">
        /// The model used for the research request<br/>
        /// Default Value: exa-research
        /// </param>
        /// <param name="status"></param>
        /// <param name="events"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassVariant4(
            string researchId,
            double createdAt,
            string instructions,
            global::G.ResearchDtoClassVariant4Model? model,
            global::G.ResearchDtoClassVariant4Status status,
            global::System.Collections.Generic.IList<global::G.ResearchEventDtoClass>? events)
        {
            this.ResearchId = researchId ?? throw new global::System.ArgumentNullException(nameof(researchId));
            this.CreatedAt = createdAt;
            this.Model = model;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Status = status;
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassVariant4" /> class.
        /// </summary>
        public ResearchDtoClassVariant4()
        {
        }
    }
}