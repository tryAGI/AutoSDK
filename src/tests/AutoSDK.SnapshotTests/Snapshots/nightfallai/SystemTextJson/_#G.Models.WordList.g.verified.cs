//HintName: G.Models.WordList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WordList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCaseSensitive")]
        public bool? IsCaseSensitive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordList" /> class.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="isCaseSensitive">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WordList(
            global::System.Collections.Generic.IList<string> values,
            bool? isCaseSensitive)
        {
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.IsCaseSensitive = isCaseSensitive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordList" /> class.
        /// </summary>
        public WordList()
        {
        }
    }
}