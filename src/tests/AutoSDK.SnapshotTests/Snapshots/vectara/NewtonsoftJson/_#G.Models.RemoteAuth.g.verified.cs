//HintName: G.Models.RemoteAuth.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication configuration for an LLM
    /// </summary>
    public readonly partial struct RemoteAuth : global::System.IEquatable<RemoteAuth>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.RemoteAuthDiscriminatorType? Type { get; }

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
        /// 
        /// </summary>
        public static implicit operator RemoteAuth(global::G.BearerAuth value) => new RemoteAuth((global::G.BearerAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BearerAuth?(RemoteAuth @this) => @this.Bearer;

        /// <summary>
        /// 
        /// </summary>
        public RemoteAuth(global::G.BearerAuth? value)
        {
            Bearer = value;
        }

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
        /// 
        /// </summary>
        public static implicit operator RemoteAuth(global::G.HeaderAuth value) => new RemoteAuth((global::G.HeaderAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HeaderAuth?(RemoteAuth @this) => @this.Header;

        /// <summary>
        /// 
        /// </summary>
        public RemoteAuth(global::G.HeaderAuth? value)
        {
            Header = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RemoteAuth(
            global::G.RemoteAuthDiscriminatorType? type,
            global::G.BearerAuth? bearer,
            global::G.HeaderAuth? header
            )
        {
            Type = type;

            Bearer = bearer;
            Header = header;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Header as object ??
            Bearer as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Bearer?.ToString() ??
            Header?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBearer && !IsHeader || !IsBearer && IsHeader;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BearerAuth?, TResult>? bearer = null,
            global::System.Func<global::G.HeaderAuth?, TResult>? header = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BearerAuth?>? bearer = null,
            global::System.Action<global::G.HeaderAuth?>? header = null,
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
        public bool Equals(RemoteAuth other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BearerAuth?>.Default.Equals(Bearer, other.Bearer) &&
                global::System.Collections.Generic.EqualityComparer<global::G.HeaderAuth?>.Default.Equals(Header, other.Header) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RemoteAuth obj1, RemoteAuth obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RemoteAuth>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RemoteAuth obj1, RemoteAuth obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RemoteAuth o && Equals(o);
        }
    }
}
