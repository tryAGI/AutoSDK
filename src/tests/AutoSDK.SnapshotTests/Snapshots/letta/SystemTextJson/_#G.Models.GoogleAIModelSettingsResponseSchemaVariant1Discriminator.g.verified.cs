//HintName: G.Models.GoogleAIModelSettingsResponseSchemaVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GoogleAIModelSettingsResponseSchemaVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorTypeJsonConverter))]
        public global::G.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAIModelSettingsResponseSchemaVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleAIModelSettingsResponseSchemaVariant1Discriminator(
            global::G.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAIModelSettingsResponseSchemaVariant1Discriminator" /> class.
        /// </summary>
        public GoogleAIModelSettingsResponseSchemaVariant1Discriminator()
        {
        }
    }
}