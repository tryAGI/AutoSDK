//HintName: G.JsonConverters.ListExportRequestsV2ResponseItemChannelNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListExportRequestsV2ResponseItemChannelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ListExportRequestsV2ResponseItemChannel?>
    {
        /// <inheritdoc />
        public override global::G.ListExportRequestsV2ResponseItemChannel? Read(
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
                        return global::G.ListExportRequestsV2ResponseItemChannelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ListExportRequestsV2ResponseItemChannel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ListExportRequestsV2ResponseItemChannel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ListExportRequestsV2ResponseItemChannel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ListExportRequestsV2ResponseItemChannelExtensions.ToValueString(value.Value));
            }
        }
    }
}
