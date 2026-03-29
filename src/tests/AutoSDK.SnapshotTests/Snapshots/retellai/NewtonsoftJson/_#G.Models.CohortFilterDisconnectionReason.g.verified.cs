//HintName: G.Models.CohortFilterDisconnectionReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter calls by disconnection reason. If not specified, all disconnection reasons are included.
    /// </summary>
    public sealed partial class CohortFilterDisconnectionReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public global::System.Collections.Generic.IList<global::G.DisconnectionReason4>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortFilterDisconnectionReason" /> class.
        /// </summary>
        /// <param name="value"></param>
        public CohortFilterDisconnectionReason(
            global::System.Collections.Generic.IList<global::G.DisconnectionReason4>? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortFilterDisconnectionReason" /> class.
        /// </summary>
        public CohortFilterDisconnectionReason()
        {
        }
    }
}