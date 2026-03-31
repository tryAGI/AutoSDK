//HintName: G.JsonConverters.Data5.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Data5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Data5>
    {
        /// <inheritdoc />
        public override global::G.Data5 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetViewerResponseBodyDataDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetViewerResponseBodyDataDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetViewerResponseBodyDataDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.LocalUser? local = default;
            if (discriminator?.AuthMethod == global::G.GetViewerResponseBodyDataDiscriminatorAuthMethod.Local)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalUser> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LocalUser)}");
                local = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.OAuth2User? oauth2 = default;
            if (discriminator?.AuthMethod == global::G.GetViewerResponseBodyDataDiscriminatorAuthMethod.Oauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OAuth2User), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OAuth2User> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OAuth2User)}");
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LDAPUser? ldap = default;
            if (discriminator?.AuthMethod == global::G.GetViewerResponseBodyDataDiscriminatorAuthMethod.Ldap)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LDAPUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LDAPUser> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LDAPUser)}");
                ldap = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AnonymousUser? anonymous = default;
            if (discriminator?.AuthMethod == global::G.GetViewerResponseBodyDataDiscriminatorAuthMethod.Anonymous)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AnonymousUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AnonymousUser> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AnonymousUser)}");
                anonymous = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Data5(
                discriminator?.AuthMethod,
                local,

                oauth2,

                ldap,

                anonymous
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Data5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLocal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalUser?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalUser).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Local!, typeInfo);
            }
            else if (value.IsOauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OAuth2User), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OAuth2User?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OAuth2User).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2!, typeInfo);
            }
            else if (value.IsLdap)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LDAPUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LDAPUser?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LDAPUser).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ldap!, typeInfo);
            }
            else if (value.IsAnonymous)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AnonymousUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AnonymousUser?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AnonymousUser).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anonymous!, typeInfo);
            }
        }
    }
}