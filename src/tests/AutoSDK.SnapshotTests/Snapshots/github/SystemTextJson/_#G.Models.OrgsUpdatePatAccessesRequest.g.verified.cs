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
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OrgsUpdatePatAccessesRequestActionJsonConverter))]
        public global::G.OrgsUpdatePatAccessesRequestAction Action { get; set; }

        /// <summary>
        /// The IDs of the fine-grained personal access tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pat_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> PatIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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