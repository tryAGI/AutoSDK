//HintName: JsonConverters.ExtensionConfigurationLocation.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    public sealed class ExtensionConfigurationLocationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ExtensionConfigurationLocation>
    {
        public override global::G.ExtensionConfigurationLocation Read(
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
                        return global::G.ExtensionConfigurationLocationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return global::G.ExtensionConfigurationLocationExtensions.ToEnum(numValue);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ExtensionConfigurationLocation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.ExtensionConfigurationLocationExtensions.ToValueString(value));
        }
    }
}
