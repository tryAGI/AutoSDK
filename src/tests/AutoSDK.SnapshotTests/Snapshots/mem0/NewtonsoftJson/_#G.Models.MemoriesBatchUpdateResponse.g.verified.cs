//HintName: G.Models.MemoriesBatchUpdateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesBatchUpdateResponse
    {
        /// <summary>
        /// Example: Successfully updated 2 memories
        /// </summary>
        /// <example>Successfully updated 2 memories</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesBatchUpdateResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Successfully updated 2 memories
        /// </param>
        public MemoriesBatchUpdateResponse(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesBatchUpdateResponse" /> class.
        /// </summary>
        public MemoriesBatchUpdateResponse()
        {
        }
    }
}