//HintName: G.Models.Result2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Processing result for this request.<br/>
    /// Contains a Message output if processing was successful, an error response if processing failed, or the reason why processing was not attempted, such as cancellation or expiration.
    /// </summary>
    public readonly partial struct Result2 : global::System.IEquatable<Result2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaMessageBatchIndividualResponseResultDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaSucceededResult? Succeeded { get; init; }
#else
        public global::G.BetaSucceededResult? Succeeded { get; }
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
        public bool TryPickSucceeded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.BetaSucceededResult? value)
        {
            value = Succeeded;
            return IsSucceeded;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaSucceededResult PickSucceeded() => Succeeded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Succeeded' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaErroredResult? Errored { get; init; }
#else
        public global::G.BetaErroredResult? Errored { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Errored))]
#endif
        public bool IsErrored => Errored != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickErrored(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.BetaErroredResult? value)
        {
            value = Errored;
            return IsErrored;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaErroredResult PickErrored() => Errored is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Errored' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaCanceledResult? Canceled { get; init; }
#else
        public global::G.BetaCanceledResult? Canceled { get; }
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
        public bool TryPickCanceled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.BetaCanceledResult? value)
        {
            value = Canceled;
            return IsCanceled;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaCanceledResult PickCanceled() => Canceled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Canceled' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaExpiredResult? Expired { get; init; }
#else
        public global::G.BetaExpiredResult? Expired { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Expired))]
#endif
        public bool IsExpired => Expired != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickExpired(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.BetaExpiredResult? value)
        {
            value = Expired;
            return IsExpired;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaExpiredResult PickExpired() => Expired is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Expired' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result2(global::G.BetaSucceededResult value) => new Result2((global::G.BetaSucceededResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaSucceededResult?(Result2 @this) => @this.Succeeded;

        /// <summary>
        /// 
        /// </summary>
        public Result2(global::G.BetaSucceededResult? value)
        {
            Succeeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Result2 FromSucceeded(global::G.BetaSucceededResult? value) => new Result2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result2(global::G.BetaErroredResult value) => new Result2((global::G.BetaErroredResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaErroredResult?(Result2 @this) => @this.Errored;

        /// <summary>
        /// 
        /// </summary>
        public Result2(global::G.BetaErroredResult? value)
        {
            Errored = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Result2 FromErrored(global::G.BetaErroredResult? value) => new Result2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result2(global::G.BetaCanceledResult value) => new Result2((global::G.BetaCanceledResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaCanceledResult?(Result2 @this) => @this.Canceled;

        /// <summary>
        /// 
        /// </summary>
        public Result2(global::G.BetaCanceledResult? value)
        {
            Canceled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Result2 FromCanceled(global::G.BetaCanceledResult? value) => new Result2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result2(global::G.BetaExpiredResult value) => new Result2((global::G.BetaExpiredResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaExpiredResult?(Result2 @this) => @this.Expired;

        /// <summary>
        /// 
        /// </summary>
        public Result2(global::G.BetaExpiredResult? value)
        {
            Expired = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Result2 FromExpired(global::G.BetaExpiredResult? value) => new Result2(value);

        /// <summary>
        /// 
        /// </summary>
        public Result2(
            global::G.BetaMessageBatchIndividualResponseResultDiscriminatorType? type,
            global::G.BetaSucceededResult? succeeded,
            global::G.BetaErroredResult? errored,
            global::G.BetaCanceledResult? canceled,
            global::G.BetaExpiredResult? expired
            )
        {
            Type = type;

            Succeeded = succeeded;
            Errored = errored;
            Canceled = canceled;
            Expired = expired;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Expired as object ??
            Canceled as object ??
            Errored as object ??
            Succeeded as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Succeeded?.ToString() ??
            Errored?.ToString() ??
            Canceled?.ToString() ??
            Expired?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSucceeded && !IsErrored && !IsCanceled && !IsExpired || !IsSucceeded && IsErrored && !IsCanceled && !IsExpired || !IsSucceeded && !IsErrored && IsCanceled && !IsExpired || !IsSucceeded && !IsErrored && !IsCanceled && IsExpired;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BetaSucceededResult, TResult>? succeeded = null,
            global::System.Func<global::G.BetaErroredResult, TResult>? errored = null,
            global::System.Func<global::G.BetaCanceledResult, TResult>? canceled = null,
            global::System.Func<global::G.BetaExpiredResult, TResult>? expired = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Succeeded is { } __value0 && succeeded != null)
            {
                return succeeded(__value0);
            }
            else if (Errored is { } __value1 && errored != null)
            {
                return errored(__value1);
            }
            else if (Canceled is { } __value2 && canceled != null)
            {
                return canceled(__value2);
            }
            else if (Expired is { } __value3 && expired != null)
            {
                return expired(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BetaSucceededResult>? succeeded = null,

            global::System.Action<global::G.BetaErroredResult>? errored = null,

            global::System.Action<global::G.BetaCanceledResult>? canceled = null,

            global::System.Action<global::G.BetaExpiredResult>? expired = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Succeeded is { } __value0)
            {
                succeeded?.Invoke(__value0);
            }
            else if (Errored is { } __value1)
            {
                errored?.Invoke(__value1);
            }
            else if (Canceled is { } __value2)
            {
                canceled?.Invoke(__value2);
            }
            else if (Expired is { } __value3)
            {
                expired?.Invoke(__value3);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.BetaSucceededResult>? succeeded = null,
            global::System.Action<global::G.BetaErroredResult>? errored = null,
            global::System.Action<global::G.BetaCanceledResult>? canceled = null,
            global::System.Action<global::G.BetaExpiredResult>? expired = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Succeeded is { } __value0)
            {
                succeeded?.Invoke(__value0);
            }
            else if (Errored is { } __value1)
            {
                errored?.Invoke(__value1);
            }
            else if (Canceled is { } __value2)
            {
                canceled?.Invoke(__value2);
            }
            else if (Expired is { } __value3)
            {
                expired?.Invoke(__value3);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Succeeded,
                typeof(global::G.BetaSucceededResult),
                Errored,
                typeof(global::G.BetaErroredResult),
                Canceled,
                typeof(global::G.BetaCanceledResult),
                Expired,
                typeof(global::G.BetaExpiredResult),
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
        public bool Equals(Result2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BetaSucceededResult?>.Default.Equals(Succeeded, other.Succeeded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaErroredResult?>.Default.Equals(Errored, other.Errored) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaCanceledResult?>.Default.Equals(Canceled, other.Canceled) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaExpiredResult?>.Default.Equals(Expired, other.Expired) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Result2 obj1, Result2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Result2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Result2 obj1, Result2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Result2 o && Equals(o);
        }
    }
}
