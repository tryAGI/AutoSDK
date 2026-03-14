//HintName: G.Models.UpdateInstructionRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update an instruction. Currently only initial instructions are supported.
    /// </summary>
    public readonly partial struct UpdateInstructionRequest : global::System.IEquatable<UpdateInstructionRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateInstructionRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// Request object for updating an existing initial instruction.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdateInitialInstructionRequest? Initial { get; init; }
#else
        public global::G.UpdateInitialInstructionRequest? Initial { get; }
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
        public static implicit operator UpdateInstructionRequest(global::G.UpdateInitialInstructionRequest value) => new UpdateInstructionRequest((global::G.UpdateInitialInstructionRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateInitialInstructionRequest?(UpdateInstructionRequest @this) => @this.Initial;

        /// <summary>
        /// 
        /// </summary>
        public UpdateInstructionRequest(global::G.UpdateInitialInstructionRequest? value)
        {
            Initial = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UpdateInstructionRequest(
            global::G.UpdateInstructionRequestDiscriminatorType? type,
            global::G.UpdateInitialInstructionRequest? initial
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
            global::System.Func<global::G.UpdateInitialInstructionRequest?, TResult>? initial = null,
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
            global::System.Action<global::G.UpdateInitialInstructionRequest?>? initial = null,
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
                typeof(global::G.UpdateInitialInstructionRequest),
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
        public bool Equals(UpdateInstructionRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateInitialInstructionRequest?>.Default.Equals(Initial, other.Initial) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateInstructionRequest obj1, UpdateInstructionRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateInstructionRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateInstructionRequest obj1, UpdateInstructionRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateInstructionRequest o && Equals(o);
        }
    }
}
