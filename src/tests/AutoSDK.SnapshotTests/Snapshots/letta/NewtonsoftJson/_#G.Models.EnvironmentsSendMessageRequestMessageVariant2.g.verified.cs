//HintName: G.Models.EnvironmentsSendMessageRequestMessageVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentsSendMessageRequestMessageVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.EnvironmentsSendMessageRequestMessageVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approvals", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1, global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2>> Approvals { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequestMessageVariant2" /> class.
        /// </summary>
        /// <param name="approvals"></param>
        /// <param name="type"></param>
        public EnvironmentsSendMessageRequestMessageVariant2(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1, global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2>> approvals,
            global::G.EnvironmentsSendMessageRequestMessageVariant2Type type)
        {
            this.Type = type;
            this.Approvals = approvals ?? throw new global::System.ArgumentNullException(nameof(approvals));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequestMessageVariant2" /> class.
        /// </summary>
        public EnvironmentsSendMessageRequestMessageVariant2()
        {
        }
    }
}