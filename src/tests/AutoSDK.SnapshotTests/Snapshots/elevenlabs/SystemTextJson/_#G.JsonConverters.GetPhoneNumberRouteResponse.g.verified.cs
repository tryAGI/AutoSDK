//HintName: G.JsonConverters.GetPhoneNumberRouteResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GetPhoneNumberRouteResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetPhoneNumberRouteResponse>
    {
        /// <inheritdoc />
        public override global::G.GetPhoneNumberRouteResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetPhoneNumberRouteResponseDiscriminator>(ref readerCopy, options);

            global::G.GetPhoneNumberTwilioResponseModel? twilio = default;
            if (discriminator?.Provider == global::G.GetPhoneNumberRouteResponseDiscriminatorProvider.Twilio)
            {
                twilio = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetPhoneNumberTwilioResponseModel>(ref reader, options);
            }
            global::G.GetPhoneNumberSIPTrunkResponseModel? sipTrunk = default;
            if (discriminator?.Provider == global::G.GetPhoneNumberRouteResponseDiscriminatorProvider.SipTrunk)
            {
                sipTrunk = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetPhoneNumberSIPTrunkResponseModel>(ref reader, options);
            }

            var __value = new global::G.GetPhoneNumberRouteResponse(
                discriminator?.Provider,
                twilio,

                sipTrunk
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetPhoneNumberRouteResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTwilio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeof(global::G.GetPhoneNumberTwilioResponseModel), options);
            }
            else if (value.IsSipTrunk)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipTrunk, typeof(global::G.GetPhoneNumberSIPTrunkResponseModel), options);
            }
        }
    }
}