//HintName: G.Models.CreateAnnotationConfigData.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateAnnotationConfigData : global::System.IEquatable<CreateAnnotationConfigData>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAnnotationConfigDataDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CategoricalAnnotationConfigData? Categorical { get; init; }
#else
        public global::G.CategoricalAnnotationConfigData? Categorical { get; }
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
        public global::G.ContinuousAnnotationConfigData? Continuous { get; init; }
#else
        public global::G.ContinuousAnnotationConfigData? Continuous { get; }
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
        public global::G.FreeformAnnotationConfigData? Freeform { get; init; }
#else
        public global::G.FreeformAnnotationConfigData? Freeform { get; }
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
        public static implicit operator CreateAnnotationConfigData(global::G.CategoricalAnnotationConfigData value) => new CreateAnnotationConfigData((global::G.CategoricalAnnotationConfigData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CategoricalAnnotationConfigData?(CreateAnnotationConfigData @this) => @this.Categorical;

        /// <summary>
        /// 
        /// </summary>
        public CreateAnnotationConfigData(global::G.CategoricalAnnotationConfigData? value)
        {
            Categorical = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAnnotationConfigData(global::G.ContinuousAnnotationConfigData value) => new CreateAnnotationConfigData((global::G.ContinuousAnnotationConfigData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContinuousAnnotationConfigData?(CreateAnnotationConfigData @this) => @this.Continuous;

        /// <summary>
        /// 
        /// </summary>
        public CreateAnnotationConfigData(global::G.ContinuousAnnotationConfigData? value)
        {
            Continuous = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAnnotationConfigData(global::G.FreeformAnnotationConfigData value) => new CreateAnnotationConfigData((global::G.FreeformAnnotationConfigData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FreeformAnnotationConfigData?(CreateAnnotationConfigData @this) => @this.Freeform;

        /// <summary>
        /// 
        /// </summary>
        public CreateAnnotationConfigData(global::G.FreeformAnnotationConfigData? value)
        {
            Freeform = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateAnnotationConfigData(
            global::G.CreateAnnotationConfigDataDiscriminatorType? type,
            global::G.CategoricalAnnotationConfigData? categorical,
            global::G.ContinuousAnnotationConfigData? continuous,
            global::G.FreeformAnnotationConfigData? freeform
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
            global::System.Func<global::G.CategoricalAnnotationConfigData?, TResult>? categorical = null,
            global::System.Func<global::G.ContinuousAnnotationConfigData?, TResult>? continuous = null,
            global::System.Func<global::G.FreeformAnnotationConfigData?, TResult>? freeform = null,
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
            global::System.Action<global::G.CategoricalAnnotationConfigData?>? categorical = null,
            global::System.Action<global::G.ContinuousAnnotationConfigData?>? continuous = null,
            global::System.Action<global::G.FreeformAnnotationConfigData?>? freeform = null,
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
                typeof(global::G.CategoricalAnnotationConfigData),
                Continuous,
                typeof(global::G.ContinuousAnnotationConfigData),
                Freeform,
                typeof(global::G.FreeformAnnotationConfigData),
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
        public bool Equals(CreateAnnotationConfigData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CategoricalAnnotationConfigData?>.Default.Equals(Categorical, other.Categorical) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContinuousAnnotationConfigData?>.Default.Equals(Continuous, other.Continuous) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FreeformAnnotationConfigData?>.Default.Equals(Freeform, other.Freeform) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateAnnotationConfigData obj1, CreateAnnotationConfigData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateAnnotationConfigData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateAnnotationConfigData obj1, CreateAnnotationConfigData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateAnnotationConfigData o && Equals(o);
        }
    }
}
