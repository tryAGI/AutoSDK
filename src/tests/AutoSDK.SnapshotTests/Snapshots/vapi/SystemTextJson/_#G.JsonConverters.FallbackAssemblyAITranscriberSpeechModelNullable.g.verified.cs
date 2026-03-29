//HintName: G.JsonConverters.FallbackAssemblyAITranscriberSpeechModelNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FallbackAssemblyAITranscriberSpeechModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FallbackAssemblyAITranscriberSpeechModel?>
    {
        /// <inheritdoc />
        public override global::G.FallbackAssemblyAITranscriberSpeechModel? Read(
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
                        return global::G.FallbackAssemblyAITranscriberSpeechModelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.FallbackAssemblyAITranscriberSpeechModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.FallbackAssemblyAITranscriberSpeechModel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FallbackAssemblyAITranscriberSpeechModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.FallbackAssemblyAITranscriberSpeechModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
