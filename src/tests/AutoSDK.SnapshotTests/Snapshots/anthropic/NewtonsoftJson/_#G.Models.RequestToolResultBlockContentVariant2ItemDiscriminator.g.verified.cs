//HintName: G.Models.RequestToolResultBlockContentVariant2ItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestToolResultBlockContentVariant2ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RequestToolResultBlockContentVariant2ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestToolResultBlockContentVariant2ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public RequestToolResultBlockContentVariant2ItemDiscriminator(
            global::G.RequestToolResultBlockContentVariant2ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestToolResultBlockContentVariant2ItemDiscriminator" /> class.
        /// </summary>
        public RequestToolResultBlockContentVariant2ItemDiscriminator()
        {
        }
    }
}