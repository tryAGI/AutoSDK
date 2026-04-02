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
                        accessKey = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AwsAccessKeyAuthConfig>(__rawJson, options);
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
                        assumedRole = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AwsAssumedRoleAuthConfig>(__rawJson, options);
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
                        serviceRole = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AwsServiceRoleAuthConfig>(__rawJson, options);
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
                        azureEntra = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AzureEntraAuthConfig>(__rawJson, options);
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
                        azureManaged = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AzureManagedAuthConfig>(__rawJson, options);
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
                        azureDefault = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AzureDefaultAuthConfig>(__rawJson, options);
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
                        hashicorpToken = global::System.Text.Json.JsonSerializer.Deserialize<global::G.HashicorpTokenAuthConfig>(__rawJson, options);
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
                        hashicorpAppRole = global::System.Text.Json.JsonSerializer.Deserialize<global::G.HashicorpAppRoleAuthConfig>(__rawJson, options);
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
                        hashicorpKubernetes = global::System.Text.Json.JsonSerializer.Deserialize<global::G.HashicorpKubernetesAuthConfig>(__rawJson, options);
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
                    accessKey = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AwsAccessKeyAuthConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    assumedRole = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AwsAssumedRoleAuthConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    serviceRole = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AwsServiceRoleAuthConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    azureEntra = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AzureEntraAuthConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    azureManaged = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AzureManagedAuthConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    azureDefault = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AzureDefaultAuthConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    hashicorpToken = global::System.Text.Json.JsonSerializer.Deserialize<global::G.HashicorpTokenAuthConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    hashicorpAppRole = global::System.Text.Json.JsonSerializer.Deserialize<global::G.HashicorpAppRoleAuthConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    hashicorpKubernetes = global::System.Text.Json.JsonSerializer.Deserialize<global::G.HashicorpKubernetesAuthConfig>(__rawJson, options);
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

            if (value.IsAccessKey)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AccessKey, typeof(global::G.AwsAccessKeyAuthConfig), options);
            }
            else if (value.IsAssumedRole)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssumedRole, typeof(global::G.AwsAssumedRoleAuthConfig), options);
            }
            else if (value.IsServiceRole)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServiceRole, typeof(global::G.AwsServiceRoleAuthConfig), options);
            }
            else if (value.IsAzureEntra)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureEntra, typeof(global::G.AzureEntraAuthConfig), options);
            }
            else if (value.IsAzureManaged)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureManaged, typeof(global::G.AzureManagedAuthConfig), options);
            }
            else if (value.IsAzureDefault)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureDefault, typeof(global::G.AzureDefaultAuthConfig), options);
            }
            else if (value.IsHashicorpToken)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HashicorpToken, typeof(global::G.HashicorpTokenAuthConfig), options);
            }
            else if (value.IsHashicorpAppRole)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HashicorpAppRole, typeof(global::G.HashicorpAppRoleAuthConfig), options);
            }
            else if (value.IsHashicorpKubernetes)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HashicorpKubernetes, typeof(global::G.HashicorpKubernetesAuthConfig), options);
            }
        }
    }
}