//HintName: G.Models.ShardKeyDescription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShardKeyDescription
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ShardKey Key { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardKeyDescription" /> class.
        /// </summary>
        /// <param name="key"></param>
        public ShardKeyDescription(
            global::G.ShardKey key)
        {
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardKeyDescription" /> class.
        /// </summary>
        public ShardKeyDescription()
        {
        }
    }
}