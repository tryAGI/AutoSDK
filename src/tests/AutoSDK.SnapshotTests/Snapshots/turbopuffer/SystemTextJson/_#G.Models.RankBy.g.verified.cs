//HintName: G.Models.RankBy.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RankBy : global::System.IEquatable<RankBy>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Vector { get; init; }
#else
        public byte[]? Vector { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Vector))]
#endif
        public bool IsVector => Vector != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Knn { get; init; }
#else
        public byte[]? Knn { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Knn))]
#endif
        public bool IsKnn => Knn != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RankByText? Text { get; init; }
#else
        public global::G.RankByText? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Attribute { get; init; }
#else
        public byte[]? Attribute { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Attribute))]
#endif
        public bool IsAttribute => Attribute != null;

        /// <summary>
        /// Order by multiple attributes. Results are sorted by the first attribute, then by the second attribute for ties, and so on.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<byte[]>? Attributes { get; init; }
#else
        public global::System.Collections.Generic.IList<byte[]>? Attributes { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Attributes))]
#endif
        public bool IsAttributes => Attributes != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RankBy(byte[] value) => new RankBy((byte[]?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator byte[]?(RankBy @this) => @this.Vector;

        /// <summary>
        /// 
        /// </summary>
        public RankBy(byte[]? value)
        {
            Vector = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RankBy(global::G.RankByText value) => new RankBy((global::G.RankByText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RankByText?(RankBy @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public RankBy(global::G.RankByText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RankBy(
            byte[]? vector,
            byte[]? knn,
            global::G.RankByText? text,
            byte[]? attribute,
            global::System.Collections.Generic.IList<byte[]>? attributes
            )
        {
            Vector = vector;
            Knn = knn;
            Text = text;
            Attribute = attribute;
            Attributes = attributes;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Attributes as object ??
            Attribute as object ??
            Text as object ??
            Knn as object ??
            Vector as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Vector?.ToString() ??
            Knn?.ToString() ??
            Text?.ToString() ??
            Attribute?.ToString() ??
            Attributes?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVector || IsKnn || IsText || IsAttribute || IsAttributes;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<byte[]?, TResult>? vector = null,
            global::System.Func<byte[]?, TResult>? knn = null,
            global::System.Func<global::G.RankByText?, TResult>? text = null,
            global::System.Func<byte[]?, TResult>? attribute = null,
            global::System.Func<global::System.Collections.Generic.IList<byte[]>?, TResult>? attributes = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVector && vector != null)
            {
                return vector(Vector!);
            }
            else if (IsKnn && knn != null)
            {
                return knn(Knn!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsAttribute && attribute != null)
            {
                return attribute(Attribute!);
            }
            else if (IsAttributes && attributes != null)
            {
                return attributes(Attributes!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<byte[]?>? vector = null,
            global::System.Action<byte[]?>? knn = null,
            global::System.Action<global::G.RankByText?>? text = null,
            global::System.Action<byte[]?>? attribute = null,
            global::System.Action<global::System.Collections.Generic.IList<byte[]>?>? attributes = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVector)
            {
                vector?.Invoke(Vector!);
            }
            else if (IsKnn)
            {
                knn?.Invoke(Knn!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsAttribute)
            {
                attribute?.Invoke(Attribute!);
            }
            else if (IsAttributes)
            {
                attributes?.Invoke(Attributes!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Vector,
                typeof(byte[]),
                Knn,
                typeof(byte[]),
                Text,
                typeof(global::G.RankByText),
                Attribute,
                typeof(byte[]),
                Attributes,
                typeof(global::System.Collections.Generic.IList<byte[]>),
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
        public bool Equals(RankBy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Vector, other.Vector) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Knn, other.Knn) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RankByText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Attribute, other.Attribute) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<byte[]>?>.Default.Equals(Attributes, other.Attributes) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RankBy obj1, RankBy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RankBy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RankBy obj1, RankBy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RankBy o && Equals(o);
        }
    }
}
