//HintName: G.JsonConverters.PhoneNumberControllerUpdateRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PhoneNumberControllerUpdateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PhoneNumberControllerUpdateRequest>
    {
        /// <inheritdoc />
        public override global::G.PhoneNumberControllerUpdateRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PhoneNumberControllerUpdateRequestDiscriminator>(ref readerCopy, options);

            global::G.UpdateByoPhoneNumberDTO? byoPhoneNumber = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider.ByoPhoneNumber)
            {
                byoPhoneNumber = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateByoPhoneNumberDTO>(ref reader, options);
            }
            global::G.UpdateTwilioPhoneNumberDTO? twilio = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider.Twilio)
            {
                twilio = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateTwilioPhoneNumberDTO>(ref reader, options);
            }
            global::G.UpdateVonagePhoneNumberDTO? vonage = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider.Vonage)
            {
                vonage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateVonagePhoneNumberDTO>(ref reader, options);
            }
            global::G.UpdateVapiPhoneNumberDTO? vapi = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider.Vapi)
            {
                vapi = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateVapiPhoneNumberDTO>(ref reader, options);
            }
            global::G.UpdateTelnyxPhoneNumberDTO? telnyx = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider.Telnyx)
            {
                telnyx = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateTelnyxPhoneNumberDTO>(ref reader, options);
            }

            var __value = new global::G.PhoneNumberControllerUpdateRequest(
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
            global::G.PhoneNumberControllerUpdateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsByoPhoneNumber)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ByoPhoneNumber, typeof(global::G.UpdateByoPhoneNumberDTO), options);
            }
            else if (value.IsTwilio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeof(global::G.UpdateTwilioPhoneNumberDTO), options);
            }
            else if (value.IsVonage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vonage, typeof(global::G.UpdateVonagePhoneNumberDTO), options);
            }
            else if (value.IsVapi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vapi, typeof(global::G.UpdateVapiPhoneNumberDTO), options);
            }
            else if (value.IsTelnyx)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Telnyx, typeof(global::G.UpdateTelnyxPhoneNumberDTO), options);
            }
        }
    }
}