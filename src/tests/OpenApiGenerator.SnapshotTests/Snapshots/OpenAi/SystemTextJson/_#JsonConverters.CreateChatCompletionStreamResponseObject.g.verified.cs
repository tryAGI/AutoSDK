//HintName: JsonConverters.CreateChatCompletionStreamResponseObject.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    public sealed class CreateChatCompletionStreamResponseObjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateChatCompletionStreamResponseObject>
    {
        public override global::G.CreateChatCompletionStreamResponseObject Read(
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
                        return global::G.CreateChatCompletionStreamResponseObjectExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return global::G.CreateChatCompletionStreamResponseObjectExtensions.ToEnum(numValue);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateChatCompletionStreamResponseObject value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.CreateChatCompletionStreamResponseObjectExtensions.ToValueString(value));
        }
    }
}
