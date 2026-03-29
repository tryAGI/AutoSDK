//HintName: G.Models.S3Target.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class S3Target
    {
        /// <summary>
        /// S3 service endpoint, without protocol. Required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public string Endpoint { get; set; } = default!;

        /// <summary>
        /// If enabled, SSL will be used to connect to s3. Boolean. Optional, defaults to true<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verify_ssl")]
        public bool? VerifySsl { get; set; }

        /// <summary>
        /// S3 access key. Required.<br/>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_key")]
        public string? AccessKey { get; set; }

        /// <summary>
        /// S3 secret key. Required.<br/>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_key")]
        public string? SecretKey { get; set; }

        /// <summary>
        /// S3 bucket name. Required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucket", Required = global::Newtonsoft.Json.Required.Always)]
        public string Bucket { get; set; } = default!;

        /// <summary>
        /// Prefix for the object keys on s3. Optional, defaults to empty.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key_prefix")]
        public string? KeyPrefix { get; set; }

        /// <summary>
        /// Default Value: s3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="S3Target" /> class.
        /// </summary>
        /// <param name="endpoint">
        /// S3 service endpoint, without protocol. Required.
        /// </param>
        /// <param name="bucket">
        /// S3 bucket name. Required.
        /// </param>
        /// <param name="verifySsl">
        /// If enabled, SSL will be used to connect to s3. Boolean. Optional, defaults to true<br/>
        /// Default Value: true
        /// </param>
        /// <param name="accessKey">
        /// S3 access key. Required.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="secretKey">
        /// S3 secret key. Required.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="keyPrefix">
        /// Prefix for the object keys on s3. Optional, defaults to empty.
        /// </param>
        /// <param name="kind">
        /// Default Value: s3
        /// </param>
        public S3Target(
            string endpoint,
            string bucket,
            bool? verifySsl,
            string? accessKey,
            string? secretKey,
            string? keyPrefix,
            string? kind)
        {
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.VerifySsl = verifySsl;
            this.AccessKey = accessKey;
            this.SecretKey = secretKey;
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
            this.KeyPrefix = keyPrefix;
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="S3Target" /> class.
        /// </summary>
        public S3Target()
        {
        }
    }
}