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
        [global::Newtonsoft.Json.JsonProperty("runners", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Runners { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetSelfHostedRunnersInGroupForOrgRequest" /> class.
        /// </summary>
        /// <param name="runners">
        /// List of runner IDs to add to the runner group.
        /// </param>
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