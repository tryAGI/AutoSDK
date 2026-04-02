//HintName: G.Models.CreateInitialInstructionRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Request object for creating a new initial instruction.
    /// </summary>
    public readonly partial struct CreateInitialInstructionRequest : global::System.IEquatable<CreateInitialInstructionRequest>
    {
        /// <summary>
        /// Base properties for creating an instruction, without the type discriminator field.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InstructionRequestBase? Base { get; init; }
#else
        public global::G.InstructionRequestBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateInitialInstructionRequestVariant2? CreateInitialInstructionRequestVariant2 { get; init; }
#else
        public global::G.CreateInitialInstructionRequestVariant2? CreateInitialInstructionRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateInitialInstructionRequestVariant2))]
#endif
        public bool IsCreateInitialInstructionRequestVariant2 => CreateInitialInstructionRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateInitialInstructionRequest(global::G.InstructionRequestBase value) => new CreateInitialInstructionRequest((global::G.InstructionRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InstructionRequestBase?(CreateInitialInstructionRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CreateInitialInstructionRequest(global::G.InstructionRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateInitialInstructionRequest(global::G.CreateInitialInstructionRequestVariant2 value) => new CreateInitialInstructionRequest((global::G.CreateInitialInstructionRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateInitialInstructionRequestVariant2?(CreateInitialInstructionRequest @this) => @this.CreateInitialInstructionRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateInitialInstructionRequest(global::G.CreateInitialInstructionRequestVariant2? value)
        {
            CreateInitialInstructionRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateInitialInstructionRequest(
            global::G.InstructionRequestBase? @base,
            global::G.CreateInitialInstructionRequestVariant2? createInitialInstructionRequestVariant2
            )
        {
            Base = @base;
            CreateInitialInstructionRequestVariant2 = createInitialInstructionRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateInitialInstructionRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateInitialInstructionRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateInitialInstructionRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InstructionRequestBase?, TResult>? @base = null,
            global::System.Func<global::G.CreateInitialInstructionRequestVariant2?, TResult>? createInitialInstructionRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsCreateInitialInstructionRequestVariant2 && createInitialInstructionRequestVariant2 != null)
            {
                return createInitialInstructionRequestVariant2(CreateInitialInstructionRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InstructionRequestBase?>? @base = null,
            global::System.Action<global::G.CreateInitialInstructionRequestVariant2?>? createInitialInstructionRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsCreateInitialInstructionRequestVariant2)
            {
                createInitialInstructionRequestVariant2?.Invoke(CreateInitialInstructionRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::G.InstructionRequestBase),
                CreateInitialInstructionRequestVariant2,
                typeof(global::G.CreateInitialInstructionRequestVariant2),
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
        public bool Equals(CreateInitialInstructionRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InstructionRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateInitialInstructionRequestVariant2?>.Default.Equals(CreateInitialInstructionRequestVariant2, other.CreateInitialInstructionRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateInitialInstructionRequest obj1, CreateInitialInstructionRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateInitialInstructionRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateInitialInstructionRequest obj1, CreateInitialInstructionRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateInitialInstructionRequest o && Equals(o);
        }
    }
}
