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
        [global::Newtonsoft.Json.JsonProperty("deleted_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int DeletedCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResponse" /> class.
        /// </summary>
        /// <param name="deletedCount"></param>
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