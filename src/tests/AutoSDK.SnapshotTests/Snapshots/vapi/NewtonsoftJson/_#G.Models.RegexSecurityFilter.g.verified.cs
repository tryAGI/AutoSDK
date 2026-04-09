//HintName: G.Models.RegexSecurityFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegexSecurityFilter
    {
        /// <summary>
        /// The type of security threat to filter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RegexSecurityFilterTypeJsonConverter))]
        public global::G.RegexSecurityFilterType Type { get; set; }

        /// <summary>
        /// The regex pattern to filter.<br/>
        /// Example: badword1|badword2
        /// </summary>
        /// <example>badword1|badword2</example>
        [global::Newtonsoft.Json.JsonProperty("regex", Required = global::Newtonsoft.Json.Required.Always)]
        public string Regex { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexSecurityFilter" /> class.
        /// </summary>
        /// <param name="regex">
        /// The regex pattern to filter.<br/>
        /// Example: badword1|badword2
        /// </param>
        /// <param name="type">
        /// The type of security threat to filter.
        /// </param>
        public RegexSecurityFilter(
            string regex,
            global::G.RegexSecurityFilterType type)
        {
            this.Type = type;
            this.Regex = regex ?? throw new global::System.ArgumentNullException(nameof(regex));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexSecurityFilter" /> class.
        /// </summary>
        public RegexSecurityFilter()
        {
        }
    }
}