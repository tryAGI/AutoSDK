//HintName: G.Models.ForkRepoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Fields to fork a repo
    /// </summary>
    public sealed partial class ForkRepoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo_handle", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepoHandle { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForkRepoRequest" /> class.
        /// </summary>
        /// <param name="repoHandle"></param>
        /// <param name="readme"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="isPublic"></param>
        public ForkRepoRequest(
            string repoHandle,
            string? readme,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            bool? isPublic)
        {
            this.RepoHandle = repoHandle ?? throw new global::System.ArgumentNullException(nameof(repoHandle));
            this.Readme = readme;
            this.Description = description;
            this.Tags = tags;
            this.IsPublic = isPublic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForkRepoRequest" /> class.
        /// </summary>
        public ForkRepoRequest()
        {
        }
    }
}