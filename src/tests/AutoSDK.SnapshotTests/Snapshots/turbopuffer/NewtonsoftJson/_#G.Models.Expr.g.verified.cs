//HintName: G.Models.Expr.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An expression that can be used in a filter.
    /// </summary>
    public readonly partial struct Expr : global::System.IEquatable<Expr>
    {
        /// <summary>
        /// A reference to an attribute in a new document.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExprRefNew? RefNew { get; init; }
#else
        public global::G.ExprRefNew? RefNew { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefNew))]
#endif
        public bool IsRefNew => RefNew != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Expr(global::G.ExprRefNew value) => new Expr((global::G.ExprRefNew?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExprRefNew?(Expr @this) => @this.RefNew;

        /// <summary>
        /// 
        /// </summary>
        public Expr(global::G.ExprRefNew? value)
        {
            RefNew = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RefNew as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RefNew?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRefNew;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ExprRefNew?, TResult>? refNew = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRefNew && refNew != null)
            {
                return refNew(RefNew!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ExprRefNew?>? refNew = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRefNew)
            {
                refNew?.Invoke(RefNew!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RefNew,
                typeof(global::G.ExprRefNew),
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
        public bool Equals(Expr other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ExprRefNew?>.Default.Equals(RefNew, other.RefNew) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Expr obj1, Expr obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Expr>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Expr obj1, Expr obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Expr o && Equals(o);
        }
    }
}
