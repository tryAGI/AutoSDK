//HintName: G.JsonConverters.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType>
    {
        /// <inheritdoc />
        public override global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeExtensions.ToValueString(value));
        }
    }
}
