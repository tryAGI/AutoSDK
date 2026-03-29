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
        [global::Newtonsoft.Json.JsonProperty("values", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Values { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isCaseSensitive")]
        public bool? IsCaseSensitive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordList" /> class.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="isCaseSensitive">
        /// Default Value: false
        /// </param>
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