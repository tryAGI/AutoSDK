//HintName: G.JsonConverters.User.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class UserJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.User>
    {
        /// <inheritdoc />
        public override global::G.User Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateUserRequestBodyUserDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateUserRequestBodyUserDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateUserRequestBodyUserDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.LocalUserData? local = default;
            if (discriminator?.AuthMethod == global::G.CreateUserRequestBodyUserDiscriminatorAuthMethod.Local)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalUserData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalUserData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LocalUserData)}");
                local = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.OAuth2UserData? oauth2 = default;
            if (discriminator?.AuthMethod == global::G.CreateUserRequestBodyUserDiscriminatorAuthMethod.Oauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OAuth2UserData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OAuth2UserData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.OAuth2UserData)}");
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LDAPUserData? ldap = default;
            if (discriminator?.AuthMethod == global::G.CreateUserRequestBodyUserDiscriminatorAuthMethod.Ldap)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LDAPUserData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LDAPUserData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LDAPUserData)}");
                ldap = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.User(
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
            global::G.User value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLocal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalUserData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalUserData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalUserData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Local!, typeInfo);
            }
            else if (value.IsOauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OAuth2UserData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OAuth2UserData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OAuth2UserData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2!, typeInfo);
            }
            else if (value.IsLdap)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LDAPUserData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LDAPUserData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LDAPUserData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ldap!, typeInfo);
            }
        }
    }
}