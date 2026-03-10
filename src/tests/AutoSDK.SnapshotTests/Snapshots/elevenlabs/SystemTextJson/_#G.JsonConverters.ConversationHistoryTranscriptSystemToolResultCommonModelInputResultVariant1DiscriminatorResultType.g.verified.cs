//HintName: G.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType>
    {
        /// <inheritdoc />
        public override global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType Read(
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
                        return global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeExtensions.ToValueString(value));
        }
    }
}
