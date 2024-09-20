//HintName: G.Models.CreateRepositoryTagResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CreateRepositoryTagResponse contains the created tag.
    /// </summary>
    public sealed partial class CreateRepositoryTagResponse
    {
        /// <summary>
        /// RepositoryTag contains information about the version of some content in a<br/>
        /// repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag")]
        public global::G.RepositoryTag? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}