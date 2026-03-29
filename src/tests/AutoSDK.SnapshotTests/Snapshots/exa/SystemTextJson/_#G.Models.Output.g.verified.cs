//HintName: G.Models.Output.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Output : global::System.IEquatable<Output>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1? Completed { get; init; }
#else
        public global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1? Completed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Completed))]
#endif
        public bool IsCompleted => Completed != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2? Failed { get; init; }
#else
        public global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2? Failed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Failed))]
#endif
        public bool IsFailed => Failed != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Output(global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1 value) => new Output((global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1?(Output @this) => @this.Completed;

        /// <summary>
        /// 
        /// </summary>
        public Output(global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1? value)
        {
            Completed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Output(global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2 value) => new Output((global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2?(Output @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public Output(global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Output(
            global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1? completed,
            global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2? failed
            )
        {
            Completed = completed;
            Failed = failed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Failed as object ??
            Completed as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Completed?.ToString() ??
            Failed?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompleted && !IsFailed || !IsCompleted && IsFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1?, TResult>? completed = null,
            global::System.Func<global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2?, TResult>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompleted && completed != null)
            {
                return completed(Completed!);
            }
            else if (IsFailed && failed != null)
            {
                return failed(Failed!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1?>? completed = null,
            global::System.Action<global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2?>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompleted)
            {
                completed?.Invoke(Completed!);
            }
            else if (IsFailed)
            {
                failed?.Invoke(Failed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Completed,
                typeof(global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1),
                Failed,
                typeof(global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2),
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
        public bool Equals(Output other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1?>.Default.Equals(Completed, other.Completed) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2?>.Default.Equals(Failed, other.Failed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Output obj1, Output obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Output>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Output obj1, Output obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Output o && Equals(o);
        }
    }
}
