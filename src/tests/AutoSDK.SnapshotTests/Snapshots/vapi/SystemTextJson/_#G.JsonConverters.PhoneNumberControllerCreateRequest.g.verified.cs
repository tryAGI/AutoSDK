//HintName: G.JsonConverters.PhoneNumberControllerCreateRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PhoneNumberControllerCreateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PhoneNumberControllerCreateRequest>
    {
        /// <inheritdoc />
        public override global::G.PhoneNumberControllerCreateRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PhoneNumberControllerCreateRequestDiscriminator>(ref readerCopy, options);

            global::G.CreateByoPhoneNumberDTO? byoPhoneNumber = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerCreateRequestDiscriminatorProvider.ByoPhoneNumber)
            {
                byoPhoneNumber = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateByoPhoneNumberDTO>(ref reader, options);
            }
            global::G.CreateTwilioPhoneNumberDTO? twilio = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerCreateRequestDiscriminatorProvider.Twilio)
            {
                twilio = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateTwilioPhoneNumberDTO>(ref reader, options);
            }
            global::G.CreateVonagePhoneNumberDTO? vonage = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerCreateRequestDiscriminatorProvider.Vonage)
            {
                vonage = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateVonagePhoneNumberDTO>(ref reader, options);
            }
            global::G.CreateVapiPhoneNumberDTO? vapi = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerCreateRequestDiscriminatorProvider.Vapi)
            {
                vapi = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateVapiPhoneNumberDTO>(ref reader, options);
            }
            global::G.CreateTelnyxPhoneNumberDTO? telnyx = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerCreateRequestDiscriminatorProvider.Telnyx)
            {
                telnyx = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateTelnyxPhoneNumberDTO>(ref reader, options);
            }

            var __value = new global::G.PhoneNumberControllerCreateRequest(
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
            global::G.PhoneNumberControllerCreateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsByoPhoneNumber)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ByoPhoneNumber, typeof(global::G.CreateByoPhoneNumberDTO), options);
            }
            else if (value.IsTwilio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeof(global::G.CreateTwilioPhoneNumberDTO), options);
            }
            else if (value.IsVonage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vonage, typeof(global::G.CreateVonagePhoneNumberDTO), options);
            }
            else if (value.IsVapi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vapi, typeof(global::G.CreateVapiPhoneNumberDTO), options);
            }
            else if (value.IsTelnyx)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Telnyx, typeof(global::G.CreateTelnyxPhoneNumberDTO), options);
            }
        }
    }
}