//HintName: G.Models.EnvironmentProtectionRuleVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentProtectionRuleVariant3
    {
        /// <summary>
        /// Example: 3515
        /// </summary>
        /// <example>3515</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDQ6R2F0ZTM1MTU=
        /// </summary>
        /// <example>MDQ6R2F0ZTM1MTU=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: branch_policy
        /// </summary>
        /// <example>branch_policy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentProtectionRuleVariant3" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 3515
        /// </param>
        /// <param name="nodeId">
        /// Example: MDQ6R2F0ZTM1MTU=
        /// </param>
        /// <param name="type">
        /// Example: branch_policy
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public EnvironmentProtectionRuleVariant3(
            int id,
            string nodeId,
            string type)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentProtectionRuleVariant3" /> class.
        /// </summary>
        public EnvironmentProtectionRuleVariant3()
        {
        }
    }
}