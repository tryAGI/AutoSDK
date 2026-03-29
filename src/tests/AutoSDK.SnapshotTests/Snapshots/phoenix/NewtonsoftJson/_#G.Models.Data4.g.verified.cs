//HintName: G.Models.Data4.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Data4 : global::System.IEquatable<Data4>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAnnotationConfigResponseBodyDataDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CategoricalAnnotationConfig? Categorical { get; init; }
#else
        public global::G.CategoricalAnnotationConfig? Categorical { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Categorical))]
#endif
        public bool IsCategorical => Categorical != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ContinuousAnnotationConfig? Continuous { get; init; }
#else
        public global::G.ContinuousAnnotationConfig? Continuous { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Continuous))]
#endif
        public bool IsContinuous => Continuous != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FreeformAnnotationConfig? Freeform { get; init; }
#else
        public global::G.FreeformAnnotationConfig? Freeform { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Freeform))]
#endif
        public bool IsFreeform => Freeform != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data4(global::G.CategoricalAnnotationConfig value) => new Data4((global::G.CategoricalAnnotationConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CategoricalAnnotationConfig?(Data4 @this) => @this.Categorical;

        /// <summary>
        /// 
        /// </summary>
        public Data4(global::G.CategoricalAnnotationConfig? value)
        {
            Categorical = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data4(global::G.ContinuousAnnotationConfig value) => new Data4((global::G.ContinuousAnnotationConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContinuousAnnotationConfig?(Data4 @this) => @this.Continuous;

        /// <summary>
        /// 
        /// </summary>
        public Data4(global::G.ContinuousAnnotationConfig? value)
        {
            Continuous = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data4(global::G.FreeformAnnotationConfig value) => new Data4((global::G.FreeformAnnotationConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FreeformAnnotationConfig?(Data4 @this) => @this.Freeform;

        /// <summary>
        /// 
        /// </summary>
        public Data4(global::G.FreeformAnnotationConfig? value)
        {
            Freeform = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Data4(
            global::G.GetAnnotationConfigResponseBodyDataDiscriminatorType? type,
            global::G.CategoricalAnnotationConfig? categorical,
            global::G.ContinuousAnnotationConfig? continuous,
            global::G.FreeformAnnotationConfig? freeform
            )
        {
            Type = type;

            Categorical = categorical;
            Continuous = continuous;
            Freeform = freeform;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Freeform as object ??
            Continuous as object ??
            Categorical as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Categorical?.ToString() ??
            Continuous?.ToString() ??
            Freeform?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCategorical && !IsContinuous && !IsFreeform || !IsCategorical && IsContinuous && !IsFreeform || !IsCategorical && !IsContinuous && IsFreeform;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CategoricalAnnotationConfig?, TResult>? categorical = null,
            global::System.Func<global::G.ContinuousAnnotationConfig?, TResult>? continuous = null,
            global::System.Func<global::G.FreeformAnnotationConfig?, TResult>? freeform = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCategorical && categorical != null)
            {
                return categorical(Categorical!);
            }
            else if (IsContinuous && continuous != null)
            {
                return continuous(Continuous!);
            }
            else if (IsFreeform && freeform != null)
            {
                return freeform(Freeform!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CategoricalAnnotationConfig?>? categorical = null,
            global::System.Action<global::G.ContinuousAnnotationConfig?>? continuous = null,
            global::System.Action<global::G.FreeformAnnotationConfig?>? freeform = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCategorical)
            {
                categorical?.Invoke(Categorical!);
            }
            else if (IsContinuous)
            {
                continuous?.Invoke(Continuous!);
            }
            else if (IsFreeform)
            {
                freeform?.Invoke(Freeform!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Categorical,
                typeof(global::G.CategoricalAnnotationConfig),
                Continuous,
                typeof(global::G.ContinuousAnnotationConfig),
                Freeform,
                typeof(global::G.FreeformAnnotationConfig),
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
        public bool Equals(Data4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CategoricalAnnotationConfig?>.Default.Equals(Categorical, other.Categorical) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContinuousAnnotationConfig?>.Default.Equals(Continuous, other.Continuous) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FreeformAnnotationConfig?>.Default.Equals(Freeform, other.Freeform) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Data4 obj1, Data4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Data4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Data4 obj1, Data4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Data4 o && Equals(o);
        }
    }
}
