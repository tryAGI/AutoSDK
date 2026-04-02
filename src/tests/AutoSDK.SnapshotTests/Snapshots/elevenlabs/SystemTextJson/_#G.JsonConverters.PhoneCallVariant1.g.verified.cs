//HintName: G.JsonConverters.PhoneCallVariant1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PhoneCallVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PhoneCallVariant1>
    {
        /// <inheritdoc />
        public override global::G.PhoneCallVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConversationHistoryMetadataCommonModelPhoneCallVariant1Discriminator>(ref readerCopy, options);

            global::G.ConversationHistoryTwilioPhoneCallModel? twilio = default;
            if (discriminator?.Type == global::G.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType.Twilio)
            {
                twilio = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConversationHistoryTwilioPhoneCallModel>(ref reader, options);
            }
            global::G.ConversationHistorySIPTrunkingPhoneCallModel? sipTrunking = default;
            if (discriminator?.Type == global::G.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType.SipTrunking)
            {
                sipTrunking = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ConversationHistorySIPTrunkingPhoneCallModel>(ref reader, options);
            }

            var __value = new global::G.PhoneCallVariant1(
                discriminator?.Type,
                twilio,

                sipTrunking
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PhoneCallVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTwilio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeof(global::G.ConversationHistoryTwilioPhoneCallModel), options);
            }
            else if (value.IsSipTrunking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipTrunking, typeof(global::G.ConversationHistorySIPTrunkingPhoneCallModel), options);
            }
        }
    }
}