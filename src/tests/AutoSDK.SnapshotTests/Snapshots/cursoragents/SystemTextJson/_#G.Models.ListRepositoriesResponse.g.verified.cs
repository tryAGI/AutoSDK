//HintName: G.Models.ListRepositoriesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListRepositoriesResponse
    {
        /// <summary>
        /// Array of GitHub repositories the user has access to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ListRepositoriesResponseRepositorie> Repositories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRepositoriesResponse" /> class.
        /// </summary>
        /// <param name="repositories">
        /// Array of GitHub repositories the user has access to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListRepositoriesResponse(
            global::System.Collections.Generic.IList<global::G.ListRepositoriesResponseRepositorie> repositories)
        {
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRepositoriesResponse" /> class.
        /// </summary>
        public ListRepositoriesResponse()
        {
        }
    }
}