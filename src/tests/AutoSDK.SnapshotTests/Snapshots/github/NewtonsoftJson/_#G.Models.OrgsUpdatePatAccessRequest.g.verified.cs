//HintName: G.Models.OrgsUpdatePatAccessRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsUpdatePatAccessRequest
    {
        /// <summary>
        /// Action to apply to the fine-grained personal access token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        public global::G.OrgsUpdatePatAccessRequestAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsUpdatePatAccessRequest" /> class.
        /// </summary>
        /// <param name="action">
        /// Action to apply to the fine-grained personal access token.
        /// </param>
        public OrgsUpdatePatAccessRequest(
            global::G.OrgsUpdatePatAccessRequestAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsUpdatePatAccessRequest" /> class.
        /// </summary>
        public OrgsUpdatePatAccessRequest()
        {
        }
    }
}