//HintName: G.JsonConverters.V2PhoneCallResponseVariant1CallType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class V2PhoneCallResponseVariant1CallTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.V2PhoneCallResponseVariant1CallType>
    {
        /// <inheritdoc />
        public override global::G.V2PhoneCallResponseVariant1CallType Read(
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
                        return global::G.V2PhoneCallResponseVariant1CallTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.V2PhoneCallResponseVariant1CallType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.V2PhoneCallResponseVariant1CallType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.V2PhoneCallResponseVariant1CallType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.V2PhoneCallResponseVariant1CallTypeExtensions.ToValueString(value));
        }
    }
}
