//HintName: G.JsonConverters.Prompt2025VersionPromptBodyMessageToolCallType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class Prompt2025VersionPromptBodyMessageToolCallTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Prompt2025VersionPromptBodyMessageToolCallType>
    {
        /// <inheritdoc />
        public override global::G.Prompt2025VersionPromptBodyMessageToolCallType Read(
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
                        return global::G.Prompt2025VersionPromptBodyMessageToolCallTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.Prompt2025VersionPromptBodyMessageToolCallType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.Prompt2025VersionPromptBodyMessageToolCallType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Prompt2025VersionPromptBodyMessageToolCallType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.Prompt2025VersionPromptBodyMessageToolCallTypeExtensions.ToValueString(value));
        }
    }
}
