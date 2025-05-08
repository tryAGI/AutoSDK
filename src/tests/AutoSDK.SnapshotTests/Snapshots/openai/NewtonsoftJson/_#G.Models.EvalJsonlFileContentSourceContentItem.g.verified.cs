//HintName: G.Models.EvalJsonlFileContentSourceContentItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalJsonlFileContentSourceContentItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item", Required = global::Newtonsoft.Json.Required.Always)]
        public object Item { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample")]
        public object? Sample { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalJsonlFileContentSourceContentItem" /> class.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="sample"></param>
        public EvalJsonlFileContentSourceContentItem(
            object item,
            object? sample)
        {
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
            this.Sample = sample;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalJsonlFileContentSourceContentItem" /> class.
        /// </summary>
        public EvalJsonlFileContentSourceContentItem()
        {
        }
    }
}