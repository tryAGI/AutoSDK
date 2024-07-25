//HintName: JsonConverters.TracerSessionWithoutVirtualFieldsTraceTier.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class TracerSessionWithoutVirtualFieldsTraceTierJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TracerSessionWithoutVirtualFieldsTraceTier>
    {
        /// <inheritdoc />
        public override global::G.TracerSessionWithoutVirtualFieldsTraceTier Read(
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
                        return global::G.TracerSessionWithoutVirtualFieldsTraceTierExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.TracerSessionWithoutVirtualFieldsTraceTier)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TracerSessionWithoutVirtualFieldsTraceTier value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.TracerSessionWithoutVirtualFieldsTraceTierExtensions.ToValueString(value));
        }
    }
}
