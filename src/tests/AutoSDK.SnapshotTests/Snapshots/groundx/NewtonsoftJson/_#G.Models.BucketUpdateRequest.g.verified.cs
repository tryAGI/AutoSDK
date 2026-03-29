//HintName: G.Models.BucketUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BucketUpdateRequest
    {
        /// <summary>
        /// The new name of the bucket being renamed.<br/>
        /// Example: your_bucket_name
        /// </summary>
        /// <example>your_bucket_name</example>
        [global::Newtonsoft.Json.JsonProperty("newName", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketUpdateRequest" /> class.
        /// </summary>
        /// <param name="newName">
        /// The new name of the bucket being renamed.<br/>
        /// Example: your_bucket_name
        /// </param>
        public BucketUpdateRequest(
            string newName)
        {
            this.NewName = newName ?? throw new global::System.ArgumentNullException(nameof(newName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketUpdateRequest" /> class.
        /// </summary>
        public BucketUpdateRequest()
        {
        }
    }
}