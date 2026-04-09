//HintName: G.Models.PromptInjectionSecurityFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptInjectionSecurityFilter
    {
        /// <summary>
        /// The type of security threat to filter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PromptInjectionSecurityFilterTypeJsonConverter))]
        public global::G.PromptInjectionSecurityFilterType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptInjectionSecurityFilter" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of security threat to filter.
        /// </param>
        public PromptInjectionSecurityFilter(
            global::G.PromptInjectionSecurityFilterType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptInjectionSecurityFilter" /> class.
        /// </summary>
        public PromptInjectionSecurityFilter()
        {
        }
    }
}