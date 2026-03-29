//HintName: G.Models.ManagerConfig3.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: {"manager_type":"round_robin"}
    /// </summary>
    public readonly partial struct ManagerConfig3 : global::System.IEquatable<ManagerConfig3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType? ManagerType { get; }

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
        public global::G.SupervisorManager? Supervisor { get; init; }
#else
        public global::G.SupervisorManager? Supervisor { get; }
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
        public global::G.DynamicManager? Dynamic { get; init; }
#else
        public global::G.DynamicManager? Dynamic { get; }
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
        public global::G.SleeptimeManager? Sleeptime { get; init; }
#else
        public global::G.SleeptimeManager? Sleeptime { get; }
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
        public global::G.VoiceSleeptimeManager? VoiceSleeptime { get; init; }
#else
        public global::G.VoiceSleeptimeManager? VoiceSleeptime { get; }
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
        public static implicit operator ManagerConfig3(global::G.RoundRobinManager value) => new ManagerConfig3((global::G.RoundRobinManager?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RoundRobinManager?(ManagerConfig3 @this) => @this.RoundRobin;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig3(global::G.RoundRobinManager? value)
        {
            RoundRobin = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfig3(global::G.SupervisorManager value) => new ManagerConfig3((global::G.SupervisorManager?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SupervisorManager?(ManagerConfig3 @this) => @this.Supervisor;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig3(global::G.SupervisorManager? value)
        {
            Supervisor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfig3(global::G.DynamicManager value) => new ManagerConfig3((global::G.DynamicManager?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DynamicManager?(ManagerConfig3 @this) => @this.Dynamic;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig3(global::G.DynamicManager? value)
        {
            Dynamic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfig3(global::G.SleeptimeManager value) => new ManagerConfig3((global::G.SleeptimeManager?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SleeptimeManager?(ManagerConfig3 @this) => @this.Sleeptime;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig3(global::G.SleeptimeManager? value)
        {
            Sleeptime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfig3(global::G.VoiceSleeptimeManager value) => new ManagerConfig3((global::G.VoiceSleeptimeManager?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VoiceSleeptimeManager?(ManagerConfig3 @this) => @this.VoiceSleeptime;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig3(global::G.VoiceSleeptimeManager? value)
        {
            VoiceSleeptime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig3(
            global::G.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType? managerType,
            global::G.RoundRobinManager? roundRobin,
            global::G.SupervisorManager? supervisor,
            global::G.DynamicManager? dynamic,
            global::G.SleeptimeManager? sleeptime,
            global::G.VoiceSleeptimeManager? voiceSleeptime
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
            global::System.Func<global::G.SupervisorManager?, TResult>? supervisor = null,
            global::System.Func<global::G.DynamicManager?, TResult>? dynamic = null,
            global::System.Func<global::G.SleeptimeManager?, TResult>? sleeptime = null,
            global::System.Func<global::G.VoiceSleeptimeManager?, TResult>? voiceSleeptime = null,
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
            global::System.Action<global::G.SupervisorManager?>? supervisor = null,
            global::System.Action<global::G.DynamicManager?>? dynamic = null,
            global::System.Action<global::G.SleeptimeManager?>? sleeptime = null,
            global::System.Action<global::G.VoiceSleeptimeManager?>? voiceSleeptime = null,
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
                typeof(global::G.SupervisorManager),
                Dynamic,
                typeof(global::G.DynamicManager),
                Sleeptime,
                typeof(global::G.SleeptimeManager),
                VoiceSleeptime,
                typeof(global::G.VoiceSleeptimeManager),
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
        public bool Equals(ManagerConfig3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RoundRobinManager?>.Default.Equals(RoundRobin, other.RoundRobin) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SupervisorManager?>.Default.Equals(Supervisor, other.Supervisor) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DynamicManager?>.Default.Equals(Dynamic, other.Dynamic) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SleeptimeManager?>.Default.Equals(Sleeptime, other.Sleeptime) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VoiceSleeptimeManager?>.Default.Equals(VoiceSleeptime, other.VoiceSleeptime) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ManagerConfig3 obj1, ManagerConfig3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ManagerConfig3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ManagerConfig3 obj1, ManagerConfig3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ManagerConfig3 o && Equals(o);
        }
    }
}
