//HintName: G.Models.OutputItemWebSearchCallAction.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputItemWebSearchCallAction : global::System.IEquatable<OutputItemWebSearchCallAction>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputItemWebSearchCallAction0? OutputItemWebSearchCallAction0 { get; init; }
#else
        public global::G.OutputItemWebSearchCallAction0? OutputItemWebSearchCallAction0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemWebSearchCallAction0))]
#endif
        public bool IsOutputItemWebSearchCallAction0 => OutputItemWebSearchCallAction0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputItemWebSearchCallAction1? OutputItemWebSearchCallAction1 { get; init; }
#else
        public global::G.OutputItemWebSearchCallAction1? OutputItemWebSearchCallAction1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemWebSearchCallAction1))]
#endif
        public bool IsOutputItemWebSearchCallAction1 => OutputItemWebSearchCallAction1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OutputItemWebSearchCallAction2? OutputItemWebSearchCallAction2 { get; init; }
#else
        public global::G.OutputItemWebSearchCallAction2? OutputItemWebSearchCallAction2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemWebSearchCallAction2))]
#endif
        public bool IsOutputItemWebSearchCallAction2 => OutputItemWebSearchCallAction2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItemWebSearchCallAction(global::G.OutputItemWebSearchCallAction0 value) => new OutputItemWebSearchCallAction((global::G.OutputItemWebSearchCallAction0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputItemWebSearchCallAction0?(OutputItemWebSearchCallAction @this) => @this.OutputItemWebSearchCallAction0;

        /// <summary>
        /// 
        /// </summary>
        public OutputItemWebSearchCallAction(global::G.OutputItemWebSearchCallAction0? value)
        {
            OutputItemWebSearchCallAction0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItemWebSearchCallAction(global::G.OutputItemWebSearchCallAction1 value) => new OutputItemWebSearchCallAction((global::G.OutputItemWebSearchCallAction1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputItemWebSearchCallAction1?(OutputItemWebSearchCallAction @this) => @this.OutputItemWebSearchCallAction1;

        /// <summary>
        /// 
        /// </summary>
        public OutputItemWebSearchCallAction(global::G.OutputItemWebSearchCallAction1? value)
        {
            OutputItemWebSearchCallAction1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItemWebSearchCallAction(global::G.OutputItemWebSearchCallAction2 value) => new OutputItemWebSearchCallAction((global::G.OutputItemWebSearchCallAction2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OutputItemWebSearchCallAction2?(OutputItemWebSearchCallAction @this) => @this.OutputItemWebSearchCallAction2;

        /// <summary>
        /// 
        /// </summary>
        public OutputItemWebSearchCallAction(global::G.OutputItemWebSearchCallAction2? value)
        {
            OutputItemWebSearchCallAction2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputItemWebSearchCallAction(
            global::G.OutputItemWebSearchCallAction0? outputItemWebSearchCallAction0,
            global::G.OutputItemWebSearchCallAction1? outputItemWebSearchCallAction1,
            global::G.OutputItemWebSearchCallAction2? outputItemWebSearchCallAction2
            )
        {
            OutputItemWebSearchCallAction0 = outputItemWebSearchCallAction0;
            OutputItemWebSearchCallAction1 = outputItemWebSearchCallAction1;
            OutputItemWebSearchCallAction2 = outputItemWebSearchCallAction2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputItemWebSearchCallAction2 as object ??
            OutputItemWebSearchCallAction1 as object ??
            OutputItemWebSearchCallAction0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputItemWebSearchCallAction0?.ToString() ??
            OutputItemWebSearchCallAction1?.ToString() ??
            OutputItemWebSearchCallAction2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputItemWebSearchCallAction0 && !IsOutputItemWebSearchCallAction1 && !IsOutputItemWebSearchCallAction2 || !IsOutputItemWebSearchCallAction0 && IsOutputItemWebSearchCallAction1 && !IsOutputItemWebSearchCallAction2 || !IsOutputItemWebSearchCallAction0 && !IsOutputItemWebSearchCallAction1 && IsOutputItemWebSearchCallAction2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OutputItemWebSearchCallAction0?, TResult>? outputItemWebSearchCallAction0 = null,
            global::System.Func<global::G.OutputItemWebSearchCallAction1?, TResult>? outputItemWebSearchCallAction1 = null,
            global::System.Func<global::G.OutputItemWebSearchCallAction2?, TResult>? outputItemWebSearchCallAction2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputItemWebSearchCallAction0 && outputItemWebSearchCallAction0 != null)
            {
                return outputItemWebSearchCallAction0(OutputItemWebSearchCallAction0!);
            }
            else if (IsOutputItemWebSearchCallAction1 && outputItemWebSearchCallAction1 != null)
            {
                return outputItemWebSearchCallAction1(OutputItemWebSearchCallAction1!);
            }
            else if (IsOutputItemWebSearchCallAction2 && outputItemWebSearchCallAction2 != null)
            {
                return outputItemWebSearchCallAction2(OutputItemWebSearchCallAction2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OutputItemWebSearchCallAction0?>? outputItemWebSearchCallAction0 = null,
            global::System.Action<global::G.OutputItemWebSearchCallAction1?>? outputItemWebSearchCallAction1 = null,
            global::System.Action<global::G.OutputItemWebSearchCallAction2?>? outputItemWebSearchCallAction2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputItemWebSearchCallAction0)
            {
                outputItemWebSearchCallAction0?.Invoke(OutputItemWebSearchCallAction0!);
            }
            else if (IsOutputItemWebSearchCallAction1)
            {
                outputItemWebSearchCallAction1?.Invoke(OutputItemWebSearchCallAction1!);
            }
            else if (IsOutputItemWebSearchCallAction2)
            {
                outputItemWebSearchCallAction2?.Invoke(OutputItemWebSearchCallAction2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputItemWebSearchCallAction0,
                typeof(global::G.OutputItemWebSearchCallAction0),
                OutputItemWebSearchCallAction1,
                typeof(global::G.OutputItemWebSearchCallAction1),
                OutputItemWebSearchCallAction2,
                typeof(global::G.OutputItemWebSearchCallAction2),
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
        public bool Equals(OutputItemWebSearchCallAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OutputItemWebSearchCallAction0?>.Default.Equals(OutputItemWebSearchCallAction0, other.OutputItemWebSearchCallAction0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputItemWebSearchCallAction1?>.Default.Equals(OutputItemWebSearchCallAction1, other.OutputItemWebSearchCallAction1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OutputItemWebSearchCallAction2?>.Default.Equals(OutputItemWebSearchCallAction2, other.OutputItemWebSearchCallAction2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputItemWebSearchCallAction obj1, OutputItemWebSearchCallAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputItemWebSearchCallAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputItemWebSearchCallAction obj1, OutputItemWebSearchCallAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputItemWebSearchCallAction o && Equals(o);
        }
    }
}
