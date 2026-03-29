//HintName: G.Models.MatchTextAny.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Full-text match of at least one token of the string.
    /// </summary>
    public sealed partial class MatchTextAny
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_any", Required = global::Newtonsoft.Json.Required.Always)]
        public string TextAny { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchTextAny" /> class.
        /// </summary>
        /// <param name="textAny"></param>
        public MatchTextAny(
            string textAny)
        {
            this.TextAny = textAny ?? throw new global::System.ArgumentNullException(nameof(textAny));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchTextAny" /> class.
        /// </summary>
        public MatchTextAny()
        {
        }
    }
}