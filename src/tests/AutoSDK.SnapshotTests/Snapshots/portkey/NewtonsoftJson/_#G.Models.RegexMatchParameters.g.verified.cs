//HintName: G.Models.RegexMatchParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegexMatchParameters
    {
        /// <summary>
        /// Regex pattern to match
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rule", Required = global::Newtonsoft.Json.Required.Always)]
        public string Rule { get; set; } = default!;

        /// <summary>
        /// If true, the check will fail when the regex pattern matches<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("not")]
        public bool? Not { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexMatchParameters" /> class.
        /// </summary>
        /// <param name="rule">
        /// Regex pattern to match
        /// </param>
        /// <param name="not">
        /// If true, the check will fail when the regex pattern matches<br/>
        /// Default Value: false
        /// </param>
        public RegexMatchParameters(
            string rule,
            bool? not)
        {
            this.Rule = rule ?? throw new global::System.ArgumentNullException(nameof(rule));
            this.Not = not;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexMatchParameters" /> class.
        /// </summary>
        public RegexMatchParameters()
        {
        }
    }
}