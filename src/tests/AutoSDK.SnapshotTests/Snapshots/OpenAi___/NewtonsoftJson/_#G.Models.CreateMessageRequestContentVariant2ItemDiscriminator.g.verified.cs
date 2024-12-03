//HintName: G.Models.CreateMessageRequestContentVariant2ItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMessageRequestContentVariant2ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateMessageRequestContentVariant2ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageRequestContentVariant2ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public CreateMessageRequestContentVariant2ItemDiscriminator(
            global::G.CreateMessageRequestContentVariant2ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageRequestContentVariant2ItemDiscriminator" /> class.
        /// </summary>
        public CreateMessageRequestContentVariant2ItemDiscriminator()
        {
        }
    }
}