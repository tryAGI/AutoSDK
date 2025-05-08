//HintName: G.Models.ModelIds.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ModelIds : global::System.IEquatable<ModelIds>
    {
        /// <summary>
        /// Example: gpt-4o
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelIdsShared? Shared { get; init; }
#else
        public global::G.ModelIdsShared? Shared { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared))]
#endif
        public bool IsShared => Shared != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelIds(global::G.ModelIdsShared value) => new ModelIds(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelIdsShared?(ModelIds @this) => @this.Shared;

        /// <summary>
        /// 
        /// </summary>
        public ModelIds(global::G.ModelIdsShared? value)
        {
            Shared = value;
        }

        /// <summary>
        /// Example: gpt-4o
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelIdsResponses? Responses { get; init; }
#else
        public global::G.ModelIdsResponses? Responses { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Responses))]
#endif
        public bool IsResponses => Responses != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelIds(global::G.ModelIdsResponses value) => new ModelIds(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelIdsResponses?(ModelIds @this) => @this.Responses;

        /// <summary>
        /// 
        /// </summary>
        public ModelIds(global::G.ModelIdsResponses? value)
        {
            Responses = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ModelIds(
            global::G.ModelIdsShared? shared,
            global::G.ModelIdsResponses? responses
            )
        {
            Shared = shared;
            Responses = responses;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Responses as object ??
            Shared as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Shared?.ToString() ??
            Responses?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsShared || IsResponses;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ModelIdsShared?, TResult>? shared = null,
            global::System.Func<global::G.ModelIdsResponses?, TResult>? responses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared && shared != null)
            {
                return shared(Shared!);
            }
            else if (IsResponses && responses != null)
            {
                return responses(Responses!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ModelIdsShared?>? shared = null,
            global::System.Action<global::G.ModelIdsResponses?>? responses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared)
            {
                shared?.Invoke(Shared!);
            }
            else if (IsResponses)
            {
                responses?.Invoke(Responses!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared,
                typeof(global::G.ModelIdsShared),
                Responses,
                typeof(global::G.ModelIdsResponses),
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
        public bool Equals(ModelIds other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ModelIdsShared?>.Default.Equals(Shared, other.Shared) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelIdsResponses?>.Default.Equals(Responses, other.Responses) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ModelIds obj1, ModelIds obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelIds>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ModelIds obj1, ModelIds obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelIds o && Equals(o);
        }
    }
}
