//HintName: G.JsonConverters.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType?>
    {
        /// <inheritdoc />
        public override global::G.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType? Read(
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
                        return global::G.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
