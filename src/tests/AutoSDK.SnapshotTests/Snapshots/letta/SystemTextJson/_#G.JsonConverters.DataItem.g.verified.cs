//HintName: G.JsonConverters.DataItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class DataItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.DataItem>
    {
        /// <inheritdoc />
        public override global::G.DataItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1? agent = default;
            if (discriminator?.Type == global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemDiscriminatorType.Agent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1)}");
                agent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.DataItem(
                discriminator?.Type,
                agent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.DataItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Agent!, typeInfo);
            }
        }
    }
}