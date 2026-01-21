//HintName: G.Models.RequestTextBlockCitationsVariant1ItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestTextBlockCitationsVariant1ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RequestTextBlockCitationsVariant1ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTextBlockCitationsVariant1ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public RequestTextBlockCitationsVariant1ItemDiscriminator(
            global::G.RequestTextBlockCitationsVariant1ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestTextBlockCitationsVariant1ItemDiscriminator" /> class.
        /// </summary>
        public RequestTextBlockCitationsVariant1ItemDiscriminator()
        {
        }
    }
}