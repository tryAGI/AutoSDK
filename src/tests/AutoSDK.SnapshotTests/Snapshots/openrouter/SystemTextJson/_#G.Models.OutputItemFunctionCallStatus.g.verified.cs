//HintName: G.Models.OutputItemFunctionCallStatus.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputItemFunctionCallStatus : global::System.IEquatable<OutputItemFunctionCallStatus>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputItemFunctionCallStatus0? OutputItemFunctionCallStatus0 { get; init; }
#else
        public global::G.OutputItemFunctionCallStatus0? OutputItemFunctionCallStatus0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemFunctionCallStatus0))]
#endif
        public bool IsOutputItemFunctionCallStatus0 => OutputItemFunctionCallStatus0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputItemFunctionCallStatus1? OutputItemFunctionCallStatus1 { get; init; }
#else
        public global::G.OutputItemFunctionCallStatus1? OutputItemFunctionCallStatus1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemFunctionCallStatus1))]
#endif
        public bool IsOutputItemFunctionCallStatus1 => OutputItemFunctionCallStatus1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputItemFunctionCallStatus2? OutputItemFunctionCallStatus2 { get; init; }
#else
        public global::G.OutputItemFunctionCallStatus2? OutputItemFunctionCallStatus2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemFunctionCallStatus2))]
#endif
        public bool IsOutputItemFunctionCallStatus2 => OutputItemFunctionCallStatus2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItemFunctionCallStatus(global::G.OutputItemFunctionCallStatus0 value) => new OutputItemFunctionCallStatus((global::G.OutputItemFunctionCallStatus0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputItemFunctionCallStatus0?(OutputItemFunctionCallStatus @this) => @this.OutputItemFunctionCallStatus0;

        /// <summary>
        /// 
        /// </summary>
        public OutputItemFunctionCallStatus(global::G.OutputItemFunctionCallStatus0? value)
        {
            OutputItemFunctionCallStatus0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItemFunctionCallStatus(global::G.OutputItemFunctionCallStatus1 value) => new OutputItemFunctionCallStatus((global::G.OutputItemFunctionCallStatus1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputItemFunctionCallStatus1?(OutputItemFunctionCallStatus @this) => @this.OutputItemFunctionCallStatus1;

        /// <summary>
        /// 
        /// </summary>
        public OutputItemFunctionCallStatus(global::G.OutputItemFunctionCallStatus1? value)
        {
            OutputItemFunctionCallStatus1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItemFunctionCallStatus(global::G.OutputItemFunctionCallStatus2 value) => new OutputItemFunctionCallStatus((global::G.OutputItemFunctionCallStatus2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputItemFunctionCallStatus2?(OutputItemFunctionCallStatus @this) => @this.OutputItemFunctionCallStatus2;

        /// <summary>
        /// 
        /// </summary>
        public OutputItemFunctionCallStatus(global::G.OutputItemFunctionCallStatus2? value)
        {
            OutputItemFunctionCallStatus2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputItemFunctionCallStatus(
            global::G.OutputItemFunctionCallStatus0? outputItemFunctionCallStatus0,
            global::G.OutputItemFunctionCallStatus1? outputItemFunctionCallStatus1,
            global::G.OutputItemFunctionCallStatus2? outputItemFunctionCallStatus2
            )
        {
            OutputItemFunctionCallStatus0 = outputItemFunctionCallStatus0;
            OutputItemFunctionCallStatus1 = outputItemFunctionCallStatus1;
            OutputItemFunctionCallStatus2 = outputItemFunctionCallStatus2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputItemFunctionCallStatus2 as object ??
            OutputItemFunctionCallStatus1 as object ??
            OutputItemFunctionCallStatus0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputItemFunctionCallStatus0?.ToValueString() ??
            OutputItemFunctionCallStatus1?.ToValueString() ??
            OutputItemFunctionCallStatus2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputItemFunctionCallStatus0 && !IsOutputItemFunctionCallStatus1 && !IsOutputItemFunctionCallStatus2 || !IsOutputItemFunctionCallStatus0 && IsOutputItemFunctionCallStatus1 && !IsOutputItemFunctionCallStatus2 || !IsOutputItemFunctionCallStatus0 && !IsOutputItemFunctionCallStatus1 && IsOutputItemFunctionCallStatus2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OutputItemFunctionCallStatus0?, TResult>? outputItemFunctionCallStatus0 = null,
            global::System.Func<global::G.OutputItemFunctionCallStatus1?, TResult>? outputItemFunctionCallStatus1 = null,
            global::System.Func<global::G.OutputItemFunctionCallStatus2?, TResult>? outputItemFunctionCallStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputItemFunctionCallStatus0 && outputItemFunctionCallStatus0 != null)
            {
                return outputItemFunctionCallStatus0(OutputItemFunctionCallStatus0!);
            }
            else if (IsOutputItemFunctionCallStatus1 && outputItemFunctionCallStatus1 != null)
            {
                return outputItemFunctionCallStatus1(OutputItemFunctionCallStatus1!);
            }
            else if (IsOutputItemFunctionCallStatus2 && outputItemFunctionCallStatus2 != null)
            {
                return outputItemFunctionCallStatus2(OutputItemFunctionCallStatus2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OutputItemFunctionCallStatus0?>? outputItemFunctionCallStatus0 = null,
            global::System.Action<global::G.OutputItemFunctionCallStatus1?>? outputItemFunctionCallStatus1 = null,
            global::System.Action<global::G.OutputItemFunctionCallStatus2?>? outputItemFunctionCallStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputItemFunctionCallStatus0)
            {
                outputItemFunctionCallStatus0?.Invoke(OutputItemFunctionCallStatus0!);
            }
            else if (IsOutputItemFunctionCallStatus1)
            {
                outputItemFunctionCallStatus1?.Invoke(OutputItemFunctionCallStatus1!);
            }
            else if (IsOutputItemFunctionCallStatus2)
            {
                outputItemFunctionCallStatus2?.Invoke(OutputItemFunctionCallStatus2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputItemFunctionCallStatus0,
                typeof(global::G.OutputItemFunctionCallStatus0),
                OutputItemFunctionCallStatus1,
                typeof(global::G.OutputItemFunctionCallStatus1),
                OutputItemFunctionCallStatus2,
                typeof(global::G.OutputItemFunctionCallStatus2),
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
        public bool Equals(OutputItemFunctionCallStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OutputItemFunctionCallStatus0?>.Default.Equals(OutputItemFunctionCallStatus0, other.OutputItemFunctionCallStatus0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputItemFunctionCallStatus1?>.Default.Equals(OutputItemFunctionCallStatus1, other.OutputItemFunctionCallStatus1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputItemFunctionCallStatus2?>.Default.Equals(OutputItemFunctionCallStatus2, other.OutputItemFunctionCallStatus2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputItemFunctionCallStatus obj1, OutputItemFunctionCallStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputItemFunctionCallStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputItemFunctionCallStatus obj1, OutputItemFunctionCallStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputItemFunctionCallStatus o && Equals(o);
        }
    }
}
