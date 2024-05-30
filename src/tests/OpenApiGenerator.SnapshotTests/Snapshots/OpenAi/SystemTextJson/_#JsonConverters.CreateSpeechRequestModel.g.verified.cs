//HintName: JsonConverters.CreateSpeechRequestModel.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    public sealed class CreateSpeechRequestModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateSpeechRequestModel>
    {
        public override global::G.CreateSpeechRequestModel Read(
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
                        return global::G.CreateSpeechRequestModelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return global::G.CreateSpeechRequestModelExtensions.ToEnum(numValue);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateSpeechRequestModel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.CreateSpeechRequestModelExtensions.ToValueString(value));
        }
    }
}
