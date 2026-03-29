//HintName: G.Models.MemoriesBatchDeleteResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesBatchDeleteResponse
    {
        /// <summary>
        /// Example: Successfully deleted 2 memories
        /// </summary>
        /// <example>Successfully deleted 2 memories</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesBatchDeleteResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Successfully deleted 2 memories
        /// </param>
        public MemoriesBatchDeleteResponse(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesBatchDeleteResponse" /> class.
        /// </summary>
        public MemoriesBatchDeleteResponse()
        {
        }
    }
}