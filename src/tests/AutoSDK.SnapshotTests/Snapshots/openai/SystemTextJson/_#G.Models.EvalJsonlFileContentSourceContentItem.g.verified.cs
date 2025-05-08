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
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Item { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample")]
        public object? Sample { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalJsonlFileContentSourceContentItem" /> class.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="sample"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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