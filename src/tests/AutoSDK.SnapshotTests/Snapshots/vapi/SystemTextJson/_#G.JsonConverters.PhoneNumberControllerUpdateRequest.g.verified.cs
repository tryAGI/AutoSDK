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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PhoneNumberControllerUpdateRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PhoneNumberControllerUpdateRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PhoneNumberControllerUpdateRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.UpdateByoPhoneNumberDTO? byoPhoneNumber = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider.ByoPhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateByoPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateByoPhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateByoPhoneNumberDTO)}");
                byoPhoneNumber = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateTwilioPhoneNumberDTO? twilio = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider.Twilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateTwilioPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateTwilioPhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateTwilioPhoneNumberDTO)}");
                twilio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateVonagePhoneNumberDTO? vonage = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider.Vonage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateVonagePhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateVonagePhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateVonagePhoneNumberDTO)}");
                vonage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateVapiPhoneNumberDTO? vapi = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider.Vapi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateVapiPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateVapiPhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateVapiPhoneNumberDTO)}");
                vapi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UpdateTelnyxPhoneNumberDTO? telnyx = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider.Telnyx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateTelnyxPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateTelnyxPhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateTelnyxPhoneNumberDTO)}");
                telnyx = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsByoPhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateByoPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateByoPhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateByoPhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ByoPhoneNumber, typeInfo);
            }
            else if (value.IsTwilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateTwilioPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateTwilioPhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateTwilioPhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeInfo);
            }
            else if (value.IsVonage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateVonagePhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateVonagePhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateVonagePhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vonage, typeInfo);
            }
            else if (value.IsVapi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateVapiPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateVapiPhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateVapiPhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vapi, typeInfo);
            }
            else if (value.IsTelnyx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateTelnyxPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateTelnyxPhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UpdateTelnyxPhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Telnyx, typeInfo);
            }
        }
    }
}