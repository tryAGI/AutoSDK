//HintName: G.Models.VertexAiAuth.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication configuration for Vertex AI
    /// </summary>
    public readonly partial struct VertexAiAuth : global::System.IEquatable<VertexAiAuth>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.VertexAiAuthDiscriminatorType? Type { get; }

        /// <summary>
        /// API key authentication for Vertex AI
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VertexAiApiKeyAuth? ApiKey { get; init; }
#else
        public global::G.VertexAiApiKeyAuth? ApiKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiKey))]
#endif
        public bool IsApiKey => ApiKey != null;

        /// <summary>
        /// Service account authentication for Vertex AI
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VertexAiServiceAccountAuth? ServiceAccount { get; init; }
#else
        public global::G.VertexAiServiceAccountAuth? ServiceAccount { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ServiceAccount))]
#endif
        public bool IsServiceAccount => ServiceAccount != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VertexAiAuth(global::G.VertexAiApiKeyAuth value) => new VertexAiAuth((global::G.VertexAiApiKeyAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VertexAiApiKeyAuth?(VertexAiAuth @this) => @this.ApiKey;

        /// <summary>
        /// 
        /// </summary>
        public VertexAiAuth(global::G.VertexAiApiKeyAuth? value)
        {
            ApiKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VertexAiAuth(global::G.VertexAiServiceAccountAuth value) => new VertexAiAuth((global::G.VertexAiServiceAccountAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VertexAiServiceAccountAuth?(VertexAiAuth @this) => @this.ServiceAccount;

        /// <summary>
        /// 
        /// </summary>
        public VertexAiAuth(global::G.VertexAiServiceAccountAuth? value)
        {
            ServiceAccount = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VertexAiAuth(
            global::G.VertexAiAuthDiscriminatorType? type,
            global::G.VertexAiApiKeyAuth? apiKey,
            global::G.VertexAiServiceAccountAuth? serviceAccount
            )
        {
            Type = type;

            ApiKey = apiKey;
            ServiceAccount = serviceAccount;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ServiceAccount as object ??
            ApiKey as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ApiKey?.ToString() ??
            ServiceAccount?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApiKey && !IsServiceAccount || !IsApiKey && IsServiceAccount;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.VertexAiApiKeyAuth?, TResult>? apiKey = null,
            global::System.Func<global::G.VertexAiServiceAccountAuth?, TResult>? serviceAccount = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiKey && apiKey != null)
            {
                return apiKey(ApiKey!);
            }
            else if (IsServiceAccount && serviceAccount != null)
            {
                return serviceAccount(ServiceAccount!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.VertexAiApiKeyAuth?>? apiKey = null,
            global::System.Action<global::G.VertexAiServiceAccountAuth?>? serviceAccount = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiKey)
            {
                apiKey?.Invoke(ApiKey!);
            }
            else if (IsServiceAccount)
            {
                serviceAccount?.Invoke(ServiceAccount!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ApiKey,
                typeof(global::G.VertexAiApiKeyAuth),
                ServiceAccount,
                typeof(global::G.VertexAiServiceAccountAuth),
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
        public bool Equals(VertexAiAuth other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.VertexAiApiKeyAuth?>.Default.Equals(ApiKey, other.ApiKey) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VertexAiServiceAccountAuth?>.Default.Equals(ServiceAccount, other.ServiceAccount) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VertexAiAuth obj1, VertexAiAuth obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VertexAiAuth>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VertexAiAuth obj1, VertexAiAuth obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VertexAiAuth o && Equals(o);
        }
    }
}
