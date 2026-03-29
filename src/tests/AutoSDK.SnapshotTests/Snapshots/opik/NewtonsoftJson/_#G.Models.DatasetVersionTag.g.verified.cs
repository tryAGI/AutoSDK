//HintName: G.Models.DatasetVersionTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetVersionTag
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag", Required = global::Newtonsoft.Json.Required.Always)]
        public string Tag { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionTag" /> class.
        /// </summary>
        /// <param name="tag"></param>
        public DatasetVersionTag(
            string tag)
        {
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionTag" /> class.
        /// </summary>
        public DatasetVersionTag()
        {
        }
    }
}