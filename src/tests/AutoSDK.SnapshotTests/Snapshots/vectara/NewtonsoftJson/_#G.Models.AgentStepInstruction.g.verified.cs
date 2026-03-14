//HintName: G.Models.AgentStepInstruction.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An instruction that can be used in an agent step, either by reference, defined inline, or using a Vectara built-in instruction.<br/>
    /// Example: [{"type":"reference","name":"Customer Support Initial Instruction","version":1}, {"type":"inline","name":"Temporary On-the-fly Guideline","description":"A special instruction for this specific step only.","template_type":"velocity","template":"Please prioritize issues tagged with \u0027urgent\u0027 for the next hour."}]
    /// </summary>
    public readonly partial struct AgentStepInstruction : global::System.IEquatable<AgentStepInstruction>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.AgentStepInstructionDiscriminatorType? Type { get; }

        /// <summary>
        /// An instruction specified by reference.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ReferenceInstruction? Reference { get; init; }
#else
        public global::G.ReferenceInstruction? Reference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Reference))]
#endif
        public bool IsReference => Reference != null;

        /// <summary>
        /// An instruction defined inline in the request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InlineInstruction? Inline { get; init; }
#else
        public global::G.InlineInstruction? Inline { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Inline))]
#endif
        public bool IsInline => Inline != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStepInstruction(global::G.ReferenceInstruction value) => new AgentStepInstruction((global::G.ReferenceInstruction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ReferenceInstruction?(AgentStepInstruction @this) => @this.Reference;

        /// <summary>
        /// 
        /// </summary>
        public AgentStepInstruction(global::G.ReferenceInstruction? value)
        {
            Reference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStepInstruction(global::G.InlineInstruction value) => new AgentStepInstruction((global::G.InlineInstruction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InlineInstruction?(AgentStepInstruction @this) => @this.Inline;

        /// <summary>
        /// 
        /// </summary>
        public AgentStepInstruction(global::G.InlineInstruction? value)
        {
            Inline = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentStepInstruction(
            global::G.AgentStepInstructionDiscriminatorType? type,
            global::G.ReferenceInstruction? reference,
            global::G.InlineInstruction? inline
            )
        {
            Type = type;

            Reference = reference;
            Inline = inline;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Inline as object ??
            Reference as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Reference?.ToString() ??
            Inline?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReference && !IsInline || !IsReference && IsInline;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ReferenceInstruction?, TResult>? reference = null,
            global::System.Func<global::G.InlineInstruction?, TResult>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReference && reference != null)
            {
                return reference(Reference!);
            }
            else if (IsInline && inline != null)
            {
                return inline(Inline!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ReferenceInstruction?>? reference = null,
            global::System.Action<global::G.InlineInstruction?>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReference)
            {
                reference?.Invoke(Reference!);
            }
            else if (IsInline)
            {
                inline?.Invoke(Inline!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Reference,
                typeof(global::G.ReferenceInstruction),
                Inline,
                typeof(global::G.InlineInstruction),
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
        public bool Equals(AgentStepInstruction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ReferenceInstruction?>.Default.Equals(Reference, other.Reference) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InlineInstruction?>.Default.Equals(Inline, other.Inline) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentStepInstruction obj1, AgentStepInstruction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentStepInstruction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentStepInstruction obj1, AgentStepInstruction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentStepInstruction o && Equals(o);
        }
    }
}
