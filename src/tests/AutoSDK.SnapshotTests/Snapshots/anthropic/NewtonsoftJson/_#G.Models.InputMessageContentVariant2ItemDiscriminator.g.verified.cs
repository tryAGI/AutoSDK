//HintName: G.Models.InputMessageContentVariant2ItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InputMessageContentVariant2ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputMessageContentVariant2ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessageContentVariant2ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public InputMessageContentVariant2ItemDiscriminator(
            global::G.InputMessageContentVariant2ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMessageContentVariant2ItemDiscriminator" /> class.
        /// </summary>
        public InputMessageContentVariant2ItemDiscriminator()
        {
        }
    }
}