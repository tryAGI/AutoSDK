//HintName: G.Models.ModelIdsResponses.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Example: gpt-4o
    /// </summary>
    public readonly partial struct ModelIdsResponses : global::System.IEquatable<ModelIdsResponses>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelIdsResponsesEnum? Enum { get; init; }
#else
        public global::G.ModelIdsResponsesEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ModelIdsResponsesEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ModelIdsResponsesEnum PickEnum() => IsEnum
            ? Enum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelIdsResponses(global::G.ModelIdsResponsesEnum value) => new ModelIdsResponses((global::G.ModelIdsResponsesEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelIdsResponsesEnum?(ModelIdsResponses @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public ModelIdsResponses(global::G.ModelIdsResponsesEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ModelIdsResponses FromEnum(global::G.ModelIdsResponsesEnum? value) => new ModelIdsResponses(value);

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ModelIdsResponsesEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ModelIdsResponsesEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.ModelIdsResponsesEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Enum,
                typeof(global::G.ModelIdsResponsesEnum),
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
        public bool Equals(ModelIdsResponses other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ModelIdsResponsesEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ModelIdsResponses obj1, ModelIdsResponses obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelIdsResponses>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ModelIdsResponses obj1, ModelIdsResponses obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelIdsResponses o && Equals(o);
        }
    }
}
