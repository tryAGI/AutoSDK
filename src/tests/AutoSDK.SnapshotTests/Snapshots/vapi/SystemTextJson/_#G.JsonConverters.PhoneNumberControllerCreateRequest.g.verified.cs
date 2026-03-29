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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PhoneNumberControllerCreateRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PhoneNumberControllerCreateRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PhoneNumberControllerCreateRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateByoPhoneNumberDTO? byoPhoneNumber = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerCreateRequestDiscriminatorProvider.ByoPhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateByoPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateByoPhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateByoPhoneNumberDTO)}");
                byoPhoneNumber = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateTwilioPhoneNumberDTO? twilio = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerCreateRequestDiscriminatorProvider.Twilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTwilioPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTwilioPhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTwilioPhoneNumberDTO)}");
                twilio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateVonagePhoneNumberDTO? vonage = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerCreateRequestDiscriminatorProvider.Vonage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVonagePhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVonagePhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateVonagePhoneNumberDTO)}");
                vonage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateVapiPhoneNumberDTO? vapi = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerCreateRequestDiscriminatorProvider.Vapi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVapiPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVapiPhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateVapiPhoneNumberDTO)}");
                vapi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateTelnyxPhoneNumberDTO? telnyx = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerCreateRequestDiscriminatorProvider.Telnyx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTelnyxPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTelnyxPhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTelnyxPhoneNumberDTO)}");
                telnyx = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsByoPhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateByoPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateByoPhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateByoPhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ByoPhoneNumber, typeInfo);
            }
            else if (value.IsTwilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTwilioPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTwilioPhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTwilioPhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeInfo);
            }
            else if (value.IsVonage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVonagePhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVonagePhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateVonagePhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vonage, typeInfo);
            }
            else if (value.IsVapi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVapiPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVapiPhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateVapiPhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vapi, typeInfo);
            }
            else if (value.IsTelnyx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTelnyxPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTelnyxPhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTelnyxPhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Telnyx, typeInfo);
            }
        }
    }
}