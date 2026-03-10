//HintName: G.JsonConverters.MCPToolConfigInputInputOverridesDiscriminatorSource.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MCPToolConfigInputInputOverridesDiscriminatorSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MCPToolConfigInputInputOverridesDiscriminatorSource>
    {
        /// <inheritdoc />
        public override global::G.MCPToolConfigInputInputOverridesDiscriminatorSource Read(
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
                        return global::G.MCPToolConfigInputInputOverridesDiscriminatorSourceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.MCPToolConfigInputInputOverridesDiscriminatorSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.MCPToolConfigInputInputOverridesDiscriminatorSource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MCPToolConfigInputInputOverridesDiscriminatorSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.MCPToolConfigInputInputOverridesDiscriminatorSourceExtensions.ToValueString(value));
        }
    }
}
