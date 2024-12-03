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
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ActionsVariable> Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListRepoOrganizationVariablesResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="variables"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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