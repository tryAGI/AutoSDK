//HintName: G.Models.CloudS3DataSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloudS3DataSource
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_access_control")]
        public bool? SupportsAccessControl { get; set; }

        /// <summary>
        /// The name of the S3 bucket to read from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Bucket { get; set; }

        /// <summary>
        /// The prefix of the S3 objects to read from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// The regex pattern to filter S3 objects. Must be a valid regex pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regex_pattern")]
        public string? RegexPattern { get; set; }

        /// <summary>
        /// The AWS access ID to use for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_access_id")]
        public string? AwsAccessId { get; set; }

        /// <summary>
        /// The AWS access secret to use for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_access_secret")]
        public string? AwsAccessSecret { get; set; }

        /// <summary>
        /// The S3 endpoint URL to use for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_endpoint_url")]
        public string? S3EndpointUrl { get; set; }

        /// <summary>
        /// Default Value: CloudS3DataSource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudS3DataSource" /> class.
        /// </summary>
        /// <param name="bucket">
        /// The name of the S3 bucket to read from.
        /// </param>
        /// <param name="supportsAccessControl">
        /// Default Value: false
        /// </param>
        /// <param name="prefix">
        /// The prefix of the S3 objects to read from.
        /// </param>
        /// <param name="regexPattern">
        /// The regex pattern to filter S3 objects. Must be a valid regex pattern.
        /// </param>
        /// <param name="awsAccessId">
        /// The AWS access ID to use for authentication.
        /// </param>
        /// <param name="awsAccessSecret">
        /// The AWS access secret to use for authentication.
        /// </param>
        /// <param name="s3EndpointUrl">
        /// The S3 endpoint URL to use for authentication.
        /// </param>
        /// <param name="className">
        /// Default Value: CloudS3DataSource
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloudS3DataSource(
            string bucket,
            bool? supportsAccessControl,
            string? prefix,
            string? regexPattern,
            string? awsAccessId,
            string? awsAccessSecret,
            string? s3EndpointUrl,
            string? className)
        {
            this.SupportsAccessControl = supportsAccessControl;
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
            this.Prefix = prefix;
            this.RegexPattern = regexPattern;
            this.AwsAccessId = awsAccessId;
            this.AwsAccessSecret = awsAccessSecret;
            this.S3EndpointUrl = s3EndpointUrl;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudS3DataSource" /> class.
        /// </summary>
        public CloudS3DataSource()
        {
        }
    }
}