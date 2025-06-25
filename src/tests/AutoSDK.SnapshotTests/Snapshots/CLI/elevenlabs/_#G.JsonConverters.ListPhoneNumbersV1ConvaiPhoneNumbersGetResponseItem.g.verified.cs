//HintName: G.JsonConverters.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem>
    {
        /// <inheritdoc />
        public override global::G.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.GetPhoneNumberTwilioResponseModel? twilio = default;
            if (discriminator?.Provider == global::G.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider.Twilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetPhoneNumberTwilioResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetPhoneNumberTwilioResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetPhoneNumberTwilioResponseModel)}");
                twilio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetPhoneNumberSIPTrunkResponseModel? sipTrunk = default;
            if (discriminator?.Provider == global::G.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider.SipTrunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetPhoneNumberSIPTrunkResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetPhoneNumberSIPTrunkResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetPhoneNumberSIPTrunkResponseModel)}");
                sipTrunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem(
                discriminator?.Provider,
                twilio,
                sipTrunk
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTwilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetPhoneNumberTwilioResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetPhoneNumberTwilioResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetPhoneNumberTwilioResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeInfo);
            }
            else if (value.IsSipTrunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetPhoneNumberSIPTrunkResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetPhoneNumberSIPTrunkResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetPhoneNumberSIPTrunkResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipTrunk, typeInfo);
            }
        }
    }
}