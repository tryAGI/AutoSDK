//HintName: JsonConverters.EndPredictionBodyStatus.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    public sealed class EndPredictionBodyStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EndPredictionBodyStatus>
    {
        public override global::G.EndPredictionBodyStatus Read(
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
                        return global::G.EndPredictionBodyStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return global::G.EndPredictionBodyStatusExtensions.ToEnum(numValue);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EndPredictionBodyStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.EndPredictionBodyStatusExtensions.ToValueString(value));
        }
    }
}
