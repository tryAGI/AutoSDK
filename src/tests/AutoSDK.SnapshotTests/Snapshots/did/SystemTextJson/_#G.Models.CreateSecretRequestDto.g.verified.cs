//HintName: G.Models.CreateSecretRequestDto.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateSecretRequestDto : global::System.IEquatable<CreateSecretRequestDto>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateSecretRequestDtoBasicAuthentication? BasicAuthentication { get; init; }
#else
        public global::G.CreateSecretRequestDtoBasicAuthentication? BasicAuthentication { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BasicAuthentication))]
#endif
        public bool IsBasicAuthentication => BasicAuthentication != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateSecretRequestDtoBearerToken? BearerToken { get; init; }
#else
        public global::G.CreateSecretRequestDtoBearerToken? BearerToken { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BearerToken))]
#endif
        public bool IsBearerToken => BearerToken != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateSecretRequestDtoApiKey? ApiKey { get; init; }
#else
        public global::G.CreateSecretRequestDtoApiKey? ApiKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiKey))]
#endif
        public bool IsApiKey => ApiKey != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateSecretRequestDto(global::G.CreateSecretRequestDtoBasicAuthentication value) => new CreateSecretRequestDto((global::G.CreateSecretRequestDtoBasicAuthentication?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateSecretRequestDtoBasicAuthentication?(CreateSecretRequestDto @this) => @this.BasicAuthentication;

        /// <summary>
        /// 
        /// </summary>
        public CreateSecretRequestDto(global::G.CreateSecretRequestDtoBasicAuthentication? value)
        {
            BasicAuthentication = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateSecretRequestDto(global::G.CreateSecretRequestDtoBearerToken value) => new CreateSecretRequestDto((global::G.CreateSecretRequestDtoBearerToken?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateSecretRequestDtoBearerToken?(CreateSecretRequestDto @this) => @this.BearerToken;

        /// <summary>
        /// 
        /// </summary>
        public CreateSecretRequestDto(global::G.CreateSecretRequestDtoBearerToken? value)
        {
            BearerToken = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateSecretRequestDto(global::G.CreateSecretRequestDtoApiKey value) => new CreateSecretRequestDto((global::G.CreateSecretRequestDtoApiKey?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateSecretRequestDtoApiKey?(CreateSecretRequestDto @this) => @this.ApiKey;

        /// <summary>
        /// 
        /// </summary>
        public CreateSecretRequestDto(global::G.CreateSecretRequestDtoApiKey? value)
        {
            ApiKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateSecretRequestDto(
            global::G.CreateSecretRequestDtoBasicAuthentication? basicAuthentication,
            global::G.CreateSecretRequestDtoBearerToken? bearerToken,
            global::G.CreateSecretRequestDtoApiKey? apiKey
            )
        {
            BasicAuthentication = basicAuthentication;
            BearerToken = bearerToken;
            ApiKey = apiKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ApiKey as object ??
            BearerToken as object ??
            BasicAuthentication as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BasicAuthentication?.ToString() ??
            BearerToken?.ToString() ??
            ApiKey?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBasicAuthentication || IsBearerToken || IsApiKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateSecretRequestDtoBasicAuthentication?, TResult>? basicAuthentication = null,
            global::System.Func<global::G.CreateSecretRequestDtoBearerToken?, TResult>? bearerToken = null,
            global::System.Func<global::G.CreateSecretRequestDtoApiKey?, TResult>? apiKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBasicAuthentication && basicAuthentication != null)
            {
                return basicAuthentication(BasicAuthentication!);
            }
            else if (IsBearerToken && bearerToken != null)
            {
                return bearerToken(BearerToken!);
            }
            else if (IsApiKey && apiKey != null)
            {
                return apiKey(ApiKey!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateSecretRequestDtoBasicAuthentication?>? basicAuthentication = null,
            global::System.Action<global::G.CreateSecretRequestDtoBearerToken?>? bearerToken = null,
            global::System.Action<global::G.CreateSecretRequestDtoApiKey?>? apiKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBasicAuthentication)
            {
                basicAuthentication?.Invoke(BasicAuthentication!);
            }
            else if (IsBearerToken)
            {
                bearerToken?.Invoke(BearerToken!);
            }
            else if (IsApiKey)
            {
                apiKey?.Invoke(ApiKey!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BasicAuthentication,
                typeof(global::G.CreateSecretRequestDtoBasicAuthentication),
                BearerToken,
                typeof(global::G.CreateSecretRequestDtoBearerToken),
                ApiKey,
                typeof(global::G.CreateSecretRequestDtoApiKey),
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
        public bool Equals(CreateSecretRequestDto other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateSecretRequestDtoBasicAuthentication?>.Default.Equals(BasicAuthentication, other.BasicAuthentication) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateSecretRequestDtoBearerToken?>.Default.Equals(BearerToken, other.BearerToken) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateSecretRequestDtoApiKey?>.Default.Equals(ApiKey, other.ApiKey) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateSecretRequestDto obj1, CreateSecretRequestDto obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateSecretRequestDto>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateSecretRequestDto obj1, CreateSecretRequestDto obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateSecretRequestDto o && Equals(o);
        }
    }
}
