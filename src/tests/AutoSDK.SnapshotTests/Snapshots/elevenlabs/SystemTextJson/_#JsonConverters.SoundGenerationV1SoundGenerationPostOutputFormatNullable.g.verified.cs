//HintName: JsonConverters.SoundGenerationV1SoundGenerationPostOutputFormatNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class SoundGenerationV1SoundGenerationPostOutputFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SoundGenerationV1SoundGenerationPostOutputFormat?>
    {
        /// <inheritdoc />
        public override global::G.SoundGenerationV1SoundGenerationPostOutputFormat? Read(
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
                        return global::G.SoundGenerationV1SoundGenerationPostOutputFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.SoundGenerationV1SoundGenerationPostOutputFormat)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SoundGenerationV1SoundGenerationPostOutputFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.SoundGenerationV1SoundGenerationPostOutputFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
