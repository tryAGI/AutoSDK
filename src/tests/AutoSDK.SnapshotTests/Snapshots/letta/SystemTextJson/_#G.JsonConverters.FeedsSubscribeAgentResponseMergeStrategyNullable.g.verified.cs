//HintName: G.JsonConverters.FeedsSubscribeAgentResponseMergeStrategyNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FeedsSubscribeAgentResponseMergeStrategyNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FeedsSubscribeAgentResponseMergeStrategy?>
    {
        /// <inheritdoc />
        public override global::G.FeedsSubscribeAgentResponseMergeStrategy? Read(
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
                        return global::G.FeedsSubscribeAgentResponseMergeStrategyExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.FeedsSubscribeAgentResponseMergeStrategy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.FeedsSubscribeAgentResponseMergeStrategy?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FeedsSubscribeAgentResponseMergeStrategy? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.FeedsSubscribeAgentResponseMergeStrategyExtensions.ToValueString(value.Value));
            }
        }
    }
}
