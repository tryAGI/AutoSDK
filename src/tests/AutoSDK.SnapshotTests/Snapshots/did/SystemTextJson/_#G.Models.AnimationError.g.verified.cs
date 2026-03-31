//HintName: G.Models.AnimationError.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnimationError : global::System.IEquatable<AnimationError>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AnimationErrorVariant1? Value1 { get; init; }
#else
        public global::G.AnimationErrorVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AnimationErrorVariant2? Value2 { get; init; }
#else
        public global::G.AnimationErrorVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AnimationErrorVariant3? Value3 { get; init; }
#else
        public global::G.AnimationErrorVariant3? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AnimationErrorVariant4? Value4 { get; init; }
#else
        public global::G.AnimationErrorVariant4? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AnimationErrorVariant5? Value5 { get; init; }
#else
        public global::G.AnimationErrorVariant5? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AnimationErrorVariant6? Value6 { get; init; }
#else
        public global::G.AnimationErrorVariant6? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnimationError(global::G.AnimationErrorVariant1 value) => new AnimationError((global::G.AnimationErrorVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnimationErrorVariant1?(AnimationError @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public AnimationError(global::G.AnimationErrorVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnimationError(global::G.AnimationErrorVariant2 value) => new AnimationError((global::G.AnimationErrorVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnimationErrorVariant2?(AnimationError @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public AnimationError(global::G.AnimationErrorVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnimationError(global::G.AnimationErrorVariant3 value) => new AnimationError((global::G.AnimationErrorVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnimationErrorVariant3?(AnimationError @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public AnimationError(global::G.AnimationErrorVariant3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnimationError(global::G.AnimationErrorVariant4 value) => new AnimationError((global::G.AnimationErrorVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnimationErrorVariant4?(AnimationError @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public AnimationError(global::G.AnimationErrorVariant4? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnimationError(global::G.AnimationErrorVariant5 value) => new AnimationError((global::G.AnimationErrorVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnimationErrorVariant5?(AnimationError @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public AnimationError(global::G.AnimationErrorVariant5? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnimationError(global::G.AnimationErrorVariant6 value) => new AnimationError((global::G.AnimationErrorVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnimationErrorVariant6?(AnimationError @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public AnimationError(global::G.AnimationErrorVariant6? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnimationError(
            global::G.AnimationErrorVariant1? value1,
            global::G.AnimationErrorVariant2? value2,
            global::G.AnimationErrorVariant3? value3,
            global::G.AnimationErrorVariant4? value4,
            global::G.AnimationErrorVariant5? value5,
            global::G.AnimationErrorVariant6? value6
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value6 as object ??
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() ??
            Value5?.ToString() ??
            Value6?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4 || IsValue5 || IsValue6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AnimationErrorVariant1?, TResult>? value1 = null,
            global::System.Func<global::G.AnimationErrorVariant2?, TResult>? value2 = null,
            global::System.Func<global::G.AnimationErrorVariant3?, TResult>? value3 = null,
            global::System.Func<global::G.AnimationErrorVariant4?, TResult>? value4 = null,
            global::System.Func<global::G.AnimationErrorVariant5?, TResult>? value5 = null,
            global::System.Func<global::G.AnimationErrorVariant6?, TResult>? value6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }
            else if (IsValue6 && value6 != null)
            {
                return value6(Value6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AnimationErrorVariant1?>? value1 = null,
            global::System.Action<global::G.AnimationErrorVariant2?>? value2 = null,
            global::System.Action<global::G.AnimationErrorVariant3?>? value3 = null,
            global::System.Action<global::G.AnimationErrorVariant4?>? value4 = null,
            global::System.Action<global::G.AnimationErrorVariant5?>? value5 = null,
            global::System.Action<global::G.AnimationErrorVariant6?>? value6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.AnimationErrorVariant1),
                Value2,
                typeof(global::G.AnimationErrorVariant2),
                Value3,
                typeof(global::G.AnimationErrorVariant3),
                Value4,
                typeof(global::G.AnimationErrorVariant4),
                Value5,
                typeof(global::G.AnimationErrorVariant5),
                Value6,
                typeof(global::G.AnimationErrorVariant6),
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
        public bool Equals(AnimationError other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AnimationErrorVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AnimationErrorVariant2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AnimationErrorVariant3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AnimationErrorVariant4?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AnimationErrorVariant5?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AnimationErrorVariant6?>.Default.Equals(Value6, other.Value6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnimationError obj1, AnimationError obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnimationError>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnimationError obj1, AnimationError obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnimationError o && Equals(o);
        }
    }
}
