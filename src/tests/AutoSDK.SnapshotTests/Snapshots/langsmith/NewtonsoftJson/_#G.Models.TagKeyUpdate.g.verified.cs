//HintName: G.Models.TagKeyUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TagKeyUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TagKeyUpdate" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="description"></param>
        public TagKeyUpdate(
            string? key,
            string? description)
        {
            this.Key = key;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagKeyUpdate" /> class.
        /// </summary>
        public TagKeyUpdate()
        {
        }
    }
}