//HintName: G.JsonConverters.GetMcpAppByAppKeyOrderDirection.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetMcpAppByAppKeyOrderDirectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetMcpAppByAppKeyOrderDirection>
    {
        /// <inheritdoc />
        public override global::G.GetMcpAppByAppKeyOrderDirection Read(
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
                        return global::G.GetMcpAppByAppKeyOrderDirectionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetMcpAppByAppKeyOrderDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetMcpAppByAppKeyOrderDirection);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetMcpAppByAppKeyOrderDirection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.GetMcpAppByAppKeyOrderDirectionExtensions.ToValueString(value));
        }
    }
}
