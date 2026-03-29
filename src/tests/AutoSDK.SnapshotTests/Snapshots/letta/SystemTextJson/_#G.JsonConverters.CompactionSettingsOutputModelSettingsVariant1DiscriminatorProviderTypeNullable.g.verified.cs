//HintName: G.JsonConverters.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType?>
    {
        /// <inheritdoc />
        public override global::G.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType? Read(
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
                        return global::G.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
