//HintName: G.Models.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorTypeJsonConverter))]
        public global::G.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1Discriminator(
            global::G.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1Discriminator" /> class.
        /// </summary>
        public WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1Discriminator()
        {
        }
    }
}