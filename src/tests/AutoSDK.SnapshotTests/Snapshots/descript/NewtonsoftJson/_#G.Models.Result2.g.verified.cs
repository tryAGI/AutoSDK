//HintName: G.Models.Result2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Job result (only present when job_state is stopped)
    /// </summary>
    public readonly partial struct Result2 : global::System.IEquatable<Result2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.AgentJobStatusResultDiscriminatorStatus? Status { get; }

        /// <summary>
        /// Result when Agent edit completed successfully
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentSuccessResult? Success { get; init; }
#else
        public global::G.AgentSuccessResult? Success { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Success))]
#endif
        public bool IsSuccess => Success != null;

        /// <summary>
        /// Result when Agent edit failed
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentErrorResult? Error { get; init; }
#else
        public global::G.AgentErrorResult? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result2(global::G.AgentSuccessResult value) => new Result2((global::G.AgentSuccessResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentSuccessResult?(Result2 @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public Result2(global::G.AgentSuccessResult? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result2(global::G.AgentErrorResult value) => new Result2((global::G.AgentErrorResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentErrorResult?(Result2 @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public Result2(global::G.AgentErrorResult? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Result2(
            global::G.AgentJobStatusResultDiscriminatorStatus? status,
            global::G.AgentSuccessResult? success,
            global::G.AgentErrorResult? error
            )
        {
            Status = status;

            Success = success;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            Success as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Success?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSuccess && !IsError || !IsSuccess && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AgentSuccessResult?, TResult>? success = null,
            global::System.Func<global::G.AgentErrorResult?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess && success != null)
            {
                return success(Success!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AgentSuccessResult?>? success = null,
            global::System.Action<global::G.AgentErrorResult?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess)
            {
                success?.Invoke(Success!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Success,
                typeof(global::G.AgentSuccessResult),
                Error,
                typeof(global::G.AgentErrorResult),
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
                global::System.Collections.Generic.EqualityComparer<global::G.AgentSuccessResult?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AgentErrorResult?>.Default.Equals(Error, other.Error) 
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
