//HintName: G.JsonConverters.PhoneNumberControllerRemoveResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PhoneNumberControllerRemoveResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PhoneNumberControllerRemoveResponse>
    {
        /// <inheritdoc />
        public override global::G.PhoneNumberControllerRemoveResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PhoneNumberControllerRemoveResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PhoneNumberControllerRemoveResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PhoneNumberControllerRemoveResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ByoPhoneNumber? byoPhoneNumber = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerRemoveResponseDiscriminatorProvider.ByoPhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ByoPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ByoPhoneNumber> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ByoPhoneNumber)}");
                byoPhoneNumber = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TwilioPhoneNumber? twilio = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerRemoveResponseDiscriminatorProvider.Twilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TwilioPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TwilioPhoneNumber> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TwilioPhoneNumber)}");
                twilio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.VonagePhoneNumber? vonage = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerRemoveResponseDiscriminatorProvider.Vonage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VonagePhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VonagePhoneNumber> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VonagePhoneNumber)}");
                vonage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.VapiPhoneNumber? vapi = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerRemoveResponseDiscriminatorProvider.Vapi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VapiPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VapiPhoneNumber> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.VapiPhoneNumber)}");
                vapi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TelnyxPhoneNumber? telnyx = default;
            if (discriminator?.Provider == global::G.PhoneNumberControllerRemoveResponseDiscriminatorProvider.Telnyx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TelnyxPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TelnyxPhoneNumber> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TelnyxPhoneNumber)}");
                telnyx = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.PhoneNumberControllerRemoveResponse(
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
            global::G.PhoneNumberControllerRemoveResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsByoPhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ByoPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ByoPhoneNumber?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ByoPhoneNumber).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ByoPhoneNumber!, typeInfo);
            }
            else if (value.IsTwilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TwilioPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TwilioPhoneNumber?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TwilioPhoneNumber).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio!, typeInfo);
            }
            else if (value.IsVonage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VonagePhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VonagePhoneNumber?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VonagePhoneNumber).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vonage!, typeInfo);
            }
            else if (value.IsVapi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.VapiPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.VapiPhoneNumber?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.VapiPhoneNumber).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vapi!, typeInfo);
            }
            else if (value.IsTelnyx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TelnyxPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TelnyxPhoneNumber?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TelnyxPhoneNumber).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Telnyx!, typeInfo);
            }
        }
    }
}