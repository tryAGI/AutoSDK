//HintName: G.JsonConverters.AuthConfig.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AuthConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AuthConfig>
    {
        /// <inheritdoc />
        public override global::G.AuthConfig Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("aws_access_key_id")) __score0++;
            if (__jsonProps.Contains("aws_auth_type")) __score0++;
            if (__jsonProps.Contains("aws_region")) __score0++;
            if (__jsonProps.Contains("aws_secret_access_key")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("aws_auth_type")) __score1++;
            if (__jsonProps.Contains("aws_external_id")) __score1++;
            if (__jsonProps.Contains("aws_region")) __score1++;
            if (__jsonProps.Contains("aws_role_arn")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("aws_auth_type")) __score2++;
            if (__jsonProps.Contains("aws_region")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("azure_auth_mode")) __score3++;
            if (__jsonProps.Contains("azure_entra_client_id")) __score3++;
            if (__jsonProps.Contains("azure_entra_client_secret")) __score3++;
            if (__jsonProps.Contains("azure_entra_tenant_id")) __score3++;
            if (__jsonProps.Contains("azure_vault_url")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("azure_auth_mode")) __score4++;
            if (__jsonProps.Contains("azure_managed_client_id")) __score4++;
            if (__jsonProps.Contains("azure_vault_url")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("azure_auth_mode")) __score5++;
            if (__jsonProps.Contains("azure_vault_url")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("vault_addr")) __score6++;
            if (__jsonProps.Contains("vault_auth_type")) __score6++;
            if (__jsonProps.Contains("vault_namespace")) __score6++;
            if (__jsonProps.Contains("vault_token")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("vault_addr")) __score7++;
            if (__jsonProps.Contains("vault_auth_type")) __score7++;
            if (__jsonProps.Contains("vault_namespace")) __score7++;
            if (__jsonProps.Contains("vault_role_id")) __score7++;
            if (__jsonProps.Contains("vault_secret_id")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("vault_addr")) __score8++;
            if (__jsonProps.Contains("vault_auth_type")) __score8++;
            if (__jsonProps.Contains("vault_namespace")) __score8++;
            if (__jsonProps.Contains("vault_role")) __score8++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }

            global::G.AwsAccessKeyAuthConfig? accessKey = default;
            global::G.AwsAssumedRoleAuthConfig? assumedRole = default;
            global::G.AwsServiceRoleAuthConfig? serviceRole = default;
            global::G.AzureEntraAuthConfig? azureEntra = default;
            global::G.AzureManagedAuthConfig? azureManaged = default;
            global::G.AzureDefaultAuthConfig? azureDefault = default;
            global::G.HashicorpTokenAuthConfig? hashicorpToken = default;
            global::G.HashicorpAppRoleAuthConfig? hashicorpAppRole = default;
            global::G.HashicorpKubernetesAuthConfig? hashicorpKubernetes = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AwsAccessKeyAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AwsAccessKeyAuthConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AwsAccessKeyAuthConfig).Name}");
                        accessKey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AwsAssumedRoleAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AwsAssumedRoleAuthConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AwsAssumedRoleAuthConfig).Name}");
                        assumedRole = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AwsServiceRoleAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AwsServiceRoleAuthConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AwsServiceRoleAuthConfig).Name}");
                        serviceRole = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AzureEntraAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AzureEntraAuthConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AzureEntraAuthConfig).Name}");
                        azureEntra = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AzureManagedAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AzureManagedAuthConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AzureManagedAuthConfig).Name}");
                        azureManaged = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AzureDefaultAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AzureDefaultAuthConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AzureDefaultAuthConfig).Name}");
                        azureDefault = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HashicorpTokenAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HashicorpTokenAuthConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HashicorpTokenAuthConfig).Name}");
                        hashicorpToken = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HashicorpAppRoleAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HashicorpAppRoleAuthConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HashicorpAppRoleAuthConfig).Name}");
                        hashicorpAppRole = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HashicorpKubernetesAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HashicorpKubernetesAuthConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HashicorpKubernetesAuthConfig).Name}");
                        hashicorpKubernetes = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (accessKey == null && assumedRole == null && serviceRole == null && azureEntra == null && azureManaged == null && azureDefault == null && hashicorpToken == null && hashicorpAppRole == null && hashicorpKubernetes == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AwsAccessKeyAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AwsAccessKeyAuthConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AwsAccessKeyAuthConfig).Name}");
                    accessKey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AwsAssumedRoleAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AwsAssumedRoleAuthConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AwsAssumedRoleAuthConfig).Name}");
                    assumedRole = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AwsServiceRoleAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AwsServiceRoleAuthConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AwsServiceRoleAuthConfig).Name}");
                    serviceRole = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AzureEntraAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AzureEntraAuthConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AzureEntraAuthConfig).Name}");
                    azureEntra = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AzureManagedAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AzureManagedAuthConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AzureManagedAuthConfig).Name}");
                    azureManaged = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AzureDefaultAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AzureDefaultAuthConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AzureDefaultAuthConfig).Name}");
                    azureDefault = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HashicorpTokenAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HashicorpTokenAuthConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HashicorpTokenAuthConfig).Name}");
                    hashicorpToken = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HashicorpAppRoleAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HashicorpAppRoleAuthConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HashicorpAppRoleAuthConfig).Name}");
                    hashicorpAppRole = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HashicorpKubernetesAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HashicorpKubernetesAuthConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HashicorpKubernetesAuthConfig).Name}");
                    hashicorpKubernetes = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.AuthConfig(
                accessKey,

                assumedRole,

                serviceRole,

                azureEntra,

                azureManaged,

                azureDefault,

                hashicorpToken,

                hashicorpAppRole,

                hashicorpKubernetes
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AuthConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAccessKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AwsAccessKeyAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AwsAccessKeyAuthConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AwsAccessKeyAuthConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AccessKey!, typeInfo);
            }
            else if (value.IsAssumedRole)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AwsAssumedRoleAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AwsAssumedRoleAuthConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AwsAssumedRoleAuthConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssumedRole!, typeInfo);
            }
            else if (value.IsServiceRole)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AwsServiceRoleAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AwsServiceRoleAuthConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AwsServiceRoleAuthConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServiceRole!, typeInfo);
            }
            else if (value.IsAzureEntra)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AzureEntraAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AzureEntraAuthConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AzureEntraAuthConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureEntra!, typeInfo);
            }
            else if (value.IsAzureManaged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AzureManagedAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AzureManagedAuthConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AzureManagedAuthConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureManaged!, typeInfo);
            }
            else if (value.IsAzureDefault)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AzureDefaultAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AzureDefaultAuthConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AzureDefaultAuthConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureDefault!, typeInfo);
            }
            else if (value.IsHashicorpToken)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HashicorpTokenAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HashicorpTokenAuthConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HashicorpTokenAuthConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HashicorpToken!, typeInfo);
            }
            else if (value.IsHashicorpAppRole)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HashicorpAppRoleAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HashicorpAppRoleAuthConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HashicorpAppRoleAuthConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HashicorpAppRole!, typeInfo);
            }
            else if (value.IsHashicorpKubernetes)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HashicorpKubernetesAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HashicorpKubernetesAuthConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HashicorpKubernetesAuthConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HashicorpKubernetes!, typeInfo);
            }
        }
    }
}