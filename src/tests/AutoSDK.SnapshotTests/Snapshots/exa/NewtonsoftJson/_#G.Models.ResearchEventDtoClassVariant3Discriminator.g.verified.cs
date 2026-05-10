//HintName: G.Models.ResearchEventDtoClassVariant3Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant3Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eventType")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResearchEventDtoClassVariant3DiscriminatorEventTypeJsonConverter))]
        public global::G.ResearchEventDtoClassVariant3DiscriminatorEventType? EventType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant3Discriminator" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        public ResearchEventDtoClassVariant3Discriminator(
            global::G.ResearchEventDtoClassVariant3DiscriminatorEventType? eventType)
        {
            this.EventType = eventType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant3Discriminator" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant3Discriminator()
        {
        }

    }
}