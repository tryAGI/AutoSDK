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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RegexOptionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RegexOptionType Type { get; set; }

        /// <summary>
        /// This is whether to enable the option.<br/>
        /// @default false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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