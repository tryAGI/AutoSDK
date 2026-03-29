//HintName: G.Models.DeleteResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API response for bulk delete operation
    /// </summary>
    public sealed partial class DeleteResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DeletedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResponse" /> class.
        /// </summary>
        /// <param name="deletedCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteResponse(
            int deletedCount)
        {
            this.DeletedCount = deletedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResponse" /> class.
        /// </summary>
        public DeleteResponse()
        {
        }
    }
}