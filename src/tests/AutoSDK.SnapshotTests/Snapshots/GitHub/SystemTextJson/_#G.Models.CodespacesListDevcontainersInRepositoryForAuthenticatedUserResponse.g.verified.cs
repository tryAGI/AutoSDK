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
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devcontainers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponseDevcontainer> Devcontainers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesListDevcontainersInRepositoryForAuthenticatedUserResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="devcontainers"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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