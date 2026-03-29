//HintName: G.JsonConverters.GetMcpServersByServerIdInstancesOrderBy.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetMcpServersByServerIdInstancesOrderByJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetMcpServersByServerIdInstancesOrderBy>
    {
        /// <inheritdoc />
        public override global::G.GetMcpServersByServerIdInstancesOrderBy Read(
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
                        return global::G.GetMcpServersByServerIdInstancesOrderByExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetMcpServersByServerIdInstancesOrderBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetMcpServersByServerIdInstancesOrderBy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetMcpServersByServerIdInstancesOrderBy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.GetMcpServersByServerIdInstancesOrderByExtensions.ToValueString(value));
        }
    }
}
