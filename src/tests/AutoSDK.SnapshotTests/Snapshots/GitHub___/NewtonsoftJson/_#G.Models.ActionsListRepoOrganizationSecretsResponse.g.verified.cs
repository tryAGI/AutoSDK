//HintName: G.Models.ActionsListRepoOrganizationSecretsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsListRepoOrganizationSecretsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secrets", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ActionsSecret> Secrets { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListRepoOrganizationSecretsResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="secrets"></param>
        public ActionsListRepoOrganizationSecretsResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.ActionsSecret> secrets)
        {
            this.TotalCount = totalCount;
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListRepoOrganizationSecretsResponse" /> class.
        /// </summary>
        public ActionsListRepoOrganizationSecretsResponse()
        {
        }
    }
}