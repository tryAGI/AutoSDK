//HintName: G.Models.SSRFSecurityFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SSRFSecurityFilter
    {
        /// <summary>
        /// The type of security threat to filter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SSRFSecurityFilterTypeJsonConverter))]
        public global::G.SSRFSecurityFilterType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SSRFSecurityFilter" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of security threat to filter.
        /// </param>
        public SSRFSecurityFilter(
            global::G.SSRFSecurityFilterType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSRFSecurityFilter" /> class.
        /// </summary>
        public SSRFSecurityFilter()
        {
        }
    }
}