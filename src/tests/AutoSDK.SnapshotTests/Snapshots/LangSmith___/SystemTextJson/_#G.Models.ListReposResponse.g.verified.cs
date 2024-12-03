//HintName: G.Models.ListReposResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListReposResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RepoWithLookups> Repos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListReposResponse" /> class.
        /// </summary>
        /// <param name="repos"></param>
        /// <param name="total"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListReposResponse(
            global::System.Collections.Generic.IList<global::G.RepoWithLookups> repos,
            int total)
        {
            this.Repos = repos ?? throw new global::System.ArgumentNullException(nameof(repos));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListReposResponse" /> class.
        /// </summary>
        public ListReposResponse()
        {
        }
    }
}