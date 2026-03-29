//HintName: G.Models.BedrockBatchParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BedrockBatchParams
    {
        /// <summary>
        /// Role ARN for the bedrock batch job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        public string? RoleArn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockBatchParams" /> class.
        /// </summary>
        /// <param name="roleArn">
        /// Role ARN for the bedrock batch job
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BedrockBatchParams(
            string? roleArn)
        {
            this.RoleArn = roleArn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockBatchParams" /> class.
        /// </summary>
        public BedrockBatchParams()
        {
        }
    }
}