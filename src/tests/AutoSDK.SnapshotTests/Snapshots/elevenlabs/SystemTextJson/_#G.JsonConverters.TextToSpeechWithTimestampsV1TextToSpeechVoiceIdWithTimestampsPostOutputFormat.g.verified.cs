﻿//HintName: G.JsonConverters.TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostOutputFormat.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostOutputFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostOutputFormat>
    {
        /// <inheritdoc />
        public override global::G.TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostOutputFormat Read(
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
                        return global::G.TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostOutputFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostOutputFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostOutputFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostOutputFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostOutputFormatExtensions.ToValueString(value));
        }
    }
}
