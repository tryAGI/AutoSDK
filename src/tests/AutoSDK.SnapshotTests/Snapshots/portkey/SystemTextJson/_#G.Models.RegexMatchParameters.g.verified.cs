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
        [global::System.Text.Json.Serialization.JsonPropertyName("rule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Rule { get; set; }

        /// <summary>
        /// If true, the check will fail when the regex pattern matches<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not")]
        public bool? Not { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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