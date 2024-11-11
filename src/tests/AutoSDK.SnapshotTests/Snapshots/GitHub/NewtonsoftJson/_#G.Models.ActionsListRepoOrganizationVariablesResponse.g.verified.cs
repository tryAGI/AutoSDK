//HintName: G.Models.ActionsListRepoOrganizationVariablesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsListRepoOrganizationVariablesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variables", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ActionsVariable> Variables { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListRepoOrganizationVariablesResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="variables"></param>
        public ActionsListRepoOrganizationVariablesResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.ActionsVariable> variables)
        {
            this.TotalCount = totalCount;
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListRepoOrganizationVariablesResponse" /> class.
        /// </summary>
        public ActionsListRepoOrganizationVariablesResponse()
        {
        }
    }
}