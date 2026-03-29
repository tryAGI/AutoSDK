//HintName: G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy>
    {
        /// <inheritdoc />
        public override global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy Read(
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
                        return global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategyExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategyExtensions.ToValueString(value));
        }
    }
}
