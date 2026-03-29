//HintName: G.Models.ManagerConfigVariant1.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ManagerConfigVariant1 : global::System.IEquatable<ManagerConfigVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType? ManagerType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RoundRobinManagerUpdate? RoundRobin { get; init; }
#else
        public global::G.RoundRobinManagerUpdate? RoundRobin { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RoundRobin))]
#endif
        public bool IsRoundRobin => RoundRobin != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SupervisorManagerUpdate? Supervisor { get; init; }
#else
        public global::G.SupervisorManagerUpdate? Supervisor { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Supervisor))]
#endif
        public bool IsSupervisor => Supervisor != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DynamicManagerUpdate? Dynamic { get; init; }
#else
        public global::G.DynamicManagerUpdate? Dynamic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dynamic))]
#endif
        public bool IsDynamic => Dynamic != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SleeptimeManagerUpdate? Sleeptime { get; init; }
#else
        public global::G.SleeptimeManagerUpdate? Sleeptime { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sleeptime))]
#endif
        public bool IsSleeptime => Sleeptime != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VoiceSleeptimeManagerUpdate? VoiceSleeptime { get; init; }
#else
        public global::G.VoiceSleeptimeManagerUpdate? VoiceSleeptime { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VoiceSleeptime))]
#endif
        public bool IsVoiceSleeptime => VoiceSleeptime != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfigVariant1(global::G.RoundRobinManagerUpdate value) => new ManagerConfigVariant1((global::G.RoundRobinManagerUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RoundRobinManagerUpdate?(ManagerConfigVariant1 @this) => @this.RoundRobin;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfigVariant1(global::G.RoundRobinManagerUpdate? value)
        {
            RoundRobin = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfigVariant1(global::G.SupervisorManagerUpdate value) => new ManagerConfigVariant1((global::G.SupervisorManagerUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SupervisorManagerUpdate?(ManagerConfigVariant1 @this) => @this.Supervisor;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfigVariant1(global::G.SupervisorManagerUpdate? value)
        {
            Supervisor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfigVariant1(global::G.DynamicManagerUpdate value) => new ManagerConfigVariant1((global::G.DynamicManagerUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DynamicManagerUpdate?(ManagerConfigVariant1 @this) => @this.Dynamic;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfigVariant1(global::G.DynamicManagerUpdate? value)
        {
            Dynamic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfigVariant1(global::G.SleeptimeManagerUpdate value) => new ManagerConfigVariant1((global::G.SleeptimeManagerUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SleeptimeManagerUpdate?(ManagerConfigVariant1 @this) => @this.Sleeptime;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfigVariant1(global::G.SleeptimeManagerUpdate? value)
        {
            Sleeptime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfigVariant1(global::G.VoiceSleeptimeManagerUpdate value) => new ManagerConfigVariant1((global::G.VoiceSleeptimeManagerUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VoiceSleeptimeManagerUpdate?(ManagerConfigVariant1 @this) => @this.VoiceSleeptime;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfigVariant1(global::G.VoiceSleeptimeManagerUpdate? value)
        {
            VoiceSleeptime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfigVariant1(
            global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType? managerType,
            global::G.RoundRobinManagerUpdate? roundRobin,
            global::G.SupervisorManagerUpdate? supervisor,
            global::G.DynamicManagerUpdate? dynamic,
            global::G.SleeptimeManagerUpdate? sleeptime,
            global::G.VoiceSleeptimeManagerUpdate? voiceSleeptime
            )
        {
            ManagerType = managerType;

            RoundRobin = roundRobin;
            Supervisor = supervisor;
            Dynamic = dynamic;
            Sleeptime = sleeptime;
            VoiceSleeptime = voiceSleeptime;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VoiceSleeptime as object ??
            Sleeptime as object ??
            Dynamic as object ??
            Supervisor as object ??
            RoundRobin as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RoundRobin?.ToString() ??
            Supervisor?.ToString() ??
            Dynamic?.ToString() ??
            Sleeptime?.ToString() ??
            VoiceSleeptime?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRoundRobin && !IsSupervisor && !IsDynamic && !IsSleeptime && !IsVoiceSleeptime || !IsRoundRobin && IsSupervisor && !IsDynamic && !IsSleeptime && !IsVoiceSleeptime || !IsRoundRobin && !IsSupervisor && IsDynamic && !IsSleeptime && !IsVoiceSleeptime || !IsRoundRobin && !IsSupervisor && !IsDynamic && IsSleeptime && !IsVoiceSleeptime || !IsRoundRobin && !IsSupervisor && !IsDynamic && !IsSleeptime && IsVoiceSleeptime;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RoundRobinManagerUpdate?, TResult>? roundRobin = null,
            global::System.Func<global::G.SupervisorManagerUpdate?, TResult>? supervisor = null,
            global::System.Func<global::G.DynamicManagerUpdate?, TResult>? dynamic = null,
            global::System.Func<global::G.SleeptimeManagerUpdate?, TResult>? sleeptime = null,
            global::System.Func<global::G.VoiceSleeptimeManagerUpdate?, TResult>? voiceSleeptime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRoundRobin && roundRobin != null)
            {
                return roundRobin(RoundRobin!);
            }
            else if (IsSupervisor && supervisor != null)
            {
                return supervisor(Supervisor!);
            }
            else if (IsDynamic && dynamic != null)
            {
                return dynamic(Dynamic!);
            }
            else if (IsSleeptime && sleeptime != null)
            {
                return sleeptime(Sleeptime!);
            }
            else if (IsVoiceSleeptime && voiceSleeptime != null)
            {
                return voiceSleeptime(VoiceSleeptime!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RoundRobinManagerUpdate?>? roundRobin = null,
            global::System.Action<global::G.SupervisorManagerUpdate?>? supervisor = null,
            global::System.Action<global::G.DynamicManagerUpdate?>? dynamic = null,
            global::System.Action<global::G.SleeptimeManagerUpdate?>? sleeptime = null,
            global::System.Action<global::G.VoiceSleeptimeManagerUpdate?>? voiceSleeptime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRoundRobin)
            {
                roundRobin?.Invoke(RoundRobin!);
            }
            else if (IsSupervisor)
            {
                supervisor?.Invoke(Supervisor!);
            }
            else if (IsDynamic)
            {
                dynamic?.Invoke(Dynamic!);
            }
            else if (IsSleeptime)
            {
                sleeptime?.Invoke(Sleeptime!);
            }
            else if (IsVoiceSleeptime)
            {
                voiceSleeptime?.Invoke(VoiceSleeptime!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RoundRobin,
                typeof(global::G.RoundRobinManagerUpdate),
                Supervisor,
                typeof(global::G.SupervisorManagerUpdate),
                Dynamic,
                typeof(global::G.DynamicManagerUpdate),
                Sleeptime,
                typeof(global::G.SleeptimeManagerUpdate),
                VoiceSleeptime,
                typeof(global::G.VoiceSleeptimeManagerUpdate),
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
        public bool Equals(ManagerConfigVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RoundRobinManagerUpdate?>.Default.Equals(RoundRobin, other.RoundRobin) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SupervisorManagerUpdate?>.Default.Equals(Supervisor, other.Supervisor) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DynamicManagerUpdate?>.Default.Equals(Dynamic, other.Dynamic) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SleeptimeManagerUpdate?>.Default.Equals(Sleeptime, other.Sleeptime) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VoiceSleeptimeManagerUpdate?>.Default.Equals(VoiceSleeptime, other.VoiceSleeptime) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ManagerConfigVariant1 obj1, ManagerConfigVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ManagerConfigVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ManagerConfigVariant1 obj1, ManagerConfigVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ManagerConfigVariant1 o && Equals(o);
        }
    }
}
