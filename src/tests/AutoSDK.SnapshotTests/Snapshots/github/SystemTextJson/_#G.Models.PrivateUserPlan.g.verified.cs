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
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborators")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Collaborators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("space")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Space { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PrivateRepos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateUserPlan" /> class.
        /// </summary>
        /// <param name="collaborators"></param>
        /// <param name="name"></param>
        /// <param name="space"></param>
        /// <param name="privateRepos"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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