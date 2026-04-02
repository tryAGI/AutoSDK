//HintName: G.Models.EasyInputMessagePhase.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The phase of an assistant message. Use `commentary` for an intermediate assistant message and `final_answer` for the final assistant message. For follow-up requests with models like `gpt-5.3-codex` and later, preserve and resend phase on all assistant messages. Omitting it can degrade performance. Not used for user messages.
    /// </summary>
    public readonly partial struct EasyInputMessagePhase : global::System.IEquatable<EasyInputMessagePhase>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EasyInputMessagePhase0? EasyInputMessagePhase0 { get; init; }
#else
        public global::G.EasyInputMessagePhase0? EasyInputMessagePhase0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EasyInputMessagePhase0))]
#endif
        public bool IsEasyInputMessagePhase0 => EasyInputMessagePhase0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EasyInputMessagePhase1? EasyInputMessagePhase1 { get; init; }
#else
        public global::G.EasyInputMessagePhase1? EasyInputMessagePhase1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EasyInputMessagePhase1))]
#endif
        public bool IsEasyInputMessagePhase1 => EasyInputMessagePhase1 != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? EasyInputMessagePhaseVariant3 { get; init; }
#else
        public object? EasyInputMessagePhaseVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EasyInputMessagePhaseVariant3))]
#endif
        public bool IsEasyInputMessagePhaseVariant3 => EasyInputMessagePhaseVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EasyInputMessagePhase(global::G.EasyInputMessagePhase0 value) => new EasyInputMessagePhase((global::G.EasyInputMessagePhase0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EasyInputMessagePhase0?(EasyInputMessagePhase @this) => @this.EasyInputMessagePhase0;

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessagePhase(global::G.EasyInputMessagePhase0? value)
        {
            EasyInputMessagePhase0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EasyInputMessagePhase(global::G.EasyInputMessagePhase1 value) => new EasyInputMessagePhase((global::G.EasyInputMessagePhase1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EasyInputMessagePhase1?(EasyInputMessagePhase @this) => @this.EasyInputMessagePhase1;

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessagePhase(global::G.EasyInputMessagePhase1? value)
        {
            EasyInputMessagePhase1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessagePhase(
            global::G.EasyInputMessagePhase0? easyInputMessagePhase0,
            global::G.EasyInputMessagePhase1? easyInputMessagePhase1,
            object? easyInputMessagePhaseVariant3
            )
        {
            EasyInputMessagePhase0 = easyInputMessagePhase0;
            EasyInputMessagePhase1 = easyInputMessagePhase1;
            EasyInputMessagePhaseVariant3 = easyInputMessagePhaseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EasyInputMessagePhaseVariant3 as object ??
            EasyInputMessagePhase1 as object ??
            EasyInputMessagePhase0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EasyInputMessagePhase0?.ToValueString() ??
            EasyInputMessagePhase1?.ToValueString() ??
            EasyInputMessagePhaseVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEasyInputMessagePhase0 && !IsEasyInputMessagePhase1 && !IsEasyInputMessagePhaseVariant3 || !IsEasyInputMessagePhase0 && IsEasyInputMessagePhase1 && !IsEasyInputMessagePhaseVariant3 || !IsEasyInputMessagePhase0 && !IsEasyInputMessagePhase1 && IsEasyInputMessagePhaseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.EasyInputMessagePhase0?, TResult>? easyInputMessagePhase0 = null,
            global::System.Func<global::G.EasyInputMessagePhase1?, TResult>? easyInputMessagePhase1 = null,
            global::System.Func<object?, TResult>? easyInputMessagePhaseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEasyInputMessagePhase0 && easyInputMessagePhase0 != null)
            {
                return easyInputMessagePhase0(EasyInputMessagePhase0!);
            }
            else if (IsEasyInputMessagePhase1 && easyInputMessagePhase1 != null)
            {
                return easyInputMessagePhase1(EasyInputMessagePhase1!);
            }
            else if (IsEasyInputMessagePhaseVariant3 && easyInputMessagePhaseVariant3 != null)
            {
                return easyInputMessagePhaseVariant3(EasyInputMessagePhaseVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.EasyInputMessagePhase0?>? easyInputMessagePhase0 = null,
            global::System.Action<global::G.EasyInputMessagePhase1?>? easyInputMessagePhase1 = null,
            global::System.Action<object?>? easyInputMessagePhaseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEasyInputMessagePhase0)
            {
                easyInputMessagePhase0?.Invoke(EasyInputMessagePhase0!);
            }
            else if (IsEasyInputMessagePhase1)
            {
                easyInputMessagePhase1?.Invoke(EasyInputMessagePhase1!);
            }
            else if (IsEasyInputMessagePhaseVariant3)
            {
                easyInputMessagePhaseVariant3?.Invoke(EasyInputMessagePhaseVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EasyInputMessagePhase0,
                typeof(global::G.EasyInputMessagePhase0),
                EasyInputMessagePhase1,
                typeof(global::G.EasyInputMessagePhase1),
                EasyInputMessagePhaseVariant3,
                typeof(object),
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
        public bool Equals(EasyInputMessagePhase other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.EasyInputMessagePhase0?>.Default.Equals(EasyInputMessagePhase0, other.EasyInputMessagePhase0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EasyInputMessagePhase1?>.Default.Equals(EasyInputMessagePhase1, other.EasyInputMessagePhase1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(EasyInputMessagePhaseVariant3, other.EasyInputMessagePhaseVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EasyInputMessagePhase obj1, EasyInputMessagePhase obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EasyInputMessagePhase>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EasyInputMessagePhase obj1, EasyInputMessagePhase obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EasyInputMessagePhase o && Equals(o);
        }
    }
}
