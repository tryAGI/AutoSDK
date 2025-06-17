//HintName: G.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormatNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyAudioIsolationV1AudioIsolationPostFileFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BodyAudioIsolationV1AudioIsolationPostFileFormat?>
    {
        /// <inheritdoc />
        public override global::G.BodyAudioIsolationV1AudioIsolationPostFileFormat? Read(
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
                        return global::G.BodyAudioIsolationV1AudioIsolationPostFileFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BodyAudioIsolationV1AudioIsolationPostFileFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.BodyAudioIsolationV1AudioIsolationPostFileFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BodyAudioIsolationV1AudioIsolationPostFileFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.BodyAudioIsolationV1AudioIsolationPostFileFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
