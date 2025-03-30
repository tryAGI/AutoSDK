//HintName: G.Models.Source2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Source2 : global::System.IEquatable<Source2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaRequestImageBlockSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaBase64ImageSource? Base64 { get; init; }
#else
        public global::G.BetaBase64ImageSource? Base64 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base64))]
#endif
        public bool IsBase64 => Base64 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source2(global::G.BetaBase64ImageSource value) => new Source2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaBase64ImageSource?(Source2 @this) => @this.Base64;

        /// <summary>
        /// 
        /// </summary>
        public Source2(global::G.BetaBase64ImageSource? value)
        {
            Base64 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaURLImageSource? Url { get; init; }
#else
        public global::G.BetaURLImageSource? Url { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Url))]
#endif
        public bool IsUrl => Url != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source2(global::G.BetaURLImageSource value) => new Source2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaURLImageSource?(Source2 @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public Source2(global::G.BetaURLImageSource? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Source2(
            global::G.BetaRequestImageBlockSourceDiscriminatorType? type,
            global::G.BetaBase64ImageSource? base64,
            global::G.BetaURLImageSource? url
            )
        {
            Type = type;

            Base64 = base64;
            Url = url;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Url as object ??
            Base64 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base64?.ToString() ??
            Url?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase64 && !IsUrl || !IsBase64 && IsUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BetaBase64ImageSource?, TResult>? base64 = null,
            global::System.Func<global::G.BetaURLImageSource?, TResult>? url = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase64 && base64 != null)
            {
                return base64(Base64!);
            }
            else if (IsUrl && url != null)
            {
                return url(Url!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BetaBase64ImageSource?>? base64 = null,
            global::System.Action<global::G.BetaURLImageSource?>? url = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase64)
            {
                base64?.Invoke(Base64!);
            }
            else if (IsUrl)
            {
                url?.Invoke(Url!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base64,
                typeof(global::G.BetaBase64ImageSource),
                Url,
                typeof(global::G.BetaURLImageSource),
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
        public bool Equals(Source2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BetaBase64ImageSource?>.Default.Equals(Base64, other.Base64) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaURLImageSource?>.Default.Equals(Url, other.Url) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Source2 obj1, Source2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Source2 obj1, Source2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source2 o && Equals(o);
        }
    }
}
