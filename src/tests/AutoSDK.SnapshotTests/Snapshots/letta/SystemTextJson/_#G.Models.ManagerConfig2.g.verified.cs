//HintName: G.Models.ManagerConfig2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: {"manager_type":"round_robin"}
    /// </summary>
    public readonly partial struct ManagerConfig2 : global::System.IEquatable<ManagerConfig2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.GroupSchemaManagerConfigDiscriminatorManagerType? ManagerType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RoundRobinManager? RoundRobin { get; init; }
#else
        public global::G.RoundRobinManager? RoundRobin { get; }
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
        public global::G.SupervisorManagerSchema? Supervisor { get; init; }
#else
        public global::G.SupervisorManagerSchema? Supervisor { get; }
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
        public global::G.DynamicManagerSchema? Dynamic { get; init; }
#else
        public global::G.DynamicManagerSchema? Dynamic { get; }
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
        public global::G.SleeptimeManagerSchema? Sleeptime { get; init; }
#else
        public global::G.SleeptimeManagerSchema? Sleeptime { get; }
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
        public global::G.VoiceSleeptimeManagerSchema? VoiceSleeptime { get; init; }
#else
        public global::G.VoiceSleeptimeManagerSchema? VoiceSleeptime { get; }
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
        public static implicit operator ManagerConfig2(global::G.RoundRobinManager value) => new ManagerConfig2((global::G.RoundRobinManager?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RoundRobinManager?(ManagerConfig2 @this) => @this.RoundRobin;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig2(global::G.RoundRobinManager? value)
        {
            RoundRobin = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfig2(global::G.SupervisorManagerSchema value) => new ManagerConfig2((global::G.SupervisorManagerSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SupervisorManagerSchema?(ManagerConfig2 @this) => @this.Supervisor;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig2(global::G.SupervisorManagerSchema? value)
        {
            Supervisor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfig2(global::G.DynamicManagerSchema value) => new ManagerConfig2((global::G.DynamicManagerSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DynamicManagerSchema?(ManagerConfig2 @this) => @this.Dynamic;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig2(global::G.DynamicManagerSchema? value)
        {
            Dynamic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfig2(global::G.SleeptimeManagerSchema value) => new ManagerConfig2((global::G.SleeptimeManagerSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SleeptimeManagerSchema?(ManagerConfig2 @this) => @this.Sleeptime;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig2(global::G.SleeptimeManagerSchema? value)
        {
            Sleeptime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfig2(global::G.VoiceSleeptimeManagerSchema value) => new ManagerConfig2((global::G.VoiceSleeptimeManagerSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VoiceSleeptimeManagerSchema?(ManagerConfig2 @this) => @this.VoiceSleeptime;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig2(global::G.VoiceSleeptimeManagerSchema? value)
        {
            VoiceSleeptime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig2(
            global::G.GroupSchemaManagerConfigDiscriminatorManagerType? managerType,
            global::G.RoundRobinManager? roundRobin,
            global::G.SupervisorManagerSchema? supervisor,
            global::G.DynamicManagerSchema? dynamic,
            global::G.SleeptimeManagerSchema? sleeptime,
            global::G.VoiceSleeptimeManagerSchema? voiceSleeptime
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
            global::System.Func<global::G.RoundRobinManager?, TResult>? roundRobin = null,
            global::System.Func<global::G.SupervisorManagerSchema?, TResult>? supervisor = null,
            global::System.Func<global::G.DynamicManagerSchema?, TResult>? dynamic = null,
            global::System.Func<global::G.SleeptimeManagerSchema?, TResult>? sleeptime = null,
            global::System.Func<global::G.VoiceSleeptimeManagerSchema?, TResult>? voiceSleeptime = null,
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
            global::System.Action<global::G.RoundRobinManager?>? roundRobin = null,
            global::System.Action<global::G.SupervisorManagerSchema?>? supervisor = null,
            global::System.Action<global::G.DynamicManagerSchema?>? dynamic = null,
            global::System.Action<global::G.SleeptimeManagerSchema?>? sleeptime = null,
            global::System.Action<global::G.VoiceSleeptimeManagerSchema?>? voiceSleeptime = null,
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
                typeof(global::G.RoundRobinManager),
                Supervisor,
                typeof(global::G.SupervisorManagerSchema),
                Dynamic,
                typeof(global::G.DynamicManagerSchema),
                Sleeptime,
                typeof(global::G.SleeptimeManagerSchema),
                VoiceSleeptime,
                typeof(global::G.VoiceSleeptimeManagerSchema),
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
        public bool Equals(ManagerConfig2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RoundRobinManager?>.Default.Equals(RoundRobin, other.RoundRobin) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SupervisorManagerSchema?>.Default.Equals(Supervisor, other.Supervisor) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DynamicManagerSchema?>.Default.Equals(Dynamic, other.Dynamic) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SleeptimeManagerSchema?>.Default.Equals(Sleeptime, other.Sleeptime) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VoiceSleeptimeManagerSchema?>.Default.Equals(VoiceSleeptime, other.VoiceSleeptime) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ManagerConfig2 obj1, ManagerConfig2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ManagerConfig2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ManagerConfig2 obj1, ManagerConfig2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ManagerConfig2 o && Equals(o);
        }
    }
}
