//HintName: G.Models.MemoriesCreateResponseItemData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesCreateResponseItemData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Memory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesCreateResponseItemData" /> class.
        /// </summary>
        /// <param name="memory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesCreateResponseItemData(
            string memory)
        {
            this.Memory = memory ?? throw new global::System.ArgumentNullException(nameof(memory));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesCreateResponseItemData" /> class.
        /// </summary>
        public MemoriesCreateResponseItemData()
        {
        }
    }
}