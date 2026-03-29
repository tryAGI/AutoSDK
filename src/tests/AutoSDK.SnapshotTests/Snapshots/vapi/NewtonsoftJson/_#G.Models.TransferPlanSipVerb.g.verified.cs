//HintName: G.Models.TransferPlanSipVerb.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This specifies the SIP verb to use while transferring the call.<br/>
    /// - 'refer': Uses SIP REFER to transfer the call (default)<br/>
    /// - 'bye': Ends current call with SIP BYE<br/>
    /// - 'dial': Uses SIP DIAL to transfer the call<br/>
    /// Default Value: refer
    /// </summary>
    public sealed partial class TransferPlanSipVerb
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}