//HintName: G.Models.OutputMessagePhase.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The phase of an assistant message. Use `commentary` for an intermediate assistant message and `final_answer` for the final assistant message. For follow-up requests with models like `gpt-5.3-codex` and later, preserve and resend phase on all assistant messages. Omitting it can degrade performance. Not used for user messages.
    /// </summary>
    public readonly partial struct OutputMessagePhase : global::System.IEquatable<OutputMessagePhase>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputMessagePhase0? OutputMessagePhase0 { get; init; }
#else
        public global::G.OutputMessagePhase0? OutputMessagePhase0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessagePhase0))]
#endif
        public bool IsOutputMessagePhase0 => OutputMessagePhase0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputMessagePhase1? OutputMessagePhase1 { get; init; }
#else
        public global::G.OutputMessagePhase1? OutputMessagePhase1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessagePhase1))]
#endif
        public bool IsOutputMessagePhase1 => OutputMessagePhase1 != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? OutputMessagePhaseVariant3 { get; init; }
#else
        public object? OutputMessagePhaseVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessagePhaseVariant3))]
#endif
        public bool IsOutputMessagePhaseVariant3 => OutputMessagePhaseVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputMessagePhase(global::G.OutputMessagePhase0 value) => new OutputMessagePhase((global::G.OutputMessagePhase0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputMessagePhase0?(OutputMessagePhase @this) => @this.OutputMessagePhase0;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessagePhase(global::G.OutputMessagePhase0? value)
        {
            OutputMessagePhase0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputMessagePhase(global::G.OutputMessagePhase1 value) => new OutputMessagePhase((global::G.OutputMessagePhase1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputMessagePhase1?(OutputMessagePhase @this) => @this.OutputMessagePhase1;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessagePhase(global::G.OutputMessagePhase1? value)
        {
            OutputMessagePhase1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputMessagePhase(
            global::G.OutputMessagePhase0? outputMessagePhase0,
            global::G.OutputMessagePhase1? outputMessagePhase1,
            object? outputMessagePhaseVariant3
            )
        {
            OutputMessagePhase0 = outputMessagePhase0;
            OutputMessagePhase1 = outputMessagePhase1;
            OutputMessagePhaseVariant3 = outputMessagePhaseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputMessagePhaseVariant3 as object ??
            OutputMessagePhase1 as object ??
            OutputMessagePhase0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputMessagePhase0?.ToValueString() ??
            OutputMessagePhase1?.ToValueString() ??
            OutputMessagePhaseVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputMessagePhase0 && !IsOutputMessagePhase1 && !IsOutputMessagePhaseVariant3 || !IsOutputMessagePhase0 && IsOutputMessagePhase1 && !IsOutputMessagePhaseVariant3 || !IsOutputMessagePhase0 && !IsOutputMessagePhase1 && IsOutputMessagePhaseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OutputMessagePhase0?, TResult>? outputMessagePhase0 = null,
            global::System.Func<global::G.OutputMessagePhase1?, TResult>? outputMessagePhase1 = null,
            global::System.Func<object?, TResult>? outputMessagePhaseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessagePhase0 && outputMessagePhase0 != null)
            {
                return outputMessagePhase0(OutputMessagePhase0!);
            }
            else if (IsOutputMessagePhase1 && outputMessagePhase1 != null)
            {
                return outputMessagePhase1(OutputMessagePhase1!);
            }
            else if (IsOutputMessagePhaseVariant3 && outputMessagePhaseVariant3 != null)
            {
                return outputMessagePhaseVariant3(OutputMessagePhaseVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OutputMessagePhase0?>? outputMessagePhase0 = null,
            global::System.Action<global::G.OutputMessagePhase1?>? outputMessagePhase1 = null,
            global::System.Action<object?>? outputMessagePhaseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessagePhase0)
            {
                outputMessagePhase0?.Invoke(OutputMessagePhase0!);
            }
            else if (IsOutputMessagePhase1)
            {
                outputMessagePhase1?.Invoke(OutputMessagePhase1!);
            }
            else if (IsOutputMessagePhaseVariant3)
            {
                outputMessagePhaseVariant3?.Invoke(OutputMessagePhaseVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputMessagePhase0,
                typeof(global::G.OutputMessagePhase0),
                OutputMessagePhase1,
                typeof(global::G.OutputMessagePhase1),
                OutputMessagePhaseVariant3,
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
        public bool Equals(OutputMessagePhase other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OutputMessagePhase0?>.Default.Equals(OutputMessagePhase0, other.OutputMessagePhase0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputMessagePhase1?>.Default.Equals(OutputMessagePhase1, other.OutputMessagePhase1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(OutputMessagePhaseVariant3, other.OutputMessagePhaseVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputMessagePhase obj1, OutputMessagePhase obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputMessagePhase>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputMessagePhase obj1, OutputMessagePhase obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputMessagePhase o && Equals(o);
        }
    }
}
