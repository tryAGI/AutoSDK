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
        [global::Newtonsoft.Json.JsonProperty("repositories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ListRepositoriesResponseRepositorie> Repositories { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRepositoriesResponse" /> class.
        /// </summary>
        /// <param name="repositories">
        /// Array of GitHub repositories the user has access to
        /// </param>
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