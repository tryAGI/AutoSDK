//HintName: G.Models.Regex.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Regex
    {
        /// <summary>
        /// Regular expression pattern
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pattern", Required = global::Newtonsoft.Json.Required.Always)]
        public string Pattern { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="Regex" /> class.
        /// </summary>
        /// <param name="pattern">
        /// Regular expression pattern
        /// </param>
        /// <param name="isCaseSensitive">
        /// Default Value: false
        /// </param>
        public Regex(
            string pattern,
            bool? isCaseSensitive)
        {
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
            this.IsCaseSensitive = isCaseSensitive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Regex" /> class.
        /// </summary>
        public Regex()
        {
        }
    }
}