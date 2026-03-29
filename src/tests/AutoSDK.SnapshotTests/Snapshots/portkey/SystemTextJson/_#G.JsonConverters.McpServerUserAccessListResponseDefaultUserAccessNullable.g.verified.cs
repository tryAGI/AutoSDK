//HintName: G.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class McpServerUserAccessListResponseDefaultUserAccessNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.McpServerUserAccessListResponseDefaultUserAccess?>
    {
        /// <inheritdoc />
        public override global::G.McpServerUserAccessListResponseDefaultUserAccess? Read(
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
                        return global::G.McpServerUserAccessListResponseDefaultUserAccessExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.McpServerUserAccessListResponseDefaultUserAccess)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.McpServerUserAccessListResponseDefaultUserAccess?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.McpServerUserAccessListResponseDefaultUserAccess? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.McpServerUserAccessListResponseDefaultUserAccessExtensions.ToValueString(value.Value));
            }
        }
    }
}
