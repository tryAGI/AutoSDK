//HintName: G.JsonConverters.SpeechmaticsTranscriberOperatingPoint.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpeechmaticsTranscriberOperatingPointJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SpeechmaticsTranscriberOperatingPoint>
    {
        /// <inheritdoc />
        public override global::G.SpeechmaticsTranscriberOperatingPoint Read(
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
                        return global::G.SpeechmaticsTranscriberOperatingPointExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.SpeechmaticsTranscriberOperatingPoint)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.SpeechmaticsTranscriberOperatingPoint);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SpeechmaticsTranscriberOperatingPoint value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.SpeechmaticsTranscriberOperatingPointExtensions.ToValueString(value));
        }
    }
}
