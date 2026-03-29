//HintName: G.Models.Output2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Output2 : global::System.IEquatable<Output2>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1? Tasks { get; init; }
#else
        public global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1? Tasks { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tasks))]
#endif
        public bool IsTasks => Tasks != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2? Stop { get; init; }
#else
        public global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2? Stop { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Stop))]
#endif
        public bool IsStop => Stop != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Output2(global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1 value) => new Output2((global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1?(Output2 @this) => @this.Tasks;

        /// <summary>
        /// 
        /// </summary>
        public Output2(global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1? value)
        {
            Tasks = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Output2(global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2 value) => new Output2((global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2?(Output2 @this) => @this.Stop;

        /// <summary>
        /// 
        /// </summary>
        public Output2(global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2? value)
        {
            Stop = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Output2(
            global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1? tasks,
            global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2? stop
            )
        {
            Tasks = tasks;
            Stop = stop;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Stop as object ??
            Tasks as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Tasks?.ToString() ??
            Stop?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTasks && !IsStop || !IsTasks && IsStop;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1?, TResult>? tasks = null,
            global::System.Func<global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2?, TResult>? stop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTasks && tasks != null)
            {
                return tasks(Tasks!);
            }
            else if (IsStop && stop != null)
            {
                return stop(Stop!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1?>? tasks = null,
            global::System.Action<global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2?>? stop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTasks)
            {
                tasks?.Invoke(Tasks!);
            }
            else if (IsStop)
            {
                stop?.Invoke(Stop!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Tasks,
                typeof(global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1),
                Stop,
                typeof(global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2),
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
        public bool Equals(Output2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1?>.Default.Equals(Tasks, other.Tasks) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2?>.Default.Equals(Stop, other.Stop) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Output2 obj1, Output2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Output2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Output2 obj1, Output2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Output2 o && Equals(o);
        }
    }
}
