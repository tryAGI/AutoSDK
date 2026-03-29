//HintName: G.JsonConverters.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
