//HintName: G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsBenefitTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PropertiesDataPropertiesBenefitInfoItemsBenefitTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PropertiesDataPropertiesBenefitInfoItemsBenefitType?>
    {
        /// <inheritdoc />
        public override global::G.PropertiesDataPropertiesBenefitInfoItemsBenefitType? Read(
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
                        return global::G.PropertiesDataPropertiesBenefitInfoItemsBenefitTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PropertiesDataPropertiesBenefitInfoItemsBenefitType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PropertiesDataPropertiesBenefitInfoItemsBenefitType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PropertiesDataPropertiesBenefitInfoItemsBenefitType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.PropertiesDataPropertiesBenefitInfoItemsBenefitTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
