//HintName: G.JsonConverters.AzureSpeechTranscriberSegmentationStrategy.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AzureSpeechTranscriberSegmentationStrategyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AzureSpeechTranscriberSegmentationStrategy>
    {
        /// <inheritdoc />
        public override global::G.AzureSpeechTranscriberSegmentationStrategy Read(
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
                        return global::G.AzureSpeechTranscriberSegmentationStrategyExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.AzureSpeechTranscriberSegmentationStrategy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.AzureSpeechTranscriberSegmentationStrategy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AzureSpeechTranscriberSegmentationStrategy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.AzureSpeechTranscriberSegmentationStrategyExtensions.ToValueString(value));
        }
    }
}
