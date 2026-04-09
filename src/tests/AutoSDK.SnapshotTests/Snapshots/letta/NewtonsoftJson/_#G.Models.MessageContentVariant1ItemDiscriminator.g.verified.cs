//HintName: G.Models.MessageContentVariant1ItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageContentVariant1ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MessageContentVariant1ItemDiscriminatorTypeJsonConverter))]
        public global::G.MessageContentVariant1ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentVariant1ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public MessageContentVariant1ItemDiscriminator(
            global::G.MessageContentVariant1ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentVariant1ItemDiscriminator" /> class.
        /// </summary>
        public MessageContentVariant1ItemDiscriminator()
        {
        }
    }
}