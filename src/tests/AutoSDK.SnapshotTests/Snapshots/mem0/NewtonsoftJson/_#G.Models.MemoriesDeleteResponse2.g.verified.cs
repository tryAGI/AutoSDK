//HintName: G.Models.MemoriesDeleteResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesDeleteResponse2
    {
        /// <summary>
        /// Example: Memory deleted successfully!
        /// </summary>
        /// <example>Memory deleted successfully!</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesDeleteResponse2" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Memory deleted successfully!
        /// </param>
        public MemoriesDeleteResponse2(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesDeleteResponse2" /> class.
        /// </summary>
        public MemoriesDeleteResponse2()
        {
        }
    }
}