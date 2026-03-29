//HintName: G.Models.MemoriesReadResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesReadResponse2
    {
        /// <summary>
        /// Example: Memory not found!
        /// </summary>
        /// <example>Memory not found!</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesReadResponse2" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Memory not found!
        /// </param>
        public MemoriesReadResponse2(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesReadResponse2" /> class.
        /// </summary>
        public MemoriesReadResponse2()
        {
        }
    }
}