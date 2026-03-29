//HintName: G.Models.DeleteCallDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteCallDTO
    {
        /// <summary>
        /// These are the Call IDs to be bulk deleted.<br/>
        /// If provided, the call ID if any in the request query will be ignored<br/>
        /// When requesting a bulk delete, updates when a call is deleted will be sent as a webhook to the server URL configured in the Org settings.<br/>
        /// It may take up to a few hours to complete the bulk delete, and will be asynchronous.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ids")]
        public global::System.Collections.Generic.IList<string>? Ids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCallDTO" /> class.
        /// </summary>
        /// <param name="ids">
        /// These are the Call IDs to be bulk deleted.<br/>
        /// If provided, the call ID if any in the request query will be ignored<br/>
        /// When requesting a bulk delete, updates when a call is deleted will be sent as a webhook to the server URL configured in the Org settings.<br/>
        /// It may take up to a few hours to complete the bulk delete, and will be asynchronous.
        /// </param>
        public DeleteCallDTO(
            global::System.Collections.Generic.IList<string>? ids)
        {
            this.Ids = ids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCallDTO" /> class.
        /// </summary>
        public DeleteCallDTO()
        {
        }
    }
}