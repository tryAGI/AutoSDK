//HintName: JsonConverters.ExtensionConfigurationSegmentSegment.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    public sealed class ExtensionConfigurationSegmentSegmentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ExtensionConfigurationSegmentSegment>
    {
        public override global::G.ExtensionConfigurationSegmentSegment Read(
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
                        return global::G.ExtensionConfigurationSegmentSegmentExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return global::G.ExtensionConfigurationSegmentSegmentExtensions.ToEnum(numValue);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ExtensionConfigurationSegmentSegment value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.ExtensionConfigurationSegmentSegmentExtensions.ToValueString(value));
        }
    }
}
