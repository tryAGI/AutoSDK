//HintName: G.JsonConverters.VapiSipTransportMessageSipVerbNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class VapiSipTransportMessageSipVerbNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.VapiSipTransportMessageSipVerb?>
    {
        /// <inheritdoc />
        public override global::G.VapiSipTransportMessageSipVerb? Read(
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
                        return global::G.VapiSipTransportMessageSipVerbExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.VapiSipTransportMessageSipVerb)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.VapiSipTransportMessageSipVerb?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.VapiSipTransportMessageSipVerb? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.VapiSipTransportMessageSipVerbExtensions.ToValueString(value.Value));
            }
        }
    }
}
