//HintName: G.Models.DeploymentBranchPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of a deployment branch or tag policy.
    /// </summary>
    public sealed partial class DeploymentBranchPolicy
    {
        /// <summary>
        /// The unique identifier of the branch or tag policy.<br/>
        /// Example: 361471
        /// </summary>
        /// <example>361471</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Example: MDE2OkdhdGVCcmFuY2hQb2xpY3kzNjE0NzE=
        /// </summary>
        /// <example>MDE2OkdhdGVCcmFuY2hQb2xpY3kzNjE0NzE=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// The name pattern that branches or tags must match in order to deploy to the environment.<br/>
        /// Example: release/*
        /// </summary>
        /// <example>release/*</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether this rule targets a branch or tag.<br/>
        /// Example: branch
        /// </summary>
        /// <example>branch</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeploymentBranchPolicyTypeJsonConverter))]
        public global::G.DeploymentBranchPolicyType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentBranchPolicy" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the branch or tag policy.<br/>
        /// Example: 361471
        /// </param>
        /// <param name="nodeId">
        /// Example: MDE2OkdhdGVCcmFuY2hQb2xpY3kzNjE0NzE=
        /// </param>
        /// <param name="name">
        /// The name pattern that branches or tags must match in order to deploy to the environment.<br/>
        /// Example: release/*
        /// </param>
        /// <param name="type">
        /// Whether this rule targets a branch or tag.<br/>
        /// Example: branch
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeploymentBranchPolicy(
            int? id,
            string? nodeId,
            string? name,
            global::G.DeploymentBranchPolicyType? type)
        {
            this.Id = id;
            this.NodeId = nodeId;
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentBranchPolicy" /> class.
        /// </summary>
        public DeploymentBranchPolicy()
        {
        }
    }
}