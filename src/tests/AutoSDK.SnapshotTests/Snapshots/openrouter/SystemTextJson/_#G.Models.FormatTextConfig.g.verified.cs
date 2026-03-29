//HintName: G.Models.FormatTextConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Plain text response format
    /// </summary>
    public sealed partial class FormatTextConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FormatTextConfigTypeJsonConverter))]
        public global::G.FormatTextConfigType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormatTextConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FormatTextConfig(
            global::G.FormatTextConfigType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormatTextConfig" /> class.
        /// </summary>
        public FormatTextConfig()
        {
        }
    }
}