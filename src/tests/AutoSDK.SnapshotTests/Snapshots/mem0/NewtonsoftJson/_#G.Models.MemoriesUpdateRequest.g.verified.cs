//HintName: G.Models.MemoriesUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesUpdateRequest
    {
        /// <summary>
        /// The updated text content of the memory
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional metadata associated with the memory
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesUpdateRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// The updated text content of the memory
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the memory
        /// </param>
        public MemoriesUpdateRequest(
            string? text,
            object? metadata)
        {
            this.Text = text;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesUpdateRequest" /> class.
        /// </summary>
        public MemoriesUpdateRequest()
        {
        }
    }
}