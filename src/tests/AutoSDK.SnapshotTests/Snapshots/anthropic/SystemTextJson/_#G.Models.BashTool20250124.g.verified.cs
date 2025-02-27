//HintName: G.Models.BashTool20250124.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BashTool20250124
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::G.CacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BashTool20250124TypeJsonConverter))]
        public global::G.BashTool20250124Type Type { get; set; }

        /// <summary>
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in tool_use blocks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BashTool20250124NameJsonConverter))]
        public global::G.BashTool20250124Name Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BashTool20250124" /> class.
        /// </summary>
        /// <param name="cacheControl"></param>
        /// <param name="type"></param>
        /// <param name="name">
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in tool_use blocks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BashTool20250124(
            global::G.CacheControlEphemeral? cacheControl,
            global::G.BashTool20250124Type type,
            global::G.BashTool20250124Name name)
        {
            this.CacheControl = cacheControl;
            this.Type = type;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BashTool20250124" /> class.
        /// </summary>
        public BashTool20250124()
        {
        }
    }
}