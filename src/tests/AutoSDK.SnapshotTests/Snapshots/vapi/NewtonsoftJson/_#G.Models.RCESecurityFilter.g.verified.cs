//HintName: G.Models.RCESecurityFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RCESecurityFilter
    {
        /// <summary>
        /// The type of security threat to filter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RCESecurityFilterTypeJsonConverter))]
        public global::G.RCESecurityFilterType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RCESecurityFilter" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of security threat to filter.
        /// </param>
        public RCESecurityFilter(
            global::G.RCESecurityFilterType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RCESecurityFilter" /> class.
        /// </summary>
        public RCESecurityFilter()
        {
        }
    }
}