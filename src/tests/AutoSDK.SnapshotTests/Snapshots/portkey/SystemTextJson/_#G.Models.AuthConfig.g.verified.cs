//HintName: G.Models.AuthConfig.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AuthConfig : global::System.IEquatable<AuthConfig>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AwsAccessKeyAuthConfig? AccessKey { get; init; }
#else
        public global::G.AwsAccessKeyAuthConfig? AccessKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AccessKey))]
#endif
        public bool IsAccessKey => AccessKey != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AwsAssumedRoleAuthConfig? AssumedRole { get; init; }
#else
        public global::G.AwsAssumedRoleAuthConfig? AssumedRole { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssumedRole))]
#endif
        public bool IsAssumedRole => AssumedRole != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AwsServiceRoleAuthConfig? ServiceRole { get; init; }
#else
        public global::G.AwsServiceRoleAuthConfig? ServiceRole { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ServiceRole))]
#endif
        public bool IsServiceRole => ServiceRole != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AzureEntraAuthConfig? AzureEntra { get; init; }
#else
        public global::G.AzureEntraAuthConfig? AzureEntra { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AzureEntra))]
#endif
        public bool IsAzureEntra => AzureEntra != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AzureManagedAuthConfig? AzureManaged { get; init; }
#else
        public global::G.AzureManagedAuthConfig? AzureManaged { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AzureManaged))]
#endif
        public bool IsAzureManaged => AzureManaged != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AzureDefaultAuthConfig? AzureDefault { get; init; }
#else
        public global::G.AzureDefaultAuthConfig? AzureDefault { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AzureDefault))]
#endif
        public bool IsAzureDefault => AzureDefault != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.HashicorpTokenAuthConfig? HashicorpToken { get; init; }
#else
        public global::G.HashicorpTokenAuthConfig? HashicorpToken { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HashicorpToken))]
#endif
        public bool IsHashicorpToken => HashicorpToken != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.HashicorpAppRoleAuthConfig? HashicorpAppRole { get; init; }
#else
        public global::G.HashicorpAppRoleAuthConfig? HashicorpAppRole { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HashicorpAppRole))]
#endif
        public bool IsHashicorpAppRole => HashicorpAppRole != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.HashicorpKubernetesAuthConfig? HashicorpKubernetes { get; init; }
#else
        public global::G.HashicorpKubernetesAuthConfig? HashicorpKubernetes { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HashicorpKubernetes))]
#endif
        public bool IsHashicorpKubernetes => HashicorpKubernetes != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::G.AwsAccessKeyAuthConfig value) => new AuthConfig((global::G.AwsAccessKeyAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AwsAccessKeyAuthConfig?(AuthConfig @this) => @this.AccessKey;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::G.AwsAccessKeyAuthConfig? value)
        {
            AccessKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::G.AwsAssumedRoleAuthConfig value) => new AuthConfig((global::G.AwsAssumedRoleAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AwsAssumedRoleAuthConfig?(AuthConfig @this) => @this.AssumedRole;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::G.AwsAssumedRoleAuthConfig? value)
        {
            AssumedRole = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::G.AwsServiceRoleAuthConfig value) => new AuthConfig((global::G.AwsServiceRoleAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AwsServiceRoleAuthConfig?(AuthConfig @this) => @this.ServiceRole;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::G.AwsServiceRoleAuthConfig? value)
        {
            ServiceRole = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::G.AzureEntraAuthConfig value) => new AuthConfig((global::G.AzureEntraAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AzureEntraAuthConfig?(AuthConfig @this) => @this.AzureEntra;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::G.AzureEntraAuthConfig? value)
        {
            AzureEntra = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::G.AzureManagedAuthConfig value) => new AuthConfig((global::G.AzureManagedAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AzureManagedAuthConfig?(AuthConfig @this) => @this.AzureManaged;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::G.AzureManagedAuthConfig? value)
        {
            AzureManaged = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::G.AzureDefaultAuthConfig value) => new AuthConfig((global::G.AzureDefaultAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AzureDefaultAuthConfig?(AuthConfig @this) => @this.AzureDefault;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::G.AzureDefaultAuthConfig? value)
        {
            AzureDefault = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::G.HashicorpTokenAuthConfig value) => new AuthConfig((global::G.HashicorpTokenAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HashicorpTokenAuthConfig?(AuthConfig @this) => @this.HashicorpToken;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::G.HashicorpTokenAuthConfig? value)
        {
            HashicorpToken = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::G.HashicorpAppRoleAuthConfig value) => new AuthConfig((global::G.HashicorpAppRoleAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HashicorpAppRoleAuthConfig?(AuthConfig @this) => @this.HashicorpAppRole;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::G.HashicorpAppRoleAuthConfig? value)
        {
            HashicorpAppRole = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConfig(global::G.HashicorpKubernetesAuthConfig value) => new AuthConfig((global::G.HashicorpKubernetesAuthConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HashicorpKubernetesAuthConfig?(AuthConfig @this) => @this.HashicorpKubernetes;

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(global::G.HashicorpKubernetesAuthConfig? value)
        {
            HashicorpKubernetes = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AuthConfig(
            global::G.AwsAccessKeyAuthConfig? accessKey,
            global::G.AwsAssumedRoleAuthConfig? assumedRole,
            global::G.AwsServiceRoleAuthConfig? serviceRole,
            global::G.AzureEntraAuthConfig? azureEntra,
            global::G.AzureManagedAuthConfig? azureManaged,
            global::G.AzureDefaultAuthConfig? azureDefault,
            global::G.HashicorpTokenAuthConfig? hashicorpToken,
            global::G.HashicorpAppRoleAuthConfig? hashicorpAppRole,
            global::G.HashicorpKubernetesAuthConfig? hashicorpKubernetes
            )
        {
            AccessKey = accessKey;
            AssumedRole = assumedRole;
            ServiceRole = serviceRole;
            AzureEntra = azureEntra;
            AzureManaged = azureManaged;
            AzureDefault = azureDefault;
            HashicorpToken = hashicorpToken;
            HashicorpAppRole = hashicorpAppRole;
            HashicorpKubernetes = hashicorpKubernetes;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            HashicorpKubernetes as object ??
            HashicorpAppRole as object ??
            HashicorpToken as object ??
            AzureDefault as object ??
            AzureManaged as object ??
            AzureEntra as object ??
            ServiceRole as object ??
            AssumedRole as object ??
            AccessKey as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AccessKey?.ToString() ??
            AssumedRole?.ToString() ??
            ServiceRole?.ToString() ??
            AzureEntra?.ToString() ??
            AzureManaged?.ToString() ??
            AzureDefault?.ToString() ??
            HashicorpToken?.ToString() ??
            HashicorpAppRole?.ToString() ??
            HashicorpKubernetes?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAccessKey && !IsAssumedRole && !IsServiceRole && !IsAzureEntra && !IsAzureManaged && !IsAzureDefault && !IsHashicorpToken && !IsHashicorpAppRole && !IsHashicorpKubernetes || !IsAccessKey && IsAssumedRole && !IsServiceRole && !IsAzureEntra && !IsAzureManaged && !IsAzureDefault && !IsHashicorpToken && !IsHashicorpAppRole && !IsHashicorpKubernetes || !IsAccessKey && !IsAssumedRole && IsServiceRole && !IsAzureEntra && !IsAzureManaged && !IsAzureDefault && !IsHashicorpToken && !IsHashicorpAppRole && !IsHashicorpKubernetes || !IsAccessKey && !IsAssumedRole && !IsServiceRole && IsAzureEntra && !IsAzureManaged && !IsAzureDefault && !IsHashicorpToken && !IsHashicorpAppRole && !IsHashicorpKubernetes || !IsAccessKey && !IsAssumedRole && !IsServiceRole && !IsAzureEntra && IsAzureManaged && !IsAzureDefault && !IsHashicorpToken && !IsHashicorpAppRole && !IsHashicorpKubernetes || !IsAccessKey && !IsAssumedRole && !IsServiceRole && !IsAzureEntra && !IsAzureManaged && IsAzureDefault && !IsHashicorpToken && !IsHashicorpAppRole && !IsHashicorpKubernetes || !IsAccessKey && !IsAssumedRole && !IsServiceRole && !IsAzureEntra && !IsAzureManaged && !IsAzureDefault && IsHashicorpToken && !IsHashicorpAppRole && !IsHashicorpKubernetes || !IsAccessKey && !IsAssumedRole && !IsServiceRole && !IsAzureEntra && !IsAzureManaged && !IsAzureDefault && !IsHashicorpToken && IsHashicorpAppRole && !IsHashicorpKubernetes || !IsAccessKey && !IsAssumedRole && !IsServiceRole && !IsAzureEntra && !IsAzureManaged && !IsAzureDefault && !IsHashicorpToken && !IsHashicorpAppRole && IsHashicorpKubernetes;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AwsAccessKeyAuthConfig?, TResult>? accessKey = null,
            global::System.Func<global::G.AwsAssumedRoleAuthConfig?, TResult>? assumedRole = null,
            global::System.Func<global::G.AwsServiceRoleAuthConfig?, TResult>? serviceRole = null,
            global::System.Func<global::G.AzureEntraAuthConfig?, TResult>? azureEntra = null,
            global::System.Func<global::G.AzureManagedAuthConfig?, TResult>? azureManaged = null,
            global::System.Func<global::G.AzureDefaultAuthConfig?, TResult>? azureDefault = null,
            global::System.Func<global::G.HashicorpTokenAuthConfig?, TResult>? hashicorpToken = null,
            global::System.Func<global::G.HashicorpAppRoleAuthConfig?, TResult>? hashicorpAppRole = null,
            global::System.Func<global::G.HashicorpKubernetesAuthConfig?, TResult>? hashicorpKubernetes = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAccessKey && accessKey != null)
            {
                return accessKey(AccessKey!);
            }
            else if (IsAssumedRole && assumedRole != null)
            {
                return assumedRole(AssumedRole!);
            }
            else if (IsServiceRole && serviceRole != null)
            {
                return serviceRole(ServiceRole!);
            }
            else if (IsAzureEntra && azureEntra != null)
            {
                return azureEntra(AzureEntra!);
            }
            else if (IsAzureManaged && azureManaged != null)
            {
                return azureManaged(AzureManaged!);
            }
            else if (IsAzureDefault && azureDefault != null)
            {
                return azureDefault(AzureDefault!);
            }
            else if (IsHashicorpToken && hashicorpToken != null)
            {
                return hashicorpToken(HashicorpToken!);
            }
            else if (IsHashicorpAppRole && hashicorpAppRole != null)
            {
                return hashicorpAppRole(HashicorpAppRole!);
            }
            else if (IsHashicorpKubernetes && hashicorpKubernetes != null)
            {
                return hashicorpKubernetes(HashicorpKubernetes!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AwsAccessKeyAuthConfig?>? accessKey = null,
            global::System.Action<global::G.AwsAssumedRoleAuthConfig?>? assumedRole = null,
            global::System.Action<global::G.AwsServiceRoleAuthConfig?>? serviceRole = null,
            global::System.Action<global::G.AzureEntraAuthConfig?>? azureEntra = null,
            global::System.Action<global::G.AzureManagedAuthConfig?>? azureManaged = null,
            global::System.Action<global::G.AzureDefaultAuthConfig?>? azureDefault = null,
            global::System.Action<global::G.HashicorpTokenAuthConfig?>? hashicorpToken = null,
            global::System.Action<global::G.HashicorpAppRoleAuthConfig?>? hashicorpAppRole = null,
            global::System.Action<global::G.HashicorpKubernetesAuthConfig?>? hashicorpKubernetes = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAccessKey)
            {
                accessKey?.Invoke(AccessKey!);
            }
            else if (IsAssumedRole)
            {
                assumedRole?.Invoke(AssumedRole!);
            }
            else if (IsServiceRole)
            {
                serviceRole?.Invoke(ServiceRole!);
            }
            else if (IsAzureEntra)
            {
                azureEntra?.Invoke(AzureEntra!);
            }
            else if (IsAzureManaged)
            {
                azureManaged?.Invoke(AzureManaged!);
            }
            else if (IsAzureDefault)
            {
                azureDefault?.Invoke(AzureDefault!);
            }
            else if (IsHashicorpToken)
            {
                hashicorpToken?.Invoke(HashicorpToken!);
            }
            else if (IsHashicorpAppRole)
            {
                hashicorpAppRole?.Invoke(HashicorpAppRole!);
            }
            else if (IsHashicorpKubernetes)
            {
                hashicorpKubernetes?.Invoke(HashicorpKubernetes!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AccessKey,
                typeof(global::G.AwsAccessKeyAuthConfig),
                AssumedRole,
                typeof(global::G.AwsAssumedRoleAuthConfig),
                ServiceRole,
                typeof(global::G.AwsServiceRoleAuthConfig),
                AzureEntra,
                typeof(global::G.AzureEntraAuthConfig),
                AzureManaged,
                typeof(global::G.AzureManagedAuthConfig),
                AzureDefault,
                typeof(global::G.AzureDefaultAuthConfig),
                HashicorpToken,
                typeof(global::G.HashicorpTokenAuthConfig),
                HashicorpAppRole,
                typeof(global::G.HashicorpAppRoleAuthConfig),
                HashicorpKubernetes,
                typeof(global::G.HashicorpKubernetesAuthConfig),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(AuthConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AwsAccessKeyAuthConfig?>.Default.Equals(AccessKey, other.AccessKey) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AwsAssumedRoleAuthConfig?>.Default.Equals(AssumedRole, other.AssumedRole) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AwsServiceRoleAuthConfig?>.Default.Equals(ServiceRole, other.ServiceRole) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AzureEntraAuthConfig?>.Default.Equals(AzureEntra, other.AzureEntra) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AzureManagedAuthConfig?>.Default.Equals(AzureManaged, other.AzureManaged) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AzureDefaultAuthConfig?>.Default.Equals(AzureDefault, other.AzureDefault) &&
                global::System.Collections.Generic.EqualityComparer<global::G.HashicorpTokenAuthConfig?>.Default.Equals(HashicorpToken, other.HashicorpToken) &&
                global::System.Collections.Generic.EqualityComparer<global::G.HashicorpAppRoleAuthConfig?>.Default.Equals(HashicorpAppRole, other.HashicorpAppRole) &&
                global::System.Collections.Generic.EqualityComparer<global::G.HashicorpKubernetesAuthConfig?>.Default.Equals(HashicorpKubernetes, other.HashicorpKubernetes) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AuthConfig obj1, AuthConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AuthConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AuthConfig obj1, AuthConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AuthConfig o && Equals(o);
        }
    }
}
