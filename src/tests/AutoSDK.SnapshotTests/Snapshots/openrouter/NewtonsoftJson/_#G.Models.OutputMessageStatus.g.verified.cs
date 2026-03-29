//HintName: G.Models.OutputMessageStatus.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputMessageStatus : global::System.IEquatable<OutputMessageStatus>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputMessageStatus0? OutputMessageStatus0 { get; init; }
#else
        public global::G.OutputMessageStatus0? OutputMessageStatus0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessageStatus0))]
#endif
        public bool IsOutputMessageStatus0 => OutputMessageStatus0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputMessageStatus1? OutputMessageStatus1 { get; init; }
#else
        public global::G.OutputMessageStatus1? OutputMessageStatus1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessageStatus1))]
#endif
        public bool IsOutputMessageStatus1 => OutputMessageStatus1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputMessageStatus2? OutputMessageStatus2 { get; init; }
#else
        public global::G.OutputMessageStatus2? OutputMessageStatus2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessageStatus2))]
#endif
        public bool IsOutputMessageStatus2 => OutputMessageStatus2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputMessageStatus(global::G.OutputMessageStatus0 value) => new OutputMessageStatus((global::G.OutputMessageStatus0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputMessageStatus0?(OutputMessageStatus @this) => @this.OutputMessageStatus0;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessageStatus(global::G.OutputMessageStatus0? value)
        {
            OutputMessageStatus0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputMessageStatus(global::G.OutputMessageStatus1 value) => new OutputMessageStatus((global::G.OutputMessageStatus1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputMessageStatus1?(OutputMessageStatus @this) => @this.OutputMessageStatus1;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessageStatus(global::G.OutputMessageStatus1? value)
        {
            OutputMessageStatus1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputMessageStatus(global::G.OutputMessageStatus2 value) => new OutputMessageStatus((global::G.OutputMessageStatus2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputMessageStatus2?(OutputMessageStatus @this) => @this.OutputMessageStatus2;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessageStatus(global::G.OutputMessageStatus2? value)
        {
            OutputMessageStatus2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputMessageStatus(
            global::G.OutputMessageStatus0? outputMessageStatus0,
            global::G.OutputMessageStatus1? outputMessageStatus1,
            global::G.OutputMessageStatus2? outputMessageStatus2
            )
        {
            OutputMessageStatus0 = outputMessageStatus0;
            OutputMessageStatus1 = outputMessageStatus1;
            OutputMessageStatus2 = outputMessageStatus2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputMessageStatus2 as object ??
            OutputMessageStatus1 as object ??
            OutputMessageStatus0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputMessageStatus0?.ToValueString() ??
            OutputMessageStatus1?.ToValueString() ??
            OutputMessageStatus2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputMessageStatus0 && !IsOutputMessageStatus1 && !IsOutputMessageStatus2 || !IsOutputMessageStatus0 && IsOutputMessageStatus1 && !IsOutputMessageStatus2 || !IsOutputMessageStatus0 && !IsOutputMessageStatus1 && IsOutputMessageStatus2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OutputMessageStatus0?, TResult>? outputMessageStatus0 = null,
            global::System.Func<global::G.OutputMessageStatus1?, TResult>? outputMessageStatus1 = null,
            global::System.Func<global::G.OutputMessageStatus2?, TResult>? outputMessageStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessageStatus0 && outputMessageStatus0 != null)
            {
                return outputMessageStatus0(OutputMessageStatus0!);
            }
            else if (IsOutputMessageStatus1 && outputMessageStatus1 != null)
            {
                return outputMessageStatus1(OutputMessageStatus1!);
            }
            else if (IsOutputMessageStatus2 && outputMessageStatus2 != null)
            {
                return outputMessageStatus2(OutputMessageStatus2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OutputMessageStatus0?>? outputMessageStatus0 = null,
            global::System.Action<global::G.OutputMessageStatus1?>? outputMessageStatus1 = null,
            global::System.Action<global::G.OutputMessageStatus2?>? outputMessageStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessageStatus0)
            {
                outputMessageStatus0?.Invoke(OutputMessageStatus0!);
            }
            else if (IsOutputMessageStatus1)
            {
                outputMessageStatus1?.Invoke(OutputMessageStatus1!);
            }
            else if (IsOutputMessageStatus2)
            {
                outputMessageStatus2?.Invoke(OutputMessageStatus2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputMessageStatus0,
                typeof(global::G.OutputMessageStatus0),
                OutputMessageStatus1,
                typeof(global::G.OutputMessageStatus1),
                OutputMessageStatus2,
                typeof(global::G.OutputMessageStatus2),
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
        public bool Equals(OutputMessageStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OutputMessageStatus0?>.Default.Equals(OutputMessageStatus0, other.OutputMessageStatus0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputMessageStatus1?>.Default.Equals(OutputMessageStatus1, other.OutputMessageStatus1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputMessageStatus2?>.Default.Equals(OutputMessageStatus2, other.OutputMessageStatus2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputMessageStatus obj1, OutputMessageStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputMessageStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputMessageStatus obj1, OutputMessageStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputMessageStatus o && Equals(o);
        }
    }
}
