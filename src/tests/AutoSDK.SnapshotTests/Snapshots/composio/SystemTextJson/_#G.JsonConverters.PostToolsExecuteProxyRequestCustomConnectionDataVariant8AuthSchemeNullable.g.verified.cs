//HintName: G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthSchemeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthSchemeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthScheme?>
    {
        /// <inheritdoc />
        public override global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthScheme? Read(
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
                        return global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthSchemeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthScheme)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthScheme?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthScheme? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthSchemeExtensions.ToValueString(value.Value));
            }
        }
    }
}
