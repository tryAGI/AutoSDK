//HintName: JsonConverters.MessageContentImageUrlObjectImageUrlDetail.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    public sealed class MessageContentImageUrlObjectImageUrlDetailJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessageContentImageUrlObjectImageUrlDetail>
    {
        public override global::G.MessageContentImageUrlObjectImageUrlDetail Read(
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
                        return global::G.MessageContentImageUrlObjectImageUrlDetailExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return global::G.MessageContentImageUrlObjectImageUrlDetailExtensions.ToEnum(numValue);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessageContentImageUrlObjectImageUrlDetail value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.MessageContentImageUrlObjectImageUrlDetailExtensions.ToValueString(value));
        }
    }
}
