//HintName: G.Models.OutputItemReasoningStatus.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputItemReasoningStatus : global::System.IEquatable<OutputItemReasoningStatus>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputItemReasoningStatus0? OutputItemReasoningStatus0 { get; init; }
#else
        public global::G.OutputItemReasoningStatus0? OutputItemReasoningStatus0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemReasoningStatus0))]
#endif
        public bool IsOutputItemReasoningStatus0 => OutputItemReasoningStatus0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputItemReasoningStatus1? OutputItemReasoningStatus1 { get; init; }
#else
        public global::G.OutputItemReasoningStatus1? OutputItemReasoningStatus1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemReasoningStatus1))]
#endif
        public bool IsOutputItemReasoningStatus1 => OutputItemReasoningStatus1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputItemReasoningStatus2? OutputItemReasoningStatus2 { get; init; }
#else
        public global::G.OutputItemReasoningStatus2? OutputItemReasoningStatus2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemReasoningStatus2))]
#endif
        public bool IsOutputItemReasoningStatus2 => OutputItemReasoningStatus2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItemReasoningStatus(global::G.OutputItemReasoningStatus0 value) => new OutputItemReasoningStatus((global::G.OutputItemReasoningStatus0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputItemReasoningStatus0?(OutputItemReasoningStatus @this) => @this.OutputItemReasoningStatus0;

        /// <summary>
        /// 
        /// </summary>
        public OutputItemReasoningStatus(global::G.OutputItemReasoningStatus0? value)
        {
            OutputItemReasoningStatus0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItemReasoningStatus(global::G.OutputItemReasoningStatus1 value) => new OutputItemReasoningStatus((global::G.OutputItemReasoningStatus1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputItemReasoningStatus1?(OutputItemReasoningStatus @this) => @this.OutputItemReasoningStatus1;

        /// <summary>
        /// 
        /// </summary>
        public OutputItemReasoningStatus(global::G.OutputItemReasoningStatus1? value)
        {
            OutputItemReasoningStatus1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItemReasoningStatus(global::G.OutputItemReasoningStatus2 value) => new OutputItemReasoningStatus((global::G.OutputItemReasoningStatus2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputItemReasoningStatus2?(OutputItemReasoningStatus @this) => @this.OutputItemReasoningStatus2;

        /// <summary>
        /// 
        /// </summary>
        public OutputItemReasoningStatus(global::G.OutputItemReasoningStatus2? value)
        {
            OutputItemReasoningStatus2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputItemReasoningStatus(
            global::G.OutputItemReasoningStatus0? outputItemReasoningStatus0,
            global::G.OutputItemReasoningStatus1? outputItemReasoningStatus1,
            global::G.OutputItemReasoningStatus2? outputItemReasoningStatus2
            )
        {
            OutputItemReasoningStatus0 = outputItemReasoningStatus0;
            OutputItemReasoningStatus1 = outputItemReasoningStatus1;
            OutputItemReasoningStatus2 = outputItemReasoningStatus2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputItemReasoningStatus2 as object ??
            OutputItemReasoningStatus1 as object ??
            OutputItemReasoningStatus0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputItemReasoningStatus0?.ToValueString() ??
            OutputItemReasoningStatus1?.ToValueString() ??
            OutputItemReasoningStatus2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputItemReasoningStatus0 && !IsOutputItemReasoningStatus1 && !IsOutputItemReasoningStatus2 || !IsOutputItemReasoningStatus0 && IsOutputItemReasoningStatus1 && !IsOutputItemReasoningStatus2 || !IsOutputItemReasoningStatus0 && !IsOutputItemReasoningStatus1 && IsOutputItemReasoningStatus2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OutputItemReasoningStatus0?, TResult>? outputItemReasoningStatus0 = null,
            global::System.Func<global::G.OutputItemReasoningStatus1?, TResult>? outputItemReasoningStatus1 = null,
            global::System.Func<global::G.OutputItemReasoningStatus2?, TResult>? outputItemReasoningStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputItemReasoningStatus0 && outputItemReasoningStatus0 != null)
            {
                return outputItemReasoningStatus0(OutputItemReasoningStatus0!);
            }
            else if (IsOutputItemReasoningStatus1 && outputItemReasoningStatus1 != null)
            {
                return outputItemReasoningStatus1(OutputItemReasoningStatus1!);
            }
            else if (IsOutputItemReasoningStatus2 && outputItemReasoningStatus2 != null)
            {
                return outputItemReasoningStatus2(OutputItemReasoningStatus2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OutputItemReasoningStatus0?>? outputItemReasoningStatus0 = null,
            global::System.Action<global::G.OutputItemReasoningStatus1?>? outputItemReasoningStatus1 = null,
            global::System.Action<global::G.OutputItemReasoningStatus2?>? outputItemReasoningStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputItemReasoningStatus0)
            {
                outputItemReasoningStatus0?.Invoke(OutputItemReasoningStatus0!);
            }
            else if (IsOutputItemReasoningStatus1)
            {
                outputItemReasoningStatus1?.Invoke(OutputItemReasoningStatus1!);
            }
            else if (IsOutputItemReasoningStatus2)
            {
                outputItemReasoningStatus2?.Invoke(OutputItemReasoningStatus2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputItemReasoningStatus0,
                typeof(global::G.OutputItemReasoningStatus0),
                OutputItemReasoningStatus1,
                typeof(global::G.OutputItemReasoningStatus1),
                OutputItemReasoningStatus2,
                typeof(global::G.OutputItemReasoningStatus2),
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
        public bool Equals(OutputItemReasoningStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OutputItemReasoningStatus0?>.Default.Equals(OutputItemReasoningStatus0, other.OutputItemReasoningStatus0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputItemReasoningStatus1?>.Default.Equals(OutputItemReasoningStatus1, other.OutputItemReasoningStatus1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputItemReasoningStatus2?>.Default.Equals(OutputItemReasoningStatus2, other.OutputItemReasoningStatus2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputItemReasoningStatus obj1, OutputItemReasoningStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputItemReasoningStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputItemReasoningStatus obj1, OutputItemReasoningStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputItemReasoningStatus o && Equals(o);
        }
    }
}
