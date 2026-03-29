//HintName: G.Models.AWSStsAssumeRoleUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AWSStsAssumeRoleUser
    {
        /// <summary>
        /// This is the assumed role ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("AssumedRoleId")]
        public string? AssumedRoleId { get; set; }

        /// <summary>
        /// This is the assumed role ARN
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Arn")]
        public string? Arn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSStsAssumeRoleUser" /> class.
        /// </summary>
        /// <param name="assumedRoleId">
        /// This is the assumed role ID
        /// </param>
        /// <param name="arn">
        /// This is the assumed role ARN
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AWSStsAssumeRoleUser(
            string? assumedRoleId,
            string? arn)
        {
            this.AssumedRoleId = assumedRoleId;
            this.Arn = arn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSStsAssumeRoleUser" /> class.
        /// </summary>
        public AWSStsAssumeRoleUser()
        {
        }
    }
}