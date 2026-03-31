//HintName: G.Models.ExpressiveVideoBackgroundVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExpressiveVideoBackgroundVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExpressiveVideoBackgroundVariant1TypeJsonConverter))]
        public global::G.ExpressiveVideoBackgroundVariant1Type Type { get; set; }

        /// <summary>
        /// Example: #47ffff
        /// </summary>
        /// <example>#47ffff</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressiveVideoBackgroundVariant1" /> class.
        /// </summary>
        /// <param name="value">
        /// Example: #47ffff
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExpressiveVideoBackgroundVariant1(
            string value,
            global::G.ExpressiveVideoBackgroundVariant1Type type)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressiveVideoBackgroundVariant1" /> class.
        /// </summary>
        public ExpressiveVideoBackgroundVariant1()
        {
        }
    }
}