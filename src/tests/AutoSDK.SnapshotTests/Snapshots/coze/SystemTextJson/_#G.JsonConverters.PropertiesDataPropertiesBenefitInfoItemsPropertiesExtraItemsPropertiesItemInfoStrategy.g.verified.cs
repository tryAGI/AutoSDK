//HintName: G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy>
    {
        /// <inheritdoc />
        public override global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy Read(
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
                        return global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategyExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategyExtensions.ToValueString(value));
        }
    }
}
