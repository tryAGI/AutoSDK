//HintName: G.Models.StringInvertedIndexType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StringInvertedIndexType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StringInvertedIndexConfig Config { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="StringInvertedIndexType" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StringInvertedIndexType(
            global::G.StringInvertedIndexConfig config,
            bool enabled)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringInvertedIndexType" /> class.
        /// </summary>
        public StringInvertedIndexType()
        {
        }
    }
}