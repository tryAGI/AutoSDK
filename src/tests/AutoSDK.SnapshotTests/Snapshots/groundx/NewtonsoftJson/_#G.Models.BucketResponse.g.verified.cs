//HintName: G.Models.BucketResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BucketResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucket", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BucketDetail Bucket { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketResponse" /> class.
        /// </summary>
        /// <param name="bucket"></param>
        public BucketResponse(
            global::G.BucketDetail bucket)
        {
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketResponse" /> class.
        /// </summary>
        public BucketResponse()
        {
        }
    }
}