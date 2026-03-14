//HintName: G.Models.AnthropicAuth.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication configuration for Anthropic LLM via direct Anthropic API (use RemoteAuth with header "x-api-key"), AWS Bedrock, or GCP Vertex AI Model Garden
    /// </summary>
    public readonly partial struct AnthropicAuth : global::System.IEquatable<AnthropicAuth>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.AnthropicAuthDiscriminatorType? Type { get; }

        /// <summary>
        /// Bearer token authentication
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BearerAuth? Bearer { get; init; }
#else
        public global::G.BearerAuth? Bearer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bearer))]
#endif
        public bool IsBearer => Bearer != null;

        /// <summary>
        /// Custom header-based authentication
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.HeaderAuth? Header { get; init; }
#else
        public global::G.HeaderAuth? Header { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Header))]
#endif
        public bool IsHeader => Header != null;

        /// <summary>
        /// AWS Bedrock authentication with explicit IAM credentials
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BedrockStaticIAMAuth? BedrockStaticIam { get; init; }
#else
        public global::G.BedrockStaticIAMAuth? BedrockStaticIam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BedrockStaticIam))]
#endif
        public bool IsBedrockStaticIam => BedrockStaticIam != null;

        /// <summary>
        /// AWS Bedrock API key authentication
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BedrockApiKeyAuth? BedrockApiKey { get; init; }
#else
        public global::G.BedrockApiKeyAuth? BedrockApiKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BedrockApiKey))]
#endif
        public bool IsBedrockApiKey => BedrockApiKey != null;

        /// <summary>
        /// Google Cloud Vertex AI service account authentication
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VertexServiceAccountAuth? VertexServiceAccount { get; init; }
#else
        public global::G.VertexServiceAccountAuth? VertexServiceAccount { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VertexServiceAccount))]
#endif
        public bool IsVertexServiceAccount => VertexServiceAccount != null;

        /// <summary>
        /// Google Cloud Vertex AI access token authentication
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VertexAccessTokenAuth? VertexAccessToken { get; init; }
#else
        public global::G.VertexAccessTokenAuth? VertexAccessToken { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VertexAccessToken))]
#endif
        public bool IsVertexAccessToken => VertexAccessToken != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicAuth(global::G.BearerAuth value) => new AnthropicAuth((global::G.BearerAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BearerAuth?(AnthropicAuth @this) => @this.Bearer;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicAuth(global::G.BearerAuth? value)
        {
            Bearer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicAuth(global::G.HeaderAuth value) => new AnthropicAuth((global::G.HeaderAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HeaderAuth?(AnthropicAuth @this) => @this.Header;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicAuth(global::G.HeaderAuth? value)
        {
            Header = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicAuth(global::G.BedrockStaticIAMAuth value) => new AnthropicAuth((global::G.BedrockStaticIAMAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BedrockStaticIAMAuth?(AnthropicAuth @this) => @this.BedrockStaticIam;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicAuth(global::G.BedrockStaticIAMAuth? value)
        {
            BedrockStaticIam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicAuth(global::G.BedrockApiKeyAuth value) => new AnthropicAuth((global::G.BedrockApiKeyAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BedrockApiKeyAuth?(AnthropicAuth @this) => @this.BedrockApiKey;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicAuth(global::G.BedrockApiKeyAuth? value)
        {
            BedrockApiKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicAuth(global::G.VertexServiceAccountAuth value) => new AnthropicAuth((global::G.VertexServiceAccountAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VertexServiceAccountAuth?(AnthropicAuth @this) => @this.VertexServiceAccount;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicAuth(global::G.VertexServiceAccountAuth? value)
        {
            VertexServiceAccount = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicAuth(global::G.VertexAccessTokenAuth value) => new AnthropicAuth((global::G.VertexAccessTokenAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VertexAccessTokenAuth?(AnthropicAuth @this) => @this.VertexAccessToken;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicAuth(global::G.VertexAccessTokenAuth? value)
        {
            VertexAccessToken = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicAuth(
            global::G.AnthropicAuthDiscriminatorType? type,
            global::G.BearerAuth? bearer,
            global::G.HeaderAuth? header,
            global::G.BedrockStaticIAMAuth? bedrockStaticIam,
            global::G.BedrockApiKeyAuth? bedrockApiKey,
            global::G.VertexServiceAccountAuth? vertexServiceAccount,
            global::G.VertexAccessTokenAuth? vertexAccessToken
            )
        {
            Type = type;

            Bearer = bearer;
            Header = header;
            BedrockStaticIam = bedrockStaticIam;
            BedrockApiKey = bedrockApiKey;
            VertexServiceAccount = vertexServiceAccount;
            VertexAccessToken = vertexAccessToken;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VertexAccessToken as object ??
            VertexServiceAccount as object ??
            BedrockApiKey as object ??
            BedrockStaticIam as object ??
            Header as object ??
            Bearer as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Bearer?.ToString() ??
            Header?.ToString() ??
            BedrockStaticIam?.ToString() ??
            BedrockApiKey?.ToString() ??
            VertexServiceAccount?.ToString() ??
            VertexAccessToken?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBearer && !IsHeader && !IsBedrockStaticIam && !IsBedrockApiKey && !IsVertexServiceAccount && !IsVertexAccessToken || !IsBearer && IsHeader && !IsBedrockStaticIam && !IsBedrockApiKey && !IsVertexServiceAccount && !IsVertexAccessToken || !IsBearer && !IsHeader && IsBedrockStaticIam && !IsBedrockApiKey && !IsVertexServiceAccount && !IsVertexAccessToken || !IsBearer && !IsHeader && !IsBedrockStaticIam && IsBedrockApiKey && !IsVertexServiceAccount && !IsVertexAccessToken || !IsBearer && !IsHeader && !IsBedrockStaticIam && !IsBedrockApiKey && IsVertexServiceAccount && !IsVertexAccessToken || !IsBearer && !IsHeader && !IsBedrockStaticIam && !IsBedrockApiKey && !IsVertexServiceAccount && IsVertexAccessToken;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BearerAuth?, TResult>? bearer = null,
            global::System.Func<global::G.HeaderAuth?, TResult>? header = null,
            global::System.Func<global::G.BedrockStaticIAMAuth?, TResult>? bedrockStaticIam = null,
            global::System.Func<global::G.BedrockApiKeyAuth?, TResult>? bedrockApiKey = null,
            global::System.Func<global::G.VertexServiceAccountAuth?, TResult>? vertexServiceAccount = null,
            global::System.Func<global::G.VertexAccessTokenAuth?, TResult>? vertexAccessToken = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBearer && bearer != null)
            {
                return bearer(Bearer!);
            }
            else if (IsHeader && header != null)
            {
                return header(Header!);
            }
            else if (IsBedrockStaticIam && bedrockStaticIam != null)
            {
                return bedrockStaticIam(BedrockStaticIam!);
            }
            else if (IsBedrockApiKey && bedrockApiKey != null)
            {
                return bedrockApiKey(BedrockApiKey!);
            }
            else if (IsVertexServiceAccount && vertexServiceAccount != null)
            {
                return vertexServiceAccount(VertexServiceAccount!);
            }
            else if (IsVertexAccessToken && vertexAccessToken != null)
            {
                return vertexAccessToken(VertexAccessToken!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BearerAuth?>? bearer = null,
            global::System.Action<global::G.HeaderAuth?>? header = null,
            global::System.Action<global::G.BedrockStaticIAMAuth?>? bedrockStaticIam = null,
            global::System.Action<global::G.BedrockApiKeyAuth?>? bedrockApiKey = null,
            global::System.Action<global::G.VertexServiceAccountAuth?>? vertexServiceAccount = null,
            global::System.Action<global::G.VertexAccessTokenAuth?>? vertexAccessToken = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBearer)
            {
                bearer?.Invoke(Bearer!);
            }
            else if (IsHeader)
            {
                header?.Invoke(Header!);
            }
            else if (IsBedrockStaticIam)
            {
                bedrockStaticIam?.Invoke(BedrockStaticIam!);
            }
            else if (IsBedrockApiKey)
            {
                bedrockApiKey?.Invoke(BedrockApiKey!);
            }
            else if (IsVertexServiceAccount)
            {
                vertexServiceAccount?.Invoke(VertexServiceAccount!);
            }
            else if (IsVertexAccessToken)
            {
                vertexAccessToken?.Invoke(VertexAccessToken!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Bearer,
                typeof(global::G.BearerAuth),
                Header,
                typeof(global::G.HeaderAuth),
                BedrockStaticIam,
                typeof(global::G.BedrockStaticIAMAuth),
                BedrockApiKey,
                typeof(global::G.BedrockApiKeyAuth),
                VertexServiceAccount,
                typeof(global::G.VertexServiceAccountAuth),
                VertexAccessToken,
                typeof(global::G.VertexAccessTokenAuth),
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
        public bool Equals(AnthropicAuth other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BearerAuth?>.Default.Equals(Bearer, other.Bearer) &&
                global::System.Collections.Generic.EqualityComparer<global::G.HeaderAuth?>.Default.Equals(Header, other.Header) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BedrockStaticIAMAuth?>.Default.Equals(BedrockStaticIam, other.BedrockStaticIam) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BedrockApiKeyAuth?>.Default.Equals(BedrockApiKey, other.BedrockApiKey) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VertexServiceAccountAuth?>.Default.Equals(VertexServiceAccount, other.VertexServiceAccount) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VertexAccessTokenAuth?>.Default.Equals(VertexAccessToken, other.VertexAccessToken) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicAuth obj1, AnthropicAuth obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicAuth>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicAuth obj1, AnthropicAuth obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicAuth o && Equals(o);
        }
    }
}
