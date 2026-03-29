//HintName: G.Models.FormatJsonObjectConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON object response format
    /// </summary>
    public sealed partial class FormatJsonObjectConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FormatJsonObjectConfigTypeJsonConverter))]
        public global::G.FormatJsonObjectConfigType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormatJsonObjectConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FormatJsonObjectConfig(
            global::G.FormatJsonObjectConfigType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormatJsonObjectConfig" /> class.
        /// </summary>
        public FormatJsonObjectConfig()
        {
        }
    }
}