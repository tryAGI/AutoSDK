//HintName: G.Models.AWSStsAuthenticationSession.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AWSStsAuthenticationSession
    {
        /// <summary>
        /// This is the assumed role user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assumedRoleUser")]
        public global::G.AWSStsAssumeRoleUser? AssumedRoleUser { get; set; }

        /// <summary>
        /// This is the credentials for the AWS STS assume role
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credentials")]
        public global::G.AWSStsCredentials? Credentials { get; set; }

        /// <summary>
        /// This is the size of the policy
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("packedPolicySize")]
        public double? PackedPolicySize { get; set; }

        /// <summary>
        /// This is the sourced ID entity
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourcedIDEntity")]
        public string? SourcedIDEntity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSStsAuthenticationSession" /> class.
        /// </summary>
        /// <param name="assumedRoleUser">
        /// This is the assumed role user
        /// </param>
        /// <param name="credentials">
        /// This is the credentials for the AWS STS assume role
        /// </param>
        /// <param name="packedPolicySize">
        /// This is the size of the policy
        /// </param>
        /// <param name="sourcedIDEntity">
        /// This is the sourced ID entity
        /// </param>
        public AWSStsAuthenticationSession(
            global::G.AWSStsAssumeRoleUser? assumedRoleUser,
            global::G.AWSStsCredentials? credentials,
            double? packedPolicySize,
            string? sourcedIDEntity)
        {
            this.AssumedRoleUser = assumedRoleUser;
            this.Credentials = credentials;
            this.PackedPolicySize = packedPolicySize;
            this.SourcedIDEntity = sourcedIDEntity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSStsAuthenticationSession" /> class.
        /// </summary>
        public AWSStsAuthenticationSession()
        {
        }
    }
}