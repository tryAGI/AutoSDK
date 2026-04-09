//HintName: G.Models.RegexOption.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegexOption
    {
        /// <summary>
        /// This is the type of the regex option. Options are:<br/>
        /// - `ignore-case`: Ignores the case of the text being matched. Add<br/>
        /// - `whole-word`: Matches whole words only.<br/>
        /// - `multi-line`: Matches across multiple lines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RegexOptionTypeJsonConverter))]
        public global::G.RegexOptionType Type { get; set; } = default!;

        /// <summary>
        /// This is whether to enable the option.<br/>
        /// @default false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexOption" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of the regex option. Options are:<br/>
        /// - `ignore-case`: Ignores the case of the text being matched. Add<br/>
        /// - `whole-word`: Matches whole words only.<br/>
        /// - `multi-line`: Matches across multiple lines.
        /// </param>
        /// <param name="enabled">
        /// This is whether to enable the option.<br/>
        /// @default false
        /// </param>
        public RegexOption(
            global::G.RegexOptionType type,
            bool enabled)
        {
            this.Type = type;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexOption" /> class.
        /// </summary>
        public RegexOption()
        {
        }
    }
}