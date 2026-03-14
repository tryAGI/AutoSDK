//HintName: G.Models.CreateInstructionRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create an instruction. Currently only initial instructions are supported.
    /// </summary>
    public readonly partial struct CreateInstructionRequest : global::System.IEquatable<CreateInstructionRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateInstructionRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// Request object for creating a new initial instruction.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateInitialInstructionRequest? Initial { get; init; }
#else
        public global::G.CreateInitialInstructionRequest? Initial { get; }
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
        public static implicit operator CreateInstructionRequest(global::G.CreateInitialInstructionRequest value) => new CreateInstructionRequest((global::G.CreateInitialInstructionRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateInitialInstructionRequest?(CreateInstructionRequest @this) => @this.Initial;

        /// <summary>
        /// 
        /// </summary>
        public CreateInstructionRequest(global::G.CreateInitialInstructionRequest? value)
        {
            Initial = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateInstructionRequest(
            global::G.CreateInstructionRequestDiscriminatorType? type,
            global::G.CreateInitialInstructionRequest? initial
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
            global::System.Func<global::G.CreateInitialInstructionRequest?, TResult>? initial = null,
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
            global::System.Action<global::G.CreateInitialInstructionRequest?>? initial = null,
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
                typeof(global::G.CreateInitialInstructionRequest),
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
        public bool Equals(CreateInstructionRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateInitialInstructionRequest?>.Default.Equals(Initial, other.Initial) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateInstructionRequest obj1, CreateInstructionRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateInstructionRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateInstructionRequest obj1, CreateInstructionRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateInstructionRequest o && Equals(o);
        }
    }
}
