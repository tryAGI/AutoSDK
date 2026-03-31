//HintName: G.Models.ExpressiveVideoBackgroundVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExpressiveVideoBackgroundVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExpressiveVideoBackgroundVariant2TypeJsonConverter))]
        public global::G.ExpressiveVideoBackgroundVariant2Type Type { get; set; }

        /// <summary>
        /// Example: https://path.to.image/
        /// </summary>
        /// <example>https://path.to.image/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressiveVideoBackgroundVariant2" /> class.
        /// </summary>
        /// <param name="value">
        /// Example: https://path.to.image/
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExpressiveVideoBackgroundVariant2(
            string value,
            global::G.ExpressiveVideoBackgroundVariant2Type type)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressiveVideoBackgroundVariant2" /> class.
        /// </summary>
        public ExpressiveVideoBackgroundVariant2()
        {
        }
    }
}