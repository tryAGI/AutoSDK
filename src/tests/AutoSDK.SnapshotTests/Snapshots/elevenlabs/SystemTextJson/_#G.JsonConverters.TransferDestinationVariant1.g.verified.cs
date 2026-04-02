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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PhoneNumberTransferTransferDestinationVariant1Discriminator>(ref readerCopy, options);

            global::G.PhoneNumberTransferDestination? phone = default;
            if (discriminator?.Type == global::G.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.Phone)
            {
                phone = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PhoneNumberTransferDestination>(ref reader, options);
            }
            global::G.SIPUriTransferDestination? sipUri = default;
            if (discriminator?.Type == global::G.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.SipUri)
            {
                sipUri = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SIPUriTransferDestination>(ref reader, options);
            }
            global::G.PhoneNumberDynamicVariableTransferDestination? phoneDynamicVariable = default;
            if (discriminator?.Type == global::G.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.PhoneDynamicVariable)
            {
                phoneDynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PhoneNumberDynamicVariableTransferDestination>(ref reader, options);
            }
            global::G.SIPUriDynamicVariableTransferDestination? sipUriDynamicVariable = default;
            if (discriminator?.Type == global::G.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.SipUriDynamicVariable)
            {
                sipUriDynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize<global::G.SIPUriDynamicVariableTransferDestination>(ref reader, options);
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

            if (value.IsPhone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Phone, typeof(global::G.PhoneNumberTransferDestination), options);
            }
            else if (value.IsSipUri)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipUri, typeof(global::G.SIPUriTransferDestination), options);
            }
            else if (value.IsPhoneDynamicVariable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhoneDynamicVariable, typeof(global::G.PhoneNumberDynamicVariableTransferDestination), options);
            }
            else if (value.IsSipUriDynamicVariable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipUriDynamicVariable, typeof(global::G.SIPUriDynamicVariableTransferDestination), options);
            }
        }
    }
}