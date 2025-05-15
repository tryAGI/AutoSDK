//HintName: G.Models.DeployStatusOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeployStatusOut
    {
        /// <summary>
        /// Deploy Id<br/>
        /// Example: fkj843kjh8
        /// </summary>
        /// <example>fkj843kjh8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploy_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeployId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployStatusOut" /> class.
        /// </summary>
        /// <param name="deployId">
        /// Deploy Id<br/>
        /// Example: fkj843kjh8
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeployStatusOut(
            string deployId)
        {
            this.DeployId = deployId ?? throw new global::System.ArgumentNullException(nameof(deployId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployStatusOut" /> class.
        /// </summary>
        public DeployStatusOut()
        {
        }
    }
}