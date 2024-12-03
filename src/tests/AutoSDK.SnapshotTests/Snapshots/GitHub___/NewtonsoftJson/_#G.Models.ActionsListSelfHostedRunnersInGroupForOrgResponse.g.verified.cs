//HintName: G.Models.ActionsListSelfHostedRunnersInGroupForOrgResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsListSelfHostedRunnersInGroupForOrgResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runners", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Runner> Runners { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListSelfHostedRunnersInGroupForOrgResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="runners"></param>
        public ActionsListSelfHostedRunnersInGroupForOrgResponse(
            double totalCount,
            global::System.Collections.Generic.IList<global::G.Runner> runners)
        {
            this.TotalCount = totalCount;
            this.Runners = runners ?? throw new global::System.ArgumentNullException(nameof(runners));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListSelfHostedRunnersInGroupForOrgResponse" /> class.
        /// </summary>
        public ActionsListSelfHostedRunnersInGroupForOrgResponse()
        {
        }
    }
}