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
        public global::G.AnimationErrorVariant1? AnimationErrorVariant1 { get; init; }
#else
        public global::G.AnimationErrorVariant1? AnimationErrorVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnimationErrorVariant1))]
#endif
        public bool IsAnimationErrorVariant1 => AnimationErrorVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AnimationErrorVariant2? AnimationErrorVariant2 { get; init; }
#else
        public global::G.AnimationErrorVariant2? AnimationErrorVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnimationErrorVariant2))]
#endif
        public bool IsAnimationErrorVariant2 => AnimationErrorVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AnimationErrorVariant3? AnimationErrorVariant3 { get; init; }
#else
        public global::G.AnimationErrorVariant3? AnimationErrorVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnimationErrorVariant3))]
#endif
        public bool IsAnimationErrorVariant3 => AnimationErrorVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AnimationErrorVariant4? AnimationErrorVariant4 { get; init; }
#else
        public global::G.AnimationErrorVariant4? AnimationErrorVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnimationErrorVariant4))]
#endif
        public bool IsAnimationErrorVariant4 => AnimationErrorVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AnimationErrorVariant5? AnimationErrorVariant5 { get; init; }
#else
        public global::G.AnimationErrorVariant5? AnimationErrorVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnimationErrorVariant5))]
#endif
        public bool IsAnimationErrorVariant5 => AnimationErrorVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AnimationErrorVariant6? AnimationErrorVariant6 { get; init; }
#else
        public global::G.AnimationErrorVariant6? AnimationErrorVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnimationErrorVariant6))]
#endif
        public bool IsAnimationErrorVariant6 => AnimationErrorVariant6 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnimationError(global::G.AnimationErrorVariant1 value) => new AnimationError((global::G.AnimationErrorVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnimationErrorVariant1?(AnimationError @this) => @this.AnimationErrorVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AnimationError(global::G.AnimationErrorVariant1? value)
        {
            AnimationErrorVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnimationError(global::G.AnimationErrorVariant2 value) => new AnimationError((global::G.AnimationErrorVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnimationErrorVariant2?(AnimationError @this) => @this.AnimationErrorVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AnimationError(global::G.AnimationErrorVariant2? value)
        {
            AnimationErrorVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnimationError(global::G.AnimationErrorVariant3 value) => new AnimationError((global::G.AnimationErrorVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnimationErrorVariant3?(AnimationError @this) => @this.AnimationErrorVariant3;

        /// <summary>
        /// 
        /// </summary>
        public AnimationError(global::G.AnimationErrorVariant3? value)
        {
            AnimationErrorVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnimationError(global::G.AnimationErrorVariant4 value) => new AnimationError((global::G.AnimationErrorVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnimationErrorVariant4?(AnimationError @this) => @this.AnimationErrorVariant4;

        /// <summary>
        /// 
        /// </summary>
        public AnimationError(global::G.AnimationErrorVariant4? value)
        {
            AnimationErrorVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnimationError(global::G.AnimationErrorVariant5 value) => new AnimationError((global::G.AnimationErrorVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnimationErrorVariant5?(AnimationError @this) => @this.AnimationErrorVariant5;

        /// <summary>
        /// 
        /// </summary>
        public AnimationError(global::G.AnimationErrorVariant5? value)
        {
            AnimationErrorVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnimationError(global::G.AnimationErrorVariant6 value) => new AnimationError((global::G.AnimationErrorVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AnimationErrorVariant6?(AnimationError @this) => @this.AnimationErrorVariant6;

        /// <summary>
        /// 
        /// </summary>
        public AnimationError(global::G.AnimationErrorVariant6? value)
        {
            AnimationErrorVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnimationError(
            global::G.AnimationErrorVariant1? animationErrorVariant1,
            global::G.AnimationErrorVariant2? animationErrorVariant2,
            global::G.AnimationErrorVariant3? animationErrorVariant3,
            global::G.AnimationErrorVariant4? animationErrorVariant4,
            global::G.AnimationErrorVariant5? animationErrorVariant5,
            global::G.AnimationErrorVariant6? animationErrorVariant6
            )
        {
            AnimationErrorVariant1 = animationErrorVariant1;
            AnimationErrorVariant2 = animationErrorVariant2;
            AnimationErrorVariant3 = animationErrorVariant3;
            AnimationErrorVariant4 = animationErrorVariant4;
            AnimationErrorVariant5 = animationErrorVariant5;
            AnimationErrorVariant6 = animationErrorVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnimationErrorVariant6 as object ??
            AnimationErrorVariant5 as object ??
            AnimationErrorVariant4 as object ??
            AnimationErrorVariant3 as object ??
            AnimationErrorVariant2 as object ??
            AnimationErrorVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnimationErrorVariant1?.ToString() ??
            AnimationErrorVariant2?.ToString() ??
            AnimationErrorVariant3?.ToString() ??
            AnimationErrorVariant4?.ToString() ??
            AnimationErrorVariant5?.ToString() ??
            AnimationErrorVariant6?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnimationErrorVariant1 || IsAnimationErrorVariant2 || IsAnimationErrorVariant3 || IsAnimationErrorVariant4 || IsAnimationErrorVariant5 || IsAnimationErrorVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AnimationErrorVariant1?, TResult>? animationErrorVariant1 = null,
            global::System.Func<global::G.AnimationErrorVariant2?, TResult>? animationErrorVariant2 = null,
            global::System.Func<global::G.AnimationErrorVariant3?, TResult>? animationErrorVariant3 = null,
            global::System.Func<global::G.AnimationErrorVariant4?, TResult>? animationErrorVariant4 = null,
            global::System.Func<global::G.AnimationErrorVariant5?, TResult>? animationErrorVariant5 = null,
            global::System.Func<global::G.AnimationErrorVariant6?, TResult>? animationErrorVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnimationErrorVariant1 && animationErrorVariant1 != null)
            {
                return animationErrorVariant1(AnimationErrorVariant1!);
            }
            else if (IsAnimationErrorVariant2 && animationErrorVariant2 != null)
            {
                return animationErrorVariant2(AnimationErrorVariant2!);
            }
            else if (IsAnimationErrorVariant3 && animationErrorVariant3 != null)
            {
                return animationErrorVariant3(AnimationErrorVariant3!);
            }
            else if (IsAnimationErrorVariant4 && animationErrorVariant4 != null)
            {
                return animationErrorVariant4(AnimationErrorVariant4!);
            }
            else if (IsAnimationErrorVariant5 && animationErrorVariant5 != null)
            {
                return animationErrorVariant5(AnimationErrorVariant5!);
            }
            else if (IsAnimationErrorVariant6 && animationErrorVariant6 != null)
            {
                return animationErrorVariant6(AnimationErrorVariant6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AnimationErrorVariant1?>? animationErrorVariant1 = null,
            global::System.Action<global::G.AnimationErrorVariant2?>? animationErrorVariant2 = null,
            global::System.Action<global::G.AnimationErrorVariant3?>? animationErrorVariant3 = null,
            global::System.Action<global::G.AnimationErrorVariant4?>? animationErrorVariant4 = null,
            global::System.Action<global::G.AnimationErrorVariant5?>? animationErrorVariant5 = null,
            global::System.Action<global::G.AnimationErrorVariant6?>? animationErrorVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnimationErrorVariant1)
            {
                animationErrorVariant1?.Invoke(AnimationErrorVariant1!);
            }
            else if (IsAnimationErrorVariant2)
            {
                animationErrorVariant2?.Invoke(AnimationErrorVariant2!);
            }
            else if (IsAnimationErrorVariant3)
            {
                animationErrorVariant3?.Invoke(AnimationErrorVariant3!);
            }
            else if (IsAnimationErrorVariant4)
            {
                animationErrorVariant4?.Invoke(AnimationErrorVariant4!);
            }
            else if (IsAnimationErrorVariant5)
            {
                animationErrorVariant5?.Invoke(AnimationErrorVariant5!);
            }
            else if (IsAnimationErrorVariant6)
            {
                animationErrorVariant6?.Invoke(AnimationErrorVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnimationErrorVariant1,
                typeof(global::G.AnimationErrorVariant1),
                AnimationErrorVariant2,
                typeof(global::G.AnimationErrorVariant2),
                AnimationErrorVariant3,
                typeof(global::G.AnimationErrorVariant3),
                AnimationErrorVariant4,
                typeof(global::G.AnimationErrorVariant4),
                AnimationErrorVariant5,
                typeof(global::G.AnimationErrorVariant5),
                AnimationErrorVariant6,
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
                global::System.Collections.Generic.EqualityComparer<global::G.AnimationErrorVariant1?>.Default.Equals(AnimationErrorVariant1, other.AnimationErrorVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AnimationErrorVariant2?>.Default.Equals(AnimationErrorVariant2, other.AnimationErrorVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AnimationErrorVariant3?>.Default.Equals(AnimationErrorVariant3, other.AnimationErrorVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AnimationErrorVariant4?>.Default.Equals(AnimationErrorVariant4, other.AnimationErrorVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AnimationErrorVariant5?>.Default.Equals(AnimationErrorVariant5, other.AnimationErrorVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AnimationErrorVariant6?>.Default.Equals(AnimationErrorVariant6, other.AnimationErrorVariant6) 
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
