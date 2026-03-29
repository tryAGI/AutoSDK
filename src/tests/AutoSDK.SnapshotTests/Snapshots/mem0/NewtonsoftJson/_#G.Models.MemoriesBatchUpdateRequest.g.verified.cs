//HintName: G.Models.MemoriesBatchUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesBatchUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MemoriesBatchUpdateRequestMemorie> Memories { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesBatchUpdateRequest" /> class.
        /// </summary>
        /// <param name="memories"></param>
        public MemoriesBatchUpdateRequest(
            global::System.Collections.Generic.IList<global::G.MemoriesBatchUpdateRequestMemorie> memories)
        {
            this.Memories = memories ?? throw new global::System.ArgumentNullException(nameof(memories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesBatchUpdateRequest" /> class.
        /// </summary>
        public MemoriesBatchUpdateRequest()
        {
        }
    }
}