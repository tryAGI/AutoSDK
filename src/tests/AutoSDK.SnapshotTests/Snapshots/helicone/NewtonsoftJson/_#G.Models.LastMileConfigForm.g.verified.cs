//HintName: G.Models.LastMileConfigForm.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LastMileConfigForm : global::System.IEquatable<LastMileConfigForm>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseLastMileConfigForm? Base { get; init; }
#else
        public global::G.BaseLastMileConfigForm? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AnyOf<global::G.LastMileConfigFormVariant2Variant1, global::G.LastMileConfigFormVariant2Variant2>? LastMileConfigFormVariant2 { get; init; }
#else
        public global::G.AnyOf<global::G.LastMileConfigFormVariant2Variant1, global::G.LastMileConfigFormVariant2Variant2>? LastMileConfigFormVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LastMileConfigFormVariant2))]
#endif
        public bool IsLastMileConfigFormVariant2 => LastMileConfigFormVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LastMileConfigForm(global::G.BaseLastMileConfigForm value) => new LastMileConfigForm((global::G.BaseLastMileConfigForm?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseLastMileConfigForm?(LastMileConfigForm @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public LastMileConfigForm(global::G.BaseLastMileConfigForm? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LastMileConfigForm(global::G.AnyOf<global::G.LastMileConfigFormVariant2Variant1, global::G.LastMileConfigFormVariant2Variant2> value) => new LastMileConfigForm((global::G.AnyOf<global::G.LastMileConfigFormVariant2Variant1, global::G.LastMileConfigFormVariant2Variant2>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnyOf<global::G.LastMileConfigFormVariant2Variant1, global::G.LastMileConfigFormVariant2Variant2>?(LastMileConfigForm @this) => @this.LastMileConfigFormVariant2;

        /// <summary>
        /// 
        /// </summary>
        public LastMileConfigForm(global::G.AnyOf<global::G.LastMileConfigFormVariant2Variant1, global::G.LastMileConfigFormVariant2Variant2>? value)
        {
            LastMileConfigFormVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LastMileConfigForm(
            global::G.BaseLastMileConfigForm? @base,
            global::G.AnyOf<global::G.LastMileConfigFormVariant2Variant1, global::G.LastMileConfigFormVariant2Variant2>? lastMileConfigFormVariant2
            )
        {
            Base = @base;
            LastMileConfigFormVariant2 = lastMileConfigFormVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LastMileConfigFormVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            LastMileConfigFormVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsLastMileConfigFormVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseLastMileConfigForm?, TResult>? @base = null,
            global::System.Func<global::G.AnyOf<global::G.LastMileConfigFormVariant2Variant1, global::G.LastMileConfigFormVariant2Variant2>?, TResult>? lastMileConfigFormVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsLastMileConfigFormVariant2 && lastMileConfigFormVariant2 != null)
            {
                return lastMileConfigFormVariant2(LastMileConfigFormVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseLastMileConfigForm?>? @base = null,
            global::System.Action<global::G.AnyOf<global::G.LastMileConfigFormVariant2Variant1, global::G.LastMileConfigFormVariant2Variant2>?>? lastMileConfigFormVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsLastMileConfigFormVariant2)
            {
                lastMileConfigFormVariant2?.Invoke(LastMileConfigFormVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::G.BaseLastMileConfigForm),
                LastMileConfigFormVariant2,
                typeof(global::G.AnyOf<global::G.LastMileConfigFormVariant2Variant1, global::G.LastMileConfigFormVariant2Variant2>),
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
        public bool Equals(LastMileConfigForm other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseLastMileConfigForm?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AnyOf<global::G.LastMileConfigFormVariant2Variant1, global::G.LastMileConfigFormVariant2Variant2>?>.Default.Equals(LastMileConfigFormVariant2, other.LastMileConfigFormVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LastMileConfigForm obj1, LastMileConfigForm obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LastMileConfigForm>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LastMileConfigForm obj1, LastMileConfigForm obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LastMileConfigForm o && Equals(o);
        }
    }
}
