//HintName: G.Models.AgentStepReminder.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A reminder that is injected into the agent conversation when specific event types occur.
    /// </summary>
    public readonly partial struct AgentStepReminder : global::System.IEquatable<AgentStepReminder>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.AgentStepReminderDiscriminatorType? Type { get; }

        /// <summary>
        /// A templated reminder with a Velocity template that is compiled at session start and injected into messages matching the specified hooks.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TemplatedReminder? Templated { get; init; }
#else
        public global::G.TemplatedReminder? Templated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Templated))]
#endif
        public bool IsTemplated => Templated != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentStepReminder(global::G.TemplatedReminder value) => new AgentStepReminder((global::G.TemplatedReminder?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TemplatedReminder?(AgentStepReminder @this) => @this.Templated;

        /// <summary>
        /// 
        /// </summary>
        public AgentStepReminder(global::G.TemplatedReminder? value)
        {
            Templated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentStepReminder(
            global::G.AgentStepReminderDiscriminatorType? type,
            global::G.TemplatedReminder? templated
            )
        {
            Type = type;

            Templated = templated;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Templated as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Templated?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTemplated;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TemplatedReminder?, TResult>? templated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTemplated && templated != null)
            {
                return templated(Templated!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TemplatedReminder?>? templated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTemplated)
            {
                templated?.Invoke(Templated!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Templated,
                typeof(global::G.TemplatedReminder),
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
        public bool Equals(AgentStepReminder other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TemplatedReminder?>.Default.Equals(Templated, other.Templated) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentStepReminder obj1, AgentStepReminder obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentStepReminder>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentStepReminder obj1, AgentStepReminder obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentStepReminder o && Equals(o);
        }
    }
}
