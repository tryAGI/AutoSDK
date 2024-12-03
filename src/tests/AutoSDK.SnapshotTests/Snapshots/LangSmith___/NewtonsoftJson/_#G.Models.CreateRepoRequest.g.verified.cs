//HintName: G.Models.CreateRepoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Fields to create a repo
    /// </summary>
    public sealed partial class CreateRepoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo_handle", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepoHandle { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_public", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsPublic { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRepoRequest" /> class.
        /// </summary>
        /// <param name="repoHandle"></param>
        /// <param name="description"></param>
        /// <param name="readme"></param>
        /// <param name="isPublic"></param>
        /// <param name="tags"></param>
        public CreateRepoRequest(
            string repoHandle,
            bool isPublic,
            string? description,
            string? readme,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.RepoHandle = repoHandle ?? throw new global::System.ArgumentNullException(nameof(repoHandle));
            this.IsPublic = isPublic;
            this.Description = description;
            this.Readme = readme;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRepoRequest" /> class.
        /// </summary>
        public CreateRepoRequest()
        {
        }
    }
}