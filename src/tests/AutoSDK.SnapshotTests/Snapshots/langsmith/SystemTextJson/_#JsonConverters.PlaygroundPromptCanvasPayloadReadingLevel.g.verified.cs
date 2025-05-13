﻿//HintName: JsonConverters.PlaygroundPromptCanvasPayloadReadingLevel.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PlaygroundPromptCanvasPayloadReadingLevelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PlaygroundPromptCanvasPayloadReadingLevel>
    {
        /// <inheritdoc />
        public override global::G.PlaygroundPromptCanvasPayloadReadingLevel Read(
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
                        return global::G.PlaygroundPromptCanvasPayloadReadingLevelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PlaygroundPromptCanvasPayloadReadingLevel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PlaygroundPromptCanvasPayloadReadingLevel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PlaygroundPromptCanvasPayloadReadingLevel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.PlaygroundPromptCanvasPayloadReadingLevelExtensions.ToValueString(value));
        }
    }
}
