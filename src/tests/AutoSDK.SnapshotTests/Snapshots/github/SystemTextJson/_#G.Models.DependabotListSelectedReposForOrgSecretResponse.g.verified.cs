﻿//HintName: G.Models.DependabotListSelectedReposForOrgSecretResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependabotListSelectedReposForOrgSecretResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MinimalRepository> Repositories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotListSelectedReposForOrgSecretResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="repositories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependabotListSelectedReposForOrgSecretResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.MinimalRepository> repositories)
        {
            this.TotalCount = totalCount;
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotListSelectedReposForOrgSecretResponse" /> class.
        /// </summary>
        public DependabotListSelectedReposForOrgSecretResponse()
        {
        }
    }
}