//HintName: G.Models.ActionsSetSelfHostedRunnersInGroupForOrgRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsSetSelfHostedRunnersInGroupForOrgRequest
    {
        /// <summary>
        /// List of runner IDs to add to the runner group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runners")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Runners { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetSelfHostedRunnersInGroupForOrgRequest" /> class.
        /// </summary>
        /// <param name="runners">
        /// List of runner IDs to add to the runner group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsSetSelfHostedRunnersInGroupForOrgRequest(
            global::System.Collections.Generic.IList<int> runners)
        {
            this.Runners = runners ?? throw new global::System.ArgumentNullException(nameof(runners));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetSelfHostedRunnersInGroupForOrgRequest" /> class.
        /// </summary>
        public ActionsSetSelfHostedRunnersInGroupForOrgRequest()
        {
        }
    }
}