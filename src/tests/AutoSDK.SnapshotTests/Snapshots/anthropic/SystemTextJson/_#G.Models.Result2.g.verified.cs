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
        public global::G.MessageBatchIndividualResponseResultDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SucceededResult? Succeeded { get; init; }
#else
        public global::G.SucceededResult? Succeeded { get; }
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
        public static implicit operator Result2(global::G.SucceededResult value) => new Result2((global::G.SucceededResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SucceededResult?(Result2 @this) => @this.Succeeded;

        /// <summary>
        /// 
        /// </summary>
        public Result2(global::G.SucceededResult? value)
        {
            Succeeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ErroredResult? Errored { get; init; }
#else
        public global::G.ErroredResult? Errored { get; }
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
        public static implicit operator Result2(global::G.ErroredResult value) => new Result2((global::G.ErroredResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ErroredResult?(Result2 @this) => @this.Errored;

        /// <summary>
        /// 
        /// </summary>
        public Result2(global::G.ErroredResult? value)
        {
            Errored = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CanceledResult? Canceled { get; init; }
#else
        public global::G.CanceledResult? Canceled { get; }
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
        public static implicit operator Result2(global::G.CanceledResult value) => new Result2((global::G.CanceledResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CanceledResult?(Result2 @this) => @this.Canceled;

        /// <summary>
        /// 
        /// </summary>
        public Result2(global::G.CanceledResult? value)
        {
            Canceled = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExpiredResult? Expired { get; init; }
#else
        public global::G.ExpiredResult? Expired { get; }
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
        public static implicit operator Result2(global::G.ExpiredResult value) => new Result2((global::G.ExpiredResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExpiredResult?(Result2 @this) => @this.Expired;

        /// <summary>
        /// 
        /// </summary>
        public Result2(global::G.ExpiredResult? value)
        {
            Expired = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Result2(
            global::G.MessageBatchIndividualResponseResultDiscriminatorType? type,
            global::G.SucceededResult? succeeded,
            global::G.ErroredResult? errored,
            global::G.CanceledResult? canceled,
            global::G.ExpiredResult? expired
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
            global::System.Func<global::G.SucceededResult?, TResult>? succeeded = null,
            global::System.Func<global::G.ErroredResult?, TResult>? errored = null,
            global::System.Func<global::G.CanceledResult?, TResult>? canceled = null,
            global::System.Func<global::G.ExpiredResult?, TResult>? expired = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSucceeded && succeeded != null)
            {
                return succeeded(Succeeded!);
            }
            else if (IsErrored && errored != null)
            {
                return errored(Errored!);
            }
            else if (IsCanceled && canceled != null)
            {
                return canceled(Canceled!);
            }
            else if (IsExpired && expired != null)
            {
                return expired(Expired!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SucceededResult?>? succeeded = null,
            global::System.Action<global::G.ErroredResult?>? errored = null,
            global::System.Action<global::G.CanceledResult?>? canceled = null,
            global::System.Action<global::G.ExpiredResult?>? expired = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSucceeded)
            {
                succeeded?.Invoke(Succeeded!);
            }
            else if (IsErrored)
            {
                errored?.Invoke(Errored!);
            }
            else if (IsCanceled)
            {
                canceled?.Invoke(Canceled!);
            }
            else if (IsExpired)
            {
                expired?.Invoke(Expired!);
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
                typeof(global::G.SucceededResult),
                Errored,
                typeof(global::G.ErroredResult),
                Canceled,
                typeof(global::G.CanceledResult),
                Expired,
                typeof(global::G.ExpiredResult),
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
                global::System.Collections.Generic.EqualityComparer<global::G.SucceededResult?>.Default.Equals(Succeeded, other.Succeeded) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ErroredResult?>.Default.Equals(Errored, other.Errored) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CanceledResult?>.Default.Equals(Canceled, other.Canceled) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ExpiredResult?>.Default.Equals(Expired, other.Expired) 
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
