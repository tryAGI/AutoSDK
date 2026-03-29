//HintName: G.JsonConverters.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item>
    {
        /// <inheritdoc />
        public override global::G.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item Read(
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
                        return global::G.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1ItemExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1ItemExtensions.ToValueString(value));
        }
    }
}
