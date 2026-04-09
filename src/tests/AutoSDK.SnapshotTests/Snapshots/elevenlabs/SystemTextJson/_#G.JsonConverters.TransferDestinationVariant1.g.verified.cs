//HintName: G.JsonConverters.TransferDestinationVariant1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TransferDestinationVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TransferDestinationVariant1>
    {
        /// <inheritdoc />
        public override global::G.TransferDestinationVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PhoneNumberTransferTransferDestinationVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PhoneNumberTransferTransferDestinationVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PhoneNumberTransferTransferDestinationVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.PhoneNumberTransferDestination? phone = default;
            if (discriminator?.Type == global::G.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.Phone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PhoneNumberTransferDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PhoneNumberTransferDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PhoneNumberTransferDestination)}");
                phone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SIPUriTransferDestination? sipUri = default;
            if (discriminator?.Type == global::G.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.SipUri)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SIPUriTransferDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SIPUriTransferDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SIPUriTransferDestination)}");
                sipUri = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PhoneNumberDynamicVariableTransferDestination? phoneDynamicVariable = default;
            if (discriminator?.Type == global::G.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.PhoneDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PhoneNumberDynamicVariableTransferDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PhoneNumberDynamicVariableTransferDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PhoneNumberDynamicVariableTransferDestination)}");
                phoneDynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SIPUriDynamicVariableTransferDestination? sipUriDynamicVariable = default;
            if (discriminator?.Type == global::G.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.SipUriDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SIPUriDynamicVariableTransferDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SIPUriDynamicVariableTransferDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SIPUriDynamicVariableTransferDestination)}");
                sipUriDynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.TransferDestinationVariant1(
                discriminator?.Type,
                phone,

                sipUri,

                phoneDynamicVariable,

                sipUriDynamicVariable
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TransferDestinationVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPhone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PhoneNumberTransferDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PhoneNumberTransferDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PhoneNumberTransferDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Phone!, typeInfo);
            }
            else if (value.IsSipUri)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SIPUriTransferDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SIPUriTransferDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SIPUriTransferDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipUri!, typeInfo);
            }
            else if (value.IsPhoneDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PhoneNumberDynamicVariableTransferDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PhoneNumberDynamicVariableTransferDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PhoneNumberDynamicVariableTransferDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhoneDynamicVariable!, typeInfo);
            }
            else if (value.IsSipUriDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SIPUriDynamicVariableTransferDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SIPUriDynamicVariableTransferDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SIPUriDynamicVariableTransferDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipUriDynamicVariable!, typeInfo);
            }
        }
    }
}