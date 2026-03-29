//HintName: G.JsonConverters.DeleteProviderKeyResponseVariant1ProviderNameNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeleteProviderKeyResponseVariant1ProviderNameNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.DeleteProviderKeyResponseVariant1ProviderName?>
    {
        /// <inheritdoc />
        public override global::G.DeleteProviderKeyResponseVariant1ProviderName? Read(
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
                        return global::G.DeleteProviderKeyResponseVariant1ProviderNameExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.DeleteProviderKeyResponseVariant1ProviderName)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.DeleteProviderKeyResponseVariant1ProviderName?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.DeleteProviderKeyResponseVariant1ProviderName? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.DeleteProviderKeyResponseVariant1ProviderNameExtensions.ToValueString(value.Value));
            }
        }
    }
}
