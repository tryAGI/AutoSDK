//HintName: G.Models.Instruction.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An instruction that guides agent behavior.
    /// </summary>
    public readonly partial struct Instruction : global::System.IEquatable<Instruction>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.InstructionDiscriminatorType? Type { get; }

        /// <summary>
        /// An initial instruction that provides guidance to the agent before user messages.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InitialInstruction? Initial { get; init; }
#else
        public global::G.InitialInstruction? Initial { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Initial))]
#endif
        public bool IsInitial => Initial != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Instruction(global::G.InitialInstruction value) => new Instruction((global::G.InitialInstruction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InitialInstruction?(Instruction @this) => @this.Initial;

        /// <summary>
        /// 
        /// </summary>
        public Instruction(global::G.InitialInstruction? value)
        {
            Initial = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Instruction(
            global::G.InstructionDiscriminatorType? type,
            global::G.InitialInstruction? initial
            )
        {
            Type = type;

            Initial = initial;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Initial as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Initial?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInitial;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InitialInstruction?, TResult>? initial = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInitial && initial != null)
            {
                return initial(Initial!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InitialInstruction?>? initial = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInitial)
            {
                initial?.Invoke(Initial!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Initial,
                typeof(global::G.InitialInstruction),
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
        public bool Equals(Instruction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InitialInstruction?>.Default.Equals(Initial, other.Initial) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Instruction obj1, Instruction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Instruction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Instruction obj1, Instruction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Instruction o && Equals(o);
        }
    }
}
