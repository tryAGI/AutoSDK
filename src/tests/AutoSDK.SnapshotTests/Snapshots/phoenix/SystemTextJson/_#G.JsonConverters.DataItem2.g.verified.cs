//HintName: G.JsonConverters.DataItem2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class DataItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.DataItem2>
    {
        /// <inheritdoc />
        public override global::G.DataItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetUsersResponseBodyDataItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetUsersResponseBodyDataItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GetUsersResponseBodyDataItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.LocalUser? local = default;
            if (discriminator?.AuthMethod == global::G.GetUsersResponseBodyDataItemDiscriminatorAuthMethod.Local)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalUser> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LocalUser)}");
                local = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.OAuth2User? oauth2 = default;
            if (discriminator?.AuthMethod == global::G.GetUsersResponseBodyDataItemDiscriminatorAuthMethod.Oauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OAuth2User), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OAuth2User> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OAuth2User)}");
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LDAPUser? ldap = default;
            if (discriminator?.AuthMethod == global::G.GetUsersResponseBodyDataItemDiscriminatorAuthMethod.Ldap)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LDAPUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LDAPUser> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LDAPUser)}");
                ldap = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.DataItem2(
                discriminator?.AuthMethod,
                local,

                oauth2,

                ldap
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.DataItem2 value,
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
        }
    }
}