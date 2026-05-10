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
        [global::Newtonsoft.Json.JsonProperty("aws_auth_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthTypeJsonConverter))]
        public global::G.CreateSecretReferenceRequestAuthConfigDiscriminatorAwsAuthType? AwsAuthType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretReferenceRequestAuthConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="awsAuthType"></param>
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