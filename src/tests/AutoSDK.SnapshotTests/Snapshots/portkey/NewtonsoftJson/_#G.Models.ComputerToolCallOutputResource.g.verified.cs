//HintName: G.Models.ComputerToolCallOutputResource.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ComputerToolCallOutputResource : global::System.IEquatable<ComputerToolCallOutputResource>
    {
        /// <summary>
        /// The output of a computer tool call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ComputerToolCallOutput? ComputerToolCallOutput { get; init; }
#else
        public global::G.ComputerToolCallOutput? ComputerToolCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerToolCallOutput))]
#endif
        public bool IsComputerToolCallOutput => ComputerToolCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ComputerToolCallOutputResourceVariant2? Value2 { get; init; }
#else
        public global::G.ComputerToolCallOutputResourceVariant2? Value2 { get; }
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
        public static implicit operator ComputerToolCallOutputResource(global::G.ComputerToolCallOutput value) => new ComputerToolCallOutputResource((global::G.ComputerToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComputerToolCallOutput?(ComputerToolCallOutputResource @this) => @this.ComputerToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public ComputerToolCallOutputResource(global::G.ComputerToolCallOutput? value)
        {
            ComputerToolCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputerToolCallOutputResource(global::G.ComputerToolCallOutputResourceVariant2 value) => new ComputerToolCallOutputResource((global::G.ComputerToolCallOutputResourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComputerToolCallOutputResourceVariant2?(ComputerToolCallOutputResource @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ComputerToolCallOutputResource(global::G.ComputerToolCallOutputResourceVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ComputerToolCallOutputResource(
            global::G.ComputerToolCallOutput? computerToolCallOutput,
            global::G.ComputerToolCallOutputResourceVariant2? value2
            )
        {
            ComputerToolCallOutput = computerToolCallOutput;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            ComputerToolCallOutput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ComputerToolCallOutput?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsComputerToolCallOutput && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ComputerToolCallOutput?, TResult>? computerToolCallOutput = null,
            global::System.Func<global::G.ComputerToolCallOutputResourceVariant2?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComputerToolCallOutput && computerToolCallOutput != null)
            {
                return computerToolCallOutput(ComputerToolCallOutput!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ComputerToolCallOutput?>? computerToolCallOutput = null,
            global::System.Action<global::G.ComputerToolCallOutputResourceVariant2?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComputerToolCallOutput)
            {
                computerToolCallOutput?.Invoke(ComputerToolCallOutput!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ComputerToolCallOutput,
                typeof(global::G.ComputerToolCallOutput),
                Value2,
                typeof(global::G.ComputerToolCallOutputResourceVariant2),
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
        public bool Equals(ComputerToolCallOutputResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerToolCallOutput?>.Default.Equals(ComputerToolCallOutput, other.ComputerToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerToolCallOutputResourceVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ComputerToolCallOutputResource obj1, ComputerToolCallOutputResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ComputerToolCallOutputResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ComputerToolCallOutputResource obj1, ComputerToolCallOutputResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ComputerToolCallOutputResource o && Equals(o);
        }
    }
}
