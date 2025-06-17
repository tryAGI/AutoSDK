//HintName: G.Models.SystemMessageContentVariant2ItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SystemMessageContentVariant2ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SystemMessageContentVariant2ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemMessageContentVariant2ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public SystemMessageContentVariant2ItemDiscriminator(
            global::G.SystemMessageContentVariant2ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemMessageContentVariant2ItemDiscriminator" /> class.
        /// </summary>
        public SystemMessageContentVariant2ItemDiscriminator()
        {
        }
    }
}