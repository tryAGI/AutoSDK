//HintName: G.JsonConverters.V2PhoneCallResponseVariant1Direction.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class V2PhoneCallResponseVariant1DirectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.V2PhoneCallResponseVariant1Direction>
    {
        /// <inheritdoc />
        public override global::G.V2PhoneCallResponseVariant1Direction Read(
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
                        return global::G.V2PhoneCallResponseVariant1DirectionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.V2PhoneCallResponseVariant1Direction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.V2PhoneCallResponseVariant1Direction);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.V2PhoneCallResponseVariant1Direction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.V2PhoneCallResponseVariant1DirectionExtensions.ToValueString(value));
        }
    }
}
