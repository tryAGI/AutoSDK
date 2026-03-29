//HintName: G.Models.PortkeyBatchOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options to be passed to the provider, supports all options supported by the provider from gateway.<br/>
    /// Example: {"x-portkey-virtual-key":"vkey-1234567890","x-portkey-aws-s3-bucket":"my-bucket","x-portkey-provider-model":"meta.llama3-1-8b-instruct-v1:0","x-portkey-vertex-storage-bucket-name":"my-bucket"}
    /// </summary>
    public sealed partial class PortkeyBatchOptions
    {
        /// <summary>
        /// The virtual key to communicate with the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x-portkey-virtual-key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string XPortkeyVirtualKey { get; set; }

        /// <summary>
        /// The AWS S3 bucket to use for file upload during finetune
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x-portkey-aws-s3-bucket")]
        public string? XPortkeyAwsS3Bucket { get; set; }

        /// <summary>
        /// Google Storage bucket to use for file upload during finetune
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x-portkey-vertex-storage-bucket-name")]
        public string? XPortkeyVertexStorageBucketName { get; set; }

        /// <summary>
        /// Model to use for the batch job also for file transformation for model specific inference input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x-portkey-provider-model")]
        public string? XPortkeyProviderModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PortkeyBatchOptions" /> class.
        /// </summary>
        /// <param name="xPortkeyVirtualKey">
        /// The virtual key to communicate with the provider
        /// </param>
        /// <param name="xPortkeyAwsS3Bucket">
        /// The AWS S3 bucket to use for file upload during finetune
        /// </param>
        /// <param name="xPortkeyVertexStorageBucketName">
        /// Google Storage bucket to use for file upload during finetune
        /// </param>
        /// <param name="xPortkeyProviderModel">
        /// Model to use for the batch job also for file transformation for model specific inference input.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PortkeyBatchOptions(
            string xPortkeyVirtualKey,
            string? xPortkeyAwsS3Bucket,
            string? xPortkeyVertexStorageBucketName,
            string? xPortkeyProviderModel)
        {
            this.XPortkeyVirtualKey = xPortkeyVirtualKey ?? throw new global::System.ArgumentNullException(nameof(xPortkeyVirtualKey));
            this.XPortkeyAwsS3Bucket = xPortkeyAwsS3Bucket;
            this.XPortkeyVertexStorageBucketName = xPortkeyVertexStorageBucketName;
            this.XPortkeyProviderModel = xPortkeyProviderModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortkeyBatchOptions" /> class.
        /// </summary>
        public PortkeyBatchOptions()
        {
        }
    }
}