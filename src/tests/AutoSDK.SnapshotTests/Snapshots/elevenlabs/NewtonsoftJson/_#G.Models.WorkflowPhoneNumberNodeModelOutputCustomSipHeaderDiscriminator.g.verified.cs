//HintName: G.Models.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorTypeJsonConverter))]
        public global::G.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminator(
            global::G.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminator" /> class.
        /// </summary>
        public WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminator()
        {
        }
    }
}