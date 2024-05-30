//HintName: JsonConverters.CreateImageEditRequestSize.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    public sealed class CreateImageEditRequestSizeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateImageEditRequestSize>
    {
        public override global::G.CreateImageEditRequestSize Read(
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
                        return global::G.CreateImageEditRequestSizeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return global::G.CreateImageEditRequestSizeExtensions.ToEnum(numValue);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateImageEditRequestSize value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.CreateImageEditRequestSizeExtensions.ToValueString(value));
        }
    }
}
