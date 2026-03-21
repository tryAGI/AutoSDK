//HintName: G.Models.GetTasksResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetTasksResponse : global::System.IEquatable<GetTasksResponse>
    {
        /// <summary>
        /// A pending task
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetTasksResponseVariant1? Pending { get; init; }
#else
        public global::G.GetTasksResponseVariant1? Pending { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pending))]
#endif
        public bool IsPending => Pending != null;

        /// <summary>
        /// A throttled task
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetTasksResponseVariant2? Throttled { get; init; }
#else
        public global::G.GetTasksResponseVariant2? Throttled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Throttled))]
#endif
        public bool IsThrottled => Throttled != null;

        /// <summary>
        /// A cancelled or deleted task
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetTasksResponseVariant3? Cancelled { get; init; }
#else
        public global::G.GetTasksResponseVariant3? Cancelled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cancelled))]
#endif
        public bool IsCancelled => Cancelled != null;

        /// <summary>
        /// A running task
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetTasksResponseVariant4? Running { get; init; }
#else
        public global::G.GetTasksResponseVariant4? Running { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Running))]
#endif
        public bool IsRunning => Running != null;

        /// <summary>
        /// A failed task
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetTasksResponseVariant5? Failed { get; init; }
#else
        public global::G.GetTasksResponseVariant5? Failed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Failed))]
#endif
        public bool IsFailed => Failed != null;

        /// <summary>
        /// A succeeded task
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetTasksResponseVariant6? Succeeded { get; init; }
#else
        public global::G.GetTasksResponseVariant6? Succeeded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Succeeded))]
#endif
        public bool IsSucceeded => Succeeded != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetTasksResponse(global::G.GetTasksResponseVariant1 value) => new GetTasksResponse((global::G.GetTasksResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetTasksResponseVariant1?(GetTasksResponse @this) => @this.Pending;

        /// <summary>
        /// 
        /// </summary>
        public GetTasksResponse(global::G.GetTasksResponseVariant1? value)
        {
            Pending = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetTasksResponse(global::G.GetTasksResponseVariant2 value) => new GetTasksResponse((global::G.GetTasksResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetTasksResponseVariant2?(GetTasksResponse @this) => @this.Throttled;

        /// <summary>
        /// 
        /// </summary>
        public GetTasksResponse(global::G.GetTasksResponseVariant2? value)
        {
            Throttled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetTasksResponse(global::G.GetTasksResponseVariant3 value) => new GetTasksResponse((global::G.GetTasksResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetTasksResponseVariant3?(GetTasksResponse @this) => @this.Cancelled;

        /// <summary>
        /// 
        /// </summary>
        public GetTasksResponse(global::G.GetTasksResponseVariant3? value)
        {
            Cancelled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetTasksResponse(global::G.GetTasksResponseVariant4 value) => new GetTasksResponse((global::G.GetTasksResponseVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetTasksResponseVariant4?(GetTasksResponse @this) => @this.Running;

        /// <summary>
        /// 
        /// </summary>
        public GetTasksResponse(global::G.GetTasksResponseVariant4? value)
        {
            Running = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetTasksResponse(global::G.GetTasksResponseVariant5 value) => new GetTasksResponse((global::G.GetTasksResponseVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetTasksResponseVariant5?(GetTasksResponse @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public GetTasksResponse(global::G.GetTasksResponseVariant5? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetTasksResponse(global::G.GetTasksResponseVariant6 value) => new GetTasksResponse((global::G.GetTasksResponseVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetTasksResponseVariant6?(GetTasksResponse @this) => @this.Succeeded;

        /// <summary>
        /// 
        /// </summary>
        public GetTasksResponse(global::G.GetTasksResponseVariant6? value)
        {
            Succeeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetTasksResponse(
            global::G.GetTasksResponseVariant1? pending,
            global::G.GetTasksResponseVariant2? throttled,
            global::G.GetTasksResponseVariant3? cancelled,
            global::G.GetTasksResponseVariant4? running,
            global::G.GetTasksResponseVariant5? failed,
            global::G.GetTasksResponseVariant6? succeeded
            )
        {
            Pending = pending;
            Throttled = throttled;
            Cancelled = cancelled;
            Running = running;
            Failed = failed;
            Succeeded = succeeded;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Succeeded as object ??
            Failed as object ??
            Running as object ??
            Cancelled as object ??
            Throttled as object ??
            Pending as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Pending?.ToString() ??
            Throttled?.ToString() ??
            Cancelled?.ToString() ??
            Running?.ToString() ??
            Failed?.ToString() ??
            Succeeded?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPending && !IsThrottled && !IsCancelled && !IsRunning && !IsFailed && !IsSucceeded || !IsPending && IsThrottled && !IsCancelled && !IsRunning && !IsFailed && !IsSucceeded || !IsPending && !IsThrottled && IsCancelled && !IsRunning && !IsFailed && !IsSucceeded || !IsPending && !IsThrottled && !IsCancelled && IsRunning && !IsFailed && !IsSucceeded || !IsPending && !IsThrottled && !IsCancelled && !IsRunning && IsFailed && !IsSucceeded || !IsPending && !IsThrottled && !IsCancelled && !IsRunning && !IsFailed && IsSucceeded;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GetTasksResponseVariant1?, TResult>? pending = null,
            global::System.Func<global::G.GetTasksResponseVariant2?, TResult>? throttled = null,
            global::System.Func<global::G.GetTasksResponseVariant3?, TResult>? cancelled = null,
            global::System.Func<global::G.GetTasksResponseVariant4?, TResult>? running = null,
            global::System.Func<global::G.GetTasksResponseVariant5?, TResult>? failed = null,
            global::System.Func<global::G.GetTasksResponseVariant6?, TResult>? succeeded = null,
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
            else if (IsThrottled && throttled != null)
            {
                return throttled(Throttled!);
            }
            else if (IsCancelled && cancelled != null)
            {
                return cancelled(Cancelled!);
            }
            else if (IsRunning && running != null)
            {
                return running(Running!);
            }
            else if (IsFailed && failed != null)
            {
                return failed(Failed!);
            }
            else if (IsSucceeded && succeeded != null)
            {
                return succeeded(Succeeded!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GetTasksResponseVariant1?>? pending = null,
            global::System.Action<global::G.GetTasksResponseVariant2?>? throttled = null,
            global::System.Action<global::G.GetTasksResponseVariant3?>? cancelled = null,
            global::System.Action<global::G.GetTasksResponseVariant4?>? running = null,
            global::System.Action<global::G.GetTasksResponseVariant5?>? failed = null,
            global::System.Action<global::G.GetTasksResponseVariant6?>? succeeded = null,
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
            else if (IsThrottled)
            {
                throttled?.Invoke(Throttled!);
            }
            else if (IsCancelled)
            {
                cancelled?.Invoke(Cancelled!);
            }
            else if (IsRunning)
            {
                running?.Invoke(Running!);
            }
            else if (IsFailed)
            {
                failed?.Invoke(Failed!);
            }
            else if (IsSucceeded)
            {
                succeeded?.Invoke(Succeeded!);
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
                typeof(global::G.GetTasksResponseVariant1),
                Throttled,
                typeof(global::G.GetTasksResponseVariant2),
                Cancelled,
                typeof(global::G.GetTasksResponseVariant3),
                Running,
                typeof(global::G.GetTasksResponseVariant4),
                Failed,
                typeof(global::G.GetTasksResponseVariant5),
                Succeeded,
                typeof(global::G.GetTasksResponseVariant6),
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
        public bool Equals(GetTasksResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GetTasksResponseVariant1?>.Default.Equals(Pending, other.Pending) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetTasksResponseVariant2?>.Default.Equals(Throttled, other.Throttled) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetTasksResponseVariant3?>.Default.Equals(Cancelled, other.Cancelled) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetTasksResponseVariant4?>.Default.Equals(Running, other.Running) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetTasksResponseVariant5?>.Default.Equals(Failed, other.Failed) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetTasksResponseVariant6?>.Default.Equals(Succeeded, other.Succeeded) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetTasksResponse obj1, GetTasksResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetTasksResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetTasksResponse obj1, GetTasksResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetTasksResponse o && Equals(o);
        }
    }
}
