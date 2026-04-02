//HintName: G.JsonConverters.CustomSipHeadersItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CustomSipHeadersItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CustomSipHeadersItem>
    {
        /// <inheritdoc />
        public override global::G.CustomSipHeadersItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::G.PhoneNumberTransferCustomSipHeaderDiscriminator>(ref readerCopy, options);

            global::G.CustomSIPHeader? dynamic1 = default;
            if (discriminator?.Type == global::G.PhoneNumberTransferCustomSipHeaderDiscriminatorType.Dynamic)
            {
                dynamic1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CustomSIPHeader>(ref reader, options);
            }
            global::G.CustomSIPHeaderWithDynamicVariable? dynamic2 = default;
            if (discriminator?.Type == global::G.PhoneNumberTransferCustomSipHeaderDiscriminatorType.Dynamic)
            {
                dynamic2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CustomSIPHeaderWithDynamicVariable>(ref reader, options);
            }

            var __value = new global::G.CustomSipHeadersItem(
                discriminator?.Type,
                dynamic1,

                dynamic2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CustomSipHeadersItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsDynamic1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic1, typeof(global::G.CustomSIPHeader), options);
            }
            else if (value.IsDynamic2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic2, typeof(global::G.CustomSIPHeaderWithDynamicVariable), options);
            }
        }
    }
}