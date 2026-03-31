//HintName: G.JsonConverters.CreateVideoStreamRequestScriptTextProviderElevenLabsAccessNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateVideoStreamRequestScriptTextProviderElevenLabsAccessNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess?>
    {
        /// <inheritdoc />
        public override global::G.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess? Read(
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
                        return global::G.CreateVideoStreamRequestScriptTextProviderElevenLabsAccessExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateVideoStreamRequestScriptTextProviderElevenLabsAccess? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CreateVideoStreamRequestScriptTextProviderElevenLabsAccessExtensions.ToValueString(value.Value));
            }
        }
    }
}
