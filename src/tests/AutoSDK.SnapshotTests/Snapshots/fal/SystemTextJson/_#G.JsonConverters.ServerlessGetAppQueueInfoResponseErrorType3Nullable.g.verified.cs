//HintName: G.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType3Nullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ServerlessGetAppQueueInfoResponseErrorType3NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ServerlessGetAppQueueInfoResponseErrorType3?>
    {
        /// <inheritdoc />
        public override global::G.ServerlessGetAppQueueInfoResponseErrorType3? Read(
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
                        return global::G.ServerlessGetAppQueueInfoResponseErrorType3Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ServerlessGetAppQueueInfoResponseErrorType3)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ServerlessGetAppQueueInfoResponseErrorType3?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ServerlessGetAppQueueInfoResponseErrorType3? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ServerlessGetAppQueueInfoResponseErrorType3Extensions.ToValueString(value.Value));
            }
        }
    }
}
