//HintName: G.JsonConverters.GetMcpServersByServerIdInstancesOrderDirectionNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetMcpServersByServerIdInstancesOrderDirectionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetMcpServersByServerIdInstancesOrderDirection?>
    {
        /// <inheritdoc />
        public override global::G.GetMcpServersByServerIdInstancesOrderDirection? Read(
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
                        return global::G.GetMcpServersByServerIdInstancesOrderDirectionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetMcpServersByServerIdInstancesOrderDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetMcpServersByServerIdInstancesOrderDirection?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetMcpServersByServerIdInstancesOrderDirection? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.GetMcpServersByServerIdInstancesOrderDirectionExtensions.ToValueString(value.Value));
            }
        }
    }
}
