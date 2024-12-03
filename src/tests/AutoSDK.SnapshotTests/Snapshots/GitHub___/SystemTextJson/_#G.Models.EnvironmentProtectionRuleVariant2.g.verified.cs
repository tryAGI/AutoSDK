//HintName: G.Models.EnvironmentProtectionRuleVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentProtectionRuleVariant2
    {
        /// <summary>
        /// Example: 3755
        /// </summary>
        /// <example>3755</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDQ6R2F0ZTM3NTU=
        /// </summary>
        /// <example>MDQ6R2F0ZTM3NTU=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Whether deployments to this environment can be approved by the user who created the deployment.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prevent_self_review")]
        public bool? PreventSelfReview { get; set; }

        /// <summary>
        /// Example: required_reviewers
        /// </summary>
        /// <example>required_reviewers</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The people or teams that may approve jobs that reference the environment. You can list up to six users or teams as reviewers. The reviewers must have at least read access to the repository. Only one of the required reviewers needs to approve the job for it to proceed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewers")]
        public global::System.Collections.Generic.IList<global::G.EnvironmentProtectionRuleVariant2Reviewer>? Reviewers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentProtectionRuleVariant2" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 3755
        /// </param>
        /// <param name="nodeId">
        /// Example: MDQ6R2F0ZTM3NTU=
        /// </param>
        /// <param name="preventSelfReview">
        /// Whether deployments to this environment can be approved by the user who created the deployment.<br/>
        /// Example: false
        /// </param>
        /// <param name="type">
        /// Example: required_reviewers
        /// </param>
        /// <param name="reviewers">
        /// The people or teams that may approve jobs that reference the environment. You can list up to six users or teams as reviewers. The reviewers must have at least read access to the repository. Only one of the required reviewers needs to approve the job for it to proceed.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public EnvironmentProtectionRuleVariant2(
            int id,
            string nodeId,
            string type,
            bool? preventSelfReview,
            global::System.Collections.Generic.IList<global::G.EnvironmentProtectionRuleVariant2Reviewer>? reviewers)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.PreventSelfReview = preventSelfReview;
            this.Reviewers = reviewers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentProtectionRuleVariant2" /> class.
        /// </summary>
        public EnvironmentProtectionRuleVariant2()
        {
        }
    }
}