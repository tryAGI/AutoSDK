//HintName: G.Models.ResearchDtoClass.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResearchDtoClass : global::System.IEquatable<ResearchDtoClass>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchDtoClassVariant1? Pending { get; init; }
#else
        public global::G.ResearchDtoClassVariant1? Pending { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pending))]
#endif
        public bool IsPending => Pending != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchDtoClassVariant2? Running { get; init; }
#else
        public global::G.ResearchDtoClassVariant2? Running { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Running))]
#endif
        public bool IsRunning => Running != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchDtoClassVariant3? Completed { get; init; }
#else
        public global::G.ResearchDtoClassVariant3? Completed { get; }
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
        public global::G.ResearchDtoClassVariant4? Canceled { get; init; }
#else
        public global::G.ResearchDtoClassVariant4? Canceled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Canceled))]
#endif
        public bool IsCanceled => Canceled != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchDtoClassVariant5? Failed { get; init; }
#else
        public global::G.ResearchDtoClassVariant5? Failed { get; }
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
        public static implicit operator ResearchDtoClass(global::G.ResearchDtoClassVariant1 value) => new ResearchDtoClass((global::G.ResearchDtoClassVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchDtoClassVariant1?(ResearchDtoClass @this) => @this.Pending;

        /// <summary>
        /// 
        /// </summary>
        public ResearchDtoClass(global::G.ResearchDtoClassVariant1? value)
        {
            Pending = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchDtoClass(global::G.ResearchDtoClassVariant2 value) => new ResearchDtoClass((global::G.ResearchDtoClassVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchDtoClassVariant2?(ResearchDtoClass @this) => @this.Running;

        /// <summary>
        /// 
        /// </summary>
        public ResearchDtoClass(global::G.ResearchDtoClassVariant2? value)
        {
            Running = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchDtoClass(global::G.ResearchDtoClassVariant3 value) => new ResearchDtoClass((global::G.ResearchDtoClassVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchDtoClassVariant3?(ResearchDtoClass @this) => @this.Completed;

        /// <summary>
        /// 
        /// </summary>
        public ResearchDtoClass(global::G.ResearchDtoClassVariant3? value)
        {
            Completed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchDtoClass(global::G.ResearchDtoClassVariant4 value) => new ResearchDtoClass((global::G.ResearchDtoClassVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchDtoClassVariant4?(ResearchDtoClass @this) => @this.Canceled;

        /// <summary>
        /// 
        /// </summary>
        public ResearchDtoClass(global::G.ResearchDtoClassVariant4? value)
        {
            Canceled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchDtoClass(global::G.ResearchDtoClassVariant5 value) => new ResearchDtoClass((global::G.ResearchDtoClassVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchDtoClassVariant5?(ResearchDtoClass @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public ResearchDtoClass(global::G.ResearchDtoClassVariant5? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResearchDtoClass(
            global::G.ResearchDtoClassVariant1? pending,
            global::G.ResearchDtoClassVariant2? running,
            global::G.ResearchDtoClassVariant3? completed,
            global::G.ResearchDtoClassVariant4? canceled,
            global::G.ResearchDtoClassVariant5? failed
            )
        {
            Pending = pending;
            Running = running;
            Completed = completed;
            Canceled = canceled;
            Failed = failed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Failed as object ??
            Canceled as object ??
            Completed as object ??
            Running as object ??
            Pending as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Pending?.ToString() ??
            Running?.ToString() ??
            Completed?.ToString() ??
            Canceled?.ToString() ??
            Failed?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPending && !IsRunning && !IsCompleted && !IsCanceled && !IsFailed || !IsPending && IsRunning && !IsCompleted && !IsCanceled && !IsFailed || !IsPending && !IsRunning && IsCompleted && !IsCanceled && !IsFailed || !IsPending && !IsRunning && !IsCompleted && IsCanceled && !IsFailed || !IsPending && !IsRunning && !IsCompleted && !IsCanceled && IsFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResearchDtoClassVariant1?, TResult>? pending = null,
            global::System.Func<global::G.ResearchDtoClassVariant2?, TResult>? running = null,
            global::System.Func<global::G.ResearchDtoClassVariant3?, TResult>? completed = null,
            global::System.Func<global::G.ResearchDtoClassVariant4?, TResult>? canceled = null,
            global::System.Func<global::G.ResearchDtoClassVariant5?, TResult>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPending && pending != null)
            {
                return pending(Pending!);
            }
            else if (IsRunning && running != null)
            {
                return running(Running!);
            }
            else if (IsCompleted && completed != null)
            {
                return completed(Completed!);
            }
            else if (IsCanceled && canceled != null)
            {
                return canceled(Canceled!);
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
            global::System.Action<global::G.ResearchDtoClassVariant1?>? pending = null,
            global::System.Action<global::G.ResearchDtoClassVariant2?>? running = null,
            global::System.Action<global::G.ResearchDtoClassVariant3?>? completed = null,
            global::System.Action<global::G.ResearchDtoClassVariant4?>? canceled = null,
            global::System.Action<global::G.ResearchDtoClassVariant5?>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPending)
            {
                pending?.Invoke(Pending!);
            }
            else if (IsRunning)
            {
                running?.Invoke(Running!);
            }
            else if (IsCompleted)
            {
                completed?.Invoke(Completed!);
            }
            else if (IsCanceled)
            {
                canceled?.Invoke(Canceled!);
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
                Pending,
                typeof(global::G.ResearchDtoClassVariant1),
                Running,
                typeof(global::G.ResearchDtoClassVariant2),
                Completed,
                typeof(global::G.ResearchDtoClassVariant3),
                Canceled,
                typeof(global::G.ResearchDtoClassVariant4),
                Failed,
                typeof(global::G.ResearchDtoClassVariant5),
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
        public bool Equals(ResearchDtoClass other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchDtoClassVariant1?>.Default.Equals(Pending, other.Pending) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchDtoClassVariant2?>.Default.Equals(Running, other.Running) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchDtoClassVariant3?>.Default.Equals(Completed, other.Completed) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchDtoClassVariant4?>.Default.Equals(Canceled, other.Canceled) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchDtoClassVariant5?>.Default.Equals(Failed, other.Failed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResearchDtoClass obj1, ResearchDtoClass obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResearchDtoClass>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResearchDtoClass obj1, ResearchDtoClass obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResearchDtoClass o && Equals(o);
        }
    }
}
