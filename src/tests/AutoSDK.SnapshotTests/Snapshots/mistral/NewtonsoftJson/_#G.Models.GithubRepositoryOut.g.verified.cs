//HintName: G.Models.GithubRepositoryOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GithubRepositoryOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public string Owner { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// Default Value: github
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.GithubRepositoryOutType? Type { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GithubRepositoryOut" /> class.
        /// </summary>
        /// <param name="commitId"></param>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="ref"></param>
        /// <param name="type">
        /// Default Value: github
        /// </param>
        /// <param name="weight">
        /// Default Value: 1
        /// </param>
        public GithubRepositoryOut(
            string commitId,
            string name,
            string owner,
            string? @ref,
            global::G.GithubRepositoryOutType? type,
            double? weight)
        {
            this.CommitId = commitId ?? throw new global::System.ArgumentNullException(nameof(commitId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Ref = @ref;
            this.Type = type;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GithubRepositoryOut" /> class.
        /// </summary>
        public GithubRepositoryOut()
        {
        }
    }
}