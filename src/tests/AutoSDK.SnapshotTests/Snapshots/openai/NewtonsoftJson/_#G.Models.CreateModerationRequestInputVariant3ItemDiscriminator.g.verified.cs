//HintName: G.Models.CreateModerationRequestInputVariant3ItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModerationRequestInputVariant3ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateModerationRequestInputVariant3ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequestInputVariant3ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public CreateModerationRequestInputVariant3ItemDiscriminator(
            global::G.CreateModerationRequestInputVariant3ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequestInputVariant3ItemDiscriminator" /> class.
        /// </summary>
        public CreateModerationRequestInputVariant3ItemDiscriminator()
        {
        }
    }
}