//HintName: G.Models.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.
    /// </summary>
    public readonly partial struct CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy : global::System.IEquatable<CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType? Type { get; }

        /// <summary>
        /// The default strategy. This strategy currently uses a `max_chunk_size_tokens` of `800` and `chunk_overlap_tokens` of `400`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? Auto { get; init; }
#else
        public global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? Auto { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Auto))]
#endif
        public bool IsAuto => Auto != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy(global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1 value) => new CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?(CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy @this) => @this.Auto;

        /// <summary>
        /// 
        /// </summary>
        public CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy(global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? value)
        {
            Auto = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? Static { get; init; }
#else
        public global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? Static { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Static))]
#endif
        public bool IsStatic => Static != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy(global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2 value) => new CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?(CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy @this) => @this.Static;

        /// <summary>
        /// 
        /// </summary>
        public CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy(global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? value)
        {
            Static = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy(
            global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType? type,
            global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? auto,
            global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? @static
            )
        {
            Type = type;

            Auto = auto;
            Static = @static;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Static as object ??
            Auto as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAuto && !IsStatic || !IsAuto && IsStatic;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?, TResult>? auto = null,
            global::System.Func<global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?, TResult>? @static = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuto && auto != null)
            {
                return auto(Auto!);
            }
            else if (IsStatic && @static != null)
            {
                return @static(Static!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?>? auto = null,
            global::System.Action<global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?>? @static = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuto)
            {
                auto?.Invoke(Auto!);
            }
            else if (IsStatic)
            {
                @static?.Invoke(Static!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Auto,
                typeof(global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1),
                Static,
                typeof(global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?>.Default.Equals(Auto, other.Auto) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?>.Default.Equals(Static, other.Static) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy obj1, CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy obj1, CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy o && Equals(o);
        }
    }
}
