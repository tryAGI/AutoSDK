//HintName: G.Models.CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("devcontainers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponseDevcontainer> Devcontainers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="devcontainers"></param>
        public CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponseDevcontainer> devcontainers)
        {
            this.TotalCount = totalCount;
            this.Devcontainers = devcontainers ?? throw new global::System.ArgumentNullException(nameof(devcontainers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponse" /> class.
        /// </summary>
        public CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponse()
        {
        }
    }
}