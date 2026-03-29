//HintName: G.JsonConverters.TransferOptionAgenticWarmTransferType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TransferOptionAgenticWarmTransferTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TransferOptionAgenticWarmTransferType>
    {
        /// <inheritdoc />
        public override global::G.TransferOptionAgenticWarmTransferType Read(
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
                        return global::G.TransferOptionAgenticWarmTransferTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.TransferOptionAgenticWarmTransferType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.TransferOptionAgenticWarmTransferType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TransferOptionAgenticWarmTransferType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.TransferOptionAgenticWarmTransferTypeExtensions.ToValueString(value));
        }
    }
}
