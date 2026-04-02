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
#if NET6_0_OR_GREATER
        public global::G.ModelIdsResponsesEnum? ResponsesOnlyModel { get; init; }
#else
        public global::G.ModelIdsResponsesEnum? ResponsesOnlyModel { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesOnlyModel))]
#endif
        public bool IsResponsesOnlyModel => ResponsesOnlyModel != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelIdsResponses(global::G.ModelIdsShared value) => new ModelIdsResponses((global::G.ModelIdsShared?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelIdsShared?(ModelIdsResponses @this) => @this.Shared;

        /// <summary>
        /// 
        /// </summary>
        public ModelIdsResponses(global::G.ModelIdsShared? value)
        {
            Shared = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelIdsResponses(global::G.ModelIdsResponsesEnum value) => new ModelIdsResponses((global::G.ModelIdsResponsesEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelIdsResponsesEnum?(ModelIdsResponses @this) => @this.ResponsesOnlyModel;

        /// <summary>
        /// 
        /// </summary>
        public ModelIdsResponses(global::G.ModelIdsResponsesEnum? value)
        {
            ResponsesOnlyModel = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ModelIdsResponses(
            global::G.ModelIdsShared? shared,
            global::G.ModelIdsResponsesEnum? responsesOnlyModel
            )
        {
            Shared = shared;
            ResponsesOnlyModel = responsesOnlyModel;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponsesOnlyModel as object ??
            Shared as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Shared?.ToString() ??
            ResponsesOnlyModel?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsShared || IsResponsesOnlyModel;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ModelIdsShared?, TResult>? shared = null,
            global::System.Func<global::G.ModelIdsResponsesEnum?, TResult>? responsesOnlyModel = null,
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
            else if (IsResponsesOnlyModel && responsesOnlyModel != null)
            {
                return responsesOnlyModel(ResponsesOnlyModel!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ModelIdsShared?>? shared = null,
            global::System.Action<global::G.ModelIdsResponsesEnum?>? responsesOnlyModel = null,
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
            else if (IsResponsesOnlyModel)
            {
                responsesOnlyModel?.Invoke(ResponsesOnlyModel!);
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
                ResponsesOnlyModel,
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
                global::System.Collections.Generic.EqualityComparer<global::G.ModelIdsShared?>.Default.Equals(Shared, other.Shared) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelIdsResponsesEnum?>.Default.Equals(ResponsesOnlyModel, other.ResponsesOnlyModel) 
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
