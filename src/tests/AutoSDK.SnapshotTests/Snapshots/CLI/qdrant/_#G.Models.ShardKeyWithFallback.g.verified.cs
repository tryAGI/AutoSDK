//HintName: G.Models.ShardKeyWithFallback.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShardKeyWithFallback
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ShardKeyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ShardKey Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ShardKeyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ShardKey Fallback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardKeyWithFallback" /> class.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="fallback"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShardKeyWithFallback(
            global::G.ShardKey target,
            global::G.ShardKey fallback)
        {
            this.Target = target;
            this.Fallback = fallback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardKeyWithFallback" /> class.
        /// </summary>
        public ShardKeyWithFallback()
        {
        }
    }
}