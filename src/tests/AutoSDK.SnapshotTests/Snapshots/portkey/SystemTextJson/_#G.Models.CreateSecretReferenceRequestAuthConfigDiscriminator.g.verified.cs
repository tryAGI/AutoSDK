//HintName: G.Models.CreateSecretReferenceRequestAuthConfigDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSecretReferenceRequestAuthConfigDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthTypeJsonConverter))]
        public global::G.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType? AwsAuthType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretReferenceRequestAuthConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="awsAuthType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSecretReferenceRequestAuthConfigDiscriminator(
            global::G.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType? awsAuthType)
        {
            this.AwsAuthType = awsAuthType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretReferenceRequestAuthConfigDiscriminator" /> class.
        /// </summary>
        public CreateSecretReferenceRequestAuthConfigDiscriminator()
        {
        }
    }
}