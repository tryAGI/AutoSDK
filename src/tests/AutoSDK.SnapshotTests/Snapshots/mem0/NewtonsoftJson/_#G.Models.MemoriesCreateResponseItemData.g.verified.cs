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
        [global::Newtonsoft.Json.JsonProperty("memory", Required = global::Newtonsoft.Json.Required.Always)]
        public string Memory { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesCreateResponseItemData" /> class.
        /// </summary>
        /// <param name="memory"></param>
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