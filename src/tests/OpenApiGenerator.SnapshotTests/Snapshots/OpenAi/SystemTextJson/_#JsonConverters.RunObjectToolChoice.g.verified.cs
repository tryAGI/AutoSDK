//HintName: JsonConverters.RunObjectToolChoice.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    public sealed class RunObjectToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RunObjectToolChoice>
    {
        public override global::G.RunObjectToolChoice Read(
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
                        return global::G.RunObjectToolChoiceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return global::G.RunObjectToolChoiceExtensions.ToEnum(numValue);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RunObjectToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.RunObjectToolChoiceExtensions.ToValueString(value));
        }
    }
}
