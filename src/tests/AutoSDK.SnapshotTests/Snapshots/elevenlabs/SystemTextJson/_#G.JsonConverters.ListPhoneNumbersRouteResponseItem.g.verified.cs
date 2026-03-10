//HintName: G.JsonConverters.ListPhoneNumbersRouteResponseItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ListPhoneNumbersRouteResponseItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ListPhoneNumbersRouteResponseItem>
    {
        /// <inheritdoc />
        public override global::G.ListPhoneNumbersRouteResponseItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListPhoneNumbersRouteResponseItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListPhoneNumbersRouteResponseItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ListPhoneNumbersRouteResponseItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.GetPhoneNumberTwilioResponseModel? twilio = default;
            if (discriminator?.Provider == global::G.ListPhoneNumbersRouteResponseItemDiscriminatorProvider.Twilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetPhoneNumberTwilioResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetPhoneNumberTwilioResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetPhoneNumberTwilioResponseModel)}");
                twilio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GetPhoneNumberSIPTrunkResponseModel? sipTrunk = default;
            if (discriminator?.Provider == global::G.ListPhoneNumbersRouteResponseItemDiscriminatorProvider.SipTrunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetPhoneNumberSIPTrunkResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetPhoneNumberSIPTrunkResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetPhoneNumberSIPTrunkResponseModel)}");
                sipTrunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ListPhoneNumbersRouteResponseItem(
                discriminator?.Provider,
                twilio,

                sipTrunk
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ListPhoneNumbersRouteResponseItem value,
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