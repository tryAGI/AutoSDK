//HintName: G.Models.Source.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The source of the image.
    /// </summary>
    public readonly partial struct Source : global::System.IEquatable<Source>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ImageContentSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UrlImage? Url { get; init; }
#else
        public global::G.UrlImage? Url { get; }
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
#if NET6_0_OR_GREATER
        public global::G.Base64Image? Base64 { get; init; }
#else
        public global::G.Base64Image? Base64 { get; }
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
#if NET6_0_OR_GREATER
        public global::G.LettaImage? Letta { get; init; }
#else
        public global::G.LettaImage? Letta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Letta))]
#endif
        public bool IsLetta => Letta != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::G.UrlImage value) => new Source((global::G.UrlImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UrlImage?(Source @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::G.UrlImage? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::G.Base64Image value) => new Source((global::G.Base64Image?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Base64Image?(Source @this) => @this.Base64;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::G.Base64Image? value)
        {
            Base64 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Source(global::G.LettaImage value) => new Source((global::G.LettaImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LettaImage?(Source @this) => @this.Letta;

        /// <summary>
        /// 
        /// </summary>
        public Source(global::G.LettaImage? value)
        {
            Letta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Source(
            global::G.ImageContentSourceDiscriminatorType? type,
            global::G.UrlImage? url,
            global::G.Base64Image? base64,
            global::G.LettaImage? letta
            )
        {
            Type = type;

            Url = url;
            Base64 = base64;
            Letta = letta;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Letta as object ??
            Base64 as object ??
            Url as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Url?.ToString() ??
            Base64?.ToString() ??
            Letta?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUrl && !IsBase64 && !IsLetta || !IsUrl && IsBase64 && !IsLetta || !IsUrl && !IsBase64 && IsLetta;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.UrlImage?, TResult>? url = null,
            global::System.Func<global::G.Base64Image?, TResult>? base64 = null,
            global::System.Func<global::G.LettaImage?, TResult>? letta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUrl && url != null)
            {
                return url(Url!);
            }
            else if (IsBase64 && base64 != null)
            {
                return base64(Base64!);
            }
            else if (IsLetta && letta != null)
            {
                return letta(Letta!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.UrlImage?>? url = null,
            global::System.Action<global::G.Base64Image?>? base64 = null,
            global::System.Action<global::G.LettaImage?>? letta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUrl)
            {
                url?.Invoke(Url!);
            }
            else if (IsBase64)
            {
                base64?.Invoke(Base64!);
            }
            else if (IsLetta)
            {
                letta?.Invoke(Letta!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Url,
                typeof(global::G.UrlImage),
                Base64,
                typeof(global::G.Base64Image),
                Letta,
                typeof(global::G.LettaImage),
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
        public bool Equals(Source other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.UrlImage?>.Default.Equals(Url, other.Url) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Base64Image?>.Default.Equals(Base64, other.Base64) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LettaImage?>.Default.Equals(Letta, other.Letta) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Source obj1, Source obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Source obj1, Source obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source o && Equals(o);
        }
    }
}
