//HintName: G.Models.LettaBatchRequestInputVariant2ItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaBatchRequestInputVariant2ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.LettaBatchRequestInputVariant2ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaBatchRequestInputVariant2ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public LettaBatchRequestInputVariant2ItemDiscriminator(
            global::G.LettaBatchRequestInputVariant2ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaBatchRequestInputVariant2ItemDiscriminator" /> class.
        /// </summary>
        public LettaBatchRequestInputVariant2ItemDiscriminator()
        {
        }
    }
}