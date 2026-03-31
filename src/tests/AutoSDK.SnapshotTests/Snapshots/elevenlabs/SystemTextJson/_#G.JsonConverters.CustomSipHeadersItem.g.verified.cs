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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PhoneNumberTransferCustomSipHeaderDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PhoneNumberTransferCustomSipHeaderDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PhoneNumberTransferCustomSipHeaderDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CustomSIPHeader? dynamic1 = default;
            if (discriminator?.Type == global::G.PhoneNumberTransferCustomSipHeaderDiscriminatorType.Dynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CustomSIPHeader), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CustomSIPHeader> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CustomSIPHeader)}");
                dynamic1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CustomSIPHeaderWithDynamicVariable? dynamic2 = default;
            if (discriminator?.Type == global::G.PhoneNumberTransferCustomSipHeaderDiscriminatorType.Dynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CustomSIPHeaderWithDynamicVariable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CustomSIPHeaderWithDynamicVariable> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CustomSIPHeaderWithDynamicVariable)}");
                dynamic2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDynamic1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CustomSIPHeader), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CustomSIPHeader?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CustomSIPHeader).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic1!, typeInfo);
            }
            else if (value.IsDynamic2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CustomSIPHeaderWithDynamicVariable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CustomSIPHeaderWithDynamicVariable?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CustomSIPHeaderWithDynamicVariable).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic2!, typeInfo);
            }
        }
    }
}