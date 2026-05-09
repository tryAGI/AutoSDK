//HintName: G.JsonConverters.PolicyItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class PolicyItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PolicyItem>
    {
        /// <inheritdoc />
        public override global::G.PolicyItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1? agent = default;
            if (discriminator?.Type == global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminatorType.Agent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1)}");
                agent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.PolicyItem(
                discriminator?.Type,
                agent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PolicyItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Agent!, typeInfo);
            }
        }
    }
}