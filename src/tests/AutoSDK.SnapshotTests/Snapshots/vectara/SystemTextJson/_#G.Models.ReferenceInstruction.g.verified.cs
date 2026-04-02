//HintName: G.Models.ReferenceInstruction.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An instruction specified by reference.
    /// </summary>
    public readonly partial struct ReferenceInstruction : global::System.IEquatable<ReferenceInstruction>
    {
        /// <summary>
        /// A reference to an instruction that can be used by an agent. If version is not specified, the latest version will be used. Note that when the instruction is updated, agents using it will need to be updated to reference the new version explicitly.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InstructionReference? InstructionReference { get; init; }
#else
        public global::G.InstructionReference? InstructionReference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InstructionReference))]
#endif
        public bool IsInstructionReference => InstructionReference != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReferenceInstructionVariant2? ReferenceInstructionVariant2 { get; init; }
#else
        public global::G.ReferenceInstructionVariant2? ReferenceInstructionVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReferenceInstructionVariant2))]
#endif
        public bool IsReferenceInstructionVariant2 => ReferenceInstructionVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReferenceInstruction(global::G.InstructionReference value) => new ReferenceInstruction((global::G.InstructionReference?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InstructionReference?(ReferenceInstruction @this) => @this.InstructionReference;

        /// <summary>
        /// 
        /// </summary>
        public ReferenceInstruction(global::G.InstructionReference? value)
        {
            InstructionReference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReferenceInstruction(global::G.ReferenceInstructionVariant2 value) => new ReferenceInstruction((global::G.ReferenceInstructionVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReferenceInstructionVariant2?(ReferenceInstruction @this) => @this.ReferenceInstructionVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ReferenceInstruction(global::G.ReferenceInstructionVariant2? value)
        {
            ReferenceInstructionVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReferenceInstruction(
            global::G.InstructionReference? instructionReference,
            global::G.ReferenceInstructionVariant2? referenceInstructionVariant2
            )
        {
            InstructionReference = instructionReference;
            ReferenceInstructionVariant2 = referenceInstructionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ReferenceInstructionVariant2 as object ??
            InstructionReference as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InstructionReference?.ToString() ??
            ReferenceInstructionVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInstructionReference && IsReferenceInstructionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InstructionReference?, TResult>? instructionReference = null,
            global::System.Func<global::G.ReferenceInstructionVariant2?, TResult>? referenceInstructionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInstructionReference && instructionReference != null)
            {
                return instructionReference(InstructionReference!);
            }
            else if (IsReferenceInstructionVariant2 && referenceInstructionVariant2 != null)
            {
                return referenceInstructionVariant2(ReferenceInstructionVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InstructionReference?>? instructionReference = null,
            global::System.Action<global::G.ReferenceInstructionVariant2?>? referenceInstructionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInstructionReference)
            {
                instructionReference?.Invoke(InstructionReference!);
            }
            else if (IsReferenceInstructionVariant2)
            {
                referenceInstructionVariant2?.Invoke(ReferenceInstructionVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InstructionReference,
                typeof(global::G.InstructionReference),
                ReferenceInstructionVariant2,
                typeof(global::G.ReferenceInstructionVariant2),
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
        public bool Equals(ReferenceInstruction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InstructionReference?>.Default.Equals(InstructionReference, other.InstructionReference) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ReferenceInstructionVariant2?>.Default.Equals(ReferenceInstructionVariant2, other.ReferenceInstructionVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ReferenceInstruction obj1, ReferenceInstruction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReferenceInstruction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ReferenceInstruction obj1, ReferenceInstruction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReferenceInstruction o && Equals(o);
        }
    }
}
