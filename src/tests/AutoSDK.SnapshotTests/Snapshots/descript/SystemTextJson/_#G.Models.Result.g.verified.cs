//HintName: G.Models.Result.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Job result (only present when job_state is stopped)
    /// </summary>
    public readonly partial struct Result : global::System.IEquatable<Result>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ImportJobStatusResultDiscriminatorStatus? Status { get; }

        /// <summary>
        /// Result when media was imported (fully or partially)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImportSuccessResult? Success { get; init; }
#else
        public global::G.ImportSuccessResult? Success { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Success))]
#endif
        public bool IsSuccess => Success != null;

        /// <summary>
        /// Result when job failed completely
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImportErrorResult? Error { get; init; }
#else
        public global::G.ImportErrorResult? Error { get; }
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
        public static implicit operator Result(global::G.ImportSuccessResult value) => new Result((global::G.ImportSuccessResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImportSuccessResult?(Result @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::G.ImportSuccessResult? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result(global::G.ImportErrorResult value) => new Result((global::G.ImportErrorResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImportErrorResult?(Result @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::G.ImportErrorResult? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Result(
            global::G.ImportJobStatusResultDiscriminatorStatus? status,
            global::G.ImportSuccessResult? success,
            global::G.ImportErrorResult? error
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
            global::System.Func<global::G.ImportSuccessResult?, TResult>? success = null,
            global::System.Func<global::G.ImportErrorResult?, TResult>? error = null,
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
            global::System.Action<global::G.ImportSuccessResult?>? success = null,
            global::System.Action<global::G.ImportErrorResult?>? error = null,
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
                typeof(global::G.ImportSuccessResult),
                Error,
                typeof(global::G.ImportErrorResult),
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
        public bool Equals(Result other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ImportSuccessResult?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImportErrorResult?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Result obj1, Result obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Result>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Result obj1, Result obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Result o && Equals(o);
        }
    }
}
