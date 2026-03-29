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
        [global::System.Text.Json.Serialization.JsonPropertyName("newName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketUpdateRequest" /> class.
        /// </summary>
        /// <param name="newName">
        /// The new name of the bucket being renamed.<br/>
        /// Example: your_bucket_name
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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