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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationHistoryMetadataCommonModelPhoneCallVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationHistoryMetadataCommonModelPhoneCallVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConversationHistoryMetadataCommonModelPhoneCallVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ConversationHistoryTwilioPhoneCallModel? twilio = default;
            if (discriminator?.Type == global::G.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType.Twilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationHistoryTwilioPhoneCallModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationHistoryTwilioPhoneCallModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConversationHistoryTwilioPhoneCallModel)}");
                twilio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ConversationHistorySIPTrunkingPhoneCallModel? sipTrunking = default;
            if (discriminator?.Type == global::G.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType.SipTrunking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationHistorySIPTrunkingPhoneCallModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationHistorySIPTrunkingPhoneCallModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ConversationHistorySIPTrunkingPhoneCallModel)}");
                sipTrunking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.PhoneCallVariant1(
                discriminator?.Type,
                twilio,
                sipTrunking
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PhoneCallVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTwilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationHistoryTwilioPhoneCallModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationHistoryTwilioPhoneCallModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConversationHistoryTwilioPhoneCallModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeInfo);
            }
            else if (value.IsSipTrunking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ConversationHistorySIPTrunkingPhoneCallModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ConversationHistorySIPTrunkingPhoneCallModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ConversationHistorySIPTrunkingPhoneCallModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipTrunking, typeInfo);
            }
        }
    }
}