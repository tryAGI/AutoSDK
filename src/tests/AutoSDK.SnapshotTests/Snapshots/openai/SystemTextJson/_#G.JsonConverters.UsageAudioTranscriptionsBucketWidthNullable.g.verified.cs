﻿//HintName: G.JsonConverters.UsageAudioTranscriptionsBucketWidthNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UsageAudioTranscriptionsBucketWidthNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UsageAudioTranscriptionsBucketWidth?>
    {
        /// <inheritdoc />
        public override global::G.UsageAudioTranscriptionsBucketWidth? Read(
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
                        return global::G.UsageAudioTranscriptionsBucketWidthExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.UsageAudioTranscriptionsBucketWidth)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.UsageAudioTranscriptionsBucketWidth?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UsageAudioTranscriptionsBucketWidth? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.UsageAudioTranscriptionsBucketWidthExtensions.ToValueString(value.Value));
            }
        }
    }
}
