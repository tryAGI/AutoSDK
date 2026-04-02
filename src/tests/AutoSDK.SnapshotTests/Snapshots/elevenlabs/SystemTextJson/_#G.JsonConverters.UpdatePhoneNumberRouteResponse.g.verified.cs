//HintName: G.JsonConverters.UpdatePhoneNumberRouteResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class UpdatePhoneNumberRouteResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UpdatePhoneNumberRouteResponse>
    {
        /// <inheritdoc />
        public override global::G.UpdatePhoneNumberRouteResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdatePhoneNumberRouteResponseDiscriminator>(ref readerCopy, options);

            global::G.GetPhoneNumberTwilioResponseModel? twilio = default;
            if (discriminator?.Provider == global::G.UpdatePhoneNumberRouteResponseDiscriminatorProvider.Twilio)
            {
                twilio = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetPhoneNumberTwilioResponseModel>(ref reader, options);
            }
            global::G.GetPhoneNumberSIPTrunkResponseModel? sipTrunk = default;
            if (discriminator?.Provider == global::G.UpdatePhoneNumberRouteResponseDiscriminatorProvider.SipTrunk)
            {
                sipTrunk = global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetPhoneNumberSIPTrunkResponseModel>(ref reader, options);
            }

            var __value = new global::G.UpdatePhoneNumberRouteResponse(
                discriminator?.Provider,
                twilio,

                sipTrunk
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UpdatePhoneNumberRouteResponse value,
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