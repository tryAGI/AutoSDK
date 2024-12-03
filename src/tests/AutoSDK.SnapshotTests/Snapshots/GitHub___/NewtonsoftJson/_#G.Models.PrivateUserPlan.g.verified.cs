//HintName: G.Models.PrivateUserPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateUserPlan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collaborators", Required = global::Newtonsoft.Json.Required.Always)]
        public int Collaborators { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("space", Required = global::Newtonsoft.Json.Required.Always)]
        public int Space { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public int PrivateRepos { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateUserPlan" /> class.
        /// </summary>
        /// <param name="collaborators"></param>
        /// <param name="name"></param>
        /// <param name="space"></param>
        /// <param name="privateRepos"></param>
        public PrivateUserPlan(
            int collaborators,
            string name,
            int space,
            int privateRepos)
        {
            this.Collaborators = collaborators;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Space = space;
            this.PrivateRepos = privateRepos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateUserPlan" /> class.
        /// </summary>
        public PrivateUserPlan()
        {
        }
    }
}