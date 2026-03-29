//HintName: G.Models.ModelChoice.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ModelChoice : global::System.IEquatable<ModelChoice>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelChoiceCascading? Cascading { get; init; }
#else
        public global::G.ModelChoiceCascading? Cascading { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cascading))]
#endif
        public bool IsCascading => Cascading != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelChoice(global::G.ModelChoiceCascading value) => new ModelChoice((global::G.ModelChoiceCascading?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelChoiceCascading?(ModelChoice @this) => @this.Cascading;

        /// <summary>
        /// 
        /// </summary>
        public ModelChoice(global::G.ModelChoiceCascading? value)
        {
            Cascading = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Cascading as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Cascading?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCascading;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ModelChoiceCascading?, TResult>? cascading = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCascading && cascading != null)
            {
                return cascading(Cascading!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ModelChoiceCascading?>? cascading = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCascading)
            {
                cascading?.Invoke(Cascading!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Cascading,
                typeof(global::G.ModelChoiceCascading),
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
        public bool Equals(ModelChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ModelChoiceCascading?>.Default.Equals(Cascading, other.Cascading) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ModelChoice obj1, ModelChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ModelChoice obj1, ModelChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelChoice o && Equals(o);
        }
    }
}
