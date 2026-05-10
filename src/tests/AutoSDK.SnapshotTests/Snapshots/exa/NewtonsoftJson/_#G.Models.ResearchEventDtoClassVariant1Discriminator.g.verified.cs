//HintName: G.Models.ResearchEventDtoClassVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eventType")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResearchEventDtoClassVariant1DiscriminatorEventTypeJsonConverter))]
        public global::G.ResearchEventDtoClassVariant1DiscriminatorEventType? EventType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        public ResearchEventDtoClassVariant1Discriminator(
            global::G.ResearchEventDtoClassVariant1DiscriminatorEventType? eventType)
        {
            this.EventType = eventType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1Discriminator" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant1Discriminator()
        {
        }

    }
}