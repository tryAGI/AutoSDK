//HintName: G.Models.OrgsUpdatePatAccessesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsUpdatePatAccessesRequest
    {
        /// <summary>
        /// Action to apply to the fine-grained personal access token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        public global::G.OrgsUpdatePatAccessesRequestAction Action { get; set; }

        /// <summary>
        /// The IDs of the fine-grained personal access tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pat_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> PatIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsUpdatePatAccessesRequest" /> class.
        /// </summary>
        /// <param name="action">
        /// Action to apply to the fine-grained personal access token.
        /// </param>
        /// <param name="patIds">
        /// The IDs of the fine-grained personal access tokens.
        /// </param>
        public OrgsUpdatePatAccessesRequest(
            global::System.Collections.Generic.IList<int> patIds,
            global::G.OrgsUpdatePatAccessesRequestAction action)
        {
            this.PatIds = patIds ?? throw new global::System.ArgumentNullException(nameof(patIds));
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsUpdatePatAccessesRequest" /> class.
        /// </summary>
        public OrgsUpdatePatAccessesRequest()
        {
        }
    }
}