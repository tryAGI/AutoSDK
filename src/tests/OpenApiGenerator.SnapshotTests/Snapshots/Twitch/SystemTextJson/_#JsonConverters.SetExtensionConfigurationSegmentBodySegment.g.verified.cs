//HintName: JsonConverters.SetExtensionConfigurationSegmentBodySegment.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    public sealed class SetExtensionConfigurationSegmentBodySegmentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SetExtensionConfigurationSegmentBodySegment>
    {
        public override global::G.SetExtensionConfigurationSegmentBodySegment Read(
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
                        return global::G.SetExtensionConfigurationSegmentBodySegmentExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return global::G.SetExtensionConfigurationSegmentBodySegmentExtensions.ToEnum(numValue);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SetExtensionConfigurationSegmentBodySegment value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.SetExtensionConfigurationSegmentBodySegmentExtensions.ToValueString(value));
        }
    }
}
