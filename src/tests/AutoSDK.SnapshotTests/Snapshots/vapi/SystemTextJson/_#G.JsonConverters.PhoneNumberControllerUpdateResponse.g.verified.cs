//HintName: G.JsonConverters.PhoneNumberControllerUpdateResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PhoneNumberControllerUpdateResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PhoneNumberControllerUpdateResponse>
    {
        /// <inheritdoc />
        public override global::G.PhoneNumberControllerUpdateResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PhoneNumberControllerUpdateResponseDiscriminator>(ref readerCopy, options);

            global::G.ByoPhoneNumber? byoPhoneNumber = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerUpdateResponseDiscriminatorProvider.ByoPhoneNumber)
            {
                byoPhoneNumber = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ByoPhoneNumber>(ref reader, options);
            }
            global::G.TwilioPhoneNumber? twilio = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerUpdateResponseDiscriminatorProvider.Twilio)
            {
                twilio = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TwilioPhoneNumber>(ref reader, options);
            }
            global::G.VonagePhoneNumber? vonage = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerUpdateResponseDiscriminatorProvider.Vonage)
            {
                vonage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.VonagePhoneNumber>(ref reader, options);
            }
            global::G.VapiPhoneNumber? vapi = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerUpdateResponseDiscriminatorProvider.Vapi)
            {
                vapi = global::System.Text.Json.JsonSerializer.Deserialize<global::G.VapiPhoneNumber>(ref reader, options);
            }
            global::G.TelnyxPhoneNumber? telnyx = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerUpdateResponseDiscriminatorProvider.Telnyx)
            {
                telnyx = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TelnyxPhoneNumber>(ref reader, options);
            }

            var __value = new global::G.PhoneNumberControllerUpdateResponse(
                discriminator?.Provider,
                byoPhoneNumber,

                twilio,

                vonage,

                vapi,

                telnyx
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PhoneNumberControllerUpdateResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsByoPhoneNumber)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ByoPhoneNumber, typeof(global::G.ByoPhoneNumber), options);
            }
            else if (value.IsTwilio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeof(global::G.TwilioPhoneNumber), options);
            }
            else if (value.IsVonage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vonage, typeof(global::G.VonagePhoneNumber), options);
            }
            else if (value.IsVapi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vapi, typeof(global::G.VapiPhoneNumber), options);
            }
            else if (value.IsTelnyx)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Telnyx, typeof(global::G.TelnyxPhoneNumber), options);
            }
        }
    }
}