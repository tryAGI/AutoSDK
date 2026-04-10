//HintName: G.Models.ApprovalCreateApprovalsVariant1ItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApprovalCreateApprovalsVariant1ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ApprovalCreateApprovalsVariant1ItemDiscriminatorTypeJsonConverter))]
        public global::G.ApprovalCreateApprovalsVariant1ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovalCreateApprovalsVariant1ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public ApprovalCreateApprovalsVariant1ItemDiscriminator(
            global::G.ApprovalCreateApprovalsVariant1ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovalCreateApprovalsVariant1ItemDiscriminator" /> class.
        /// </summary>
        public ApprovalCreateApprovalsVariant1ItemDiscriminator()
        {
        }
    }
}