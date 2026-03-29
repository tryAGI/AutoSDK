//HintName: G.Models.ResultLatencyOverTimeArrayString.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultLatencyOverTimeArrayString : global::System.IEquatable<ResultLatencyOverTimeArrayString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResultSuccessLatencyOverTimeArray? Success { get; init; }
#else
        public global::G.ResultSuccessLatencyOverTimeArray? Success { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Success))]
#endif
        public bool IsSuccess => Success != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResultErrorString? Error { get; init; }
#else
        public global::G.ResultErrorString? Error { get; }
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
        public static implicit operator ResultLatencyOverTimeArrayString(global::G.ResultSuccessLatencyOverTimeArray value) => new ResultLatencyOverTimeArrayString((global::G.ResultSuccessLatencyOverTimeArray?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultSuccessLatencyOverTimeArray?(ResultLatencyOverTimeArrayString @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public ResultLatencyOverTimeArrayString(global::G.ResultSuccessLatencyOverTimeArray? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultLatencyOverTimeArrayString(global::G.ResultErrorString value) => new ResultLatencyOverTimeArrayString((global::G.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultErrorString?(ResultLatencyOverTimeArrayString @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResultLatencyOverTimeArrayString(global::G.ResultErrorString? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultLatencyOverTimeArrayString(
            global::G.ResultSuccessLatencyOverTimeArray? success,
            global::G.ResultErrorString? error
            )
        {
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
            return IsSuccess || IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResultSuccessLatencyOverTimeArray?, TResult>? success = null,
            global::System.Func<global::G.ResultErrorString?, TResult>? error = null,
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
            global::System.Action<global::G.ResultSuccessLatencyOverTimeArray?>? success = null,
            global::System.Action<global::G.ResultErrorString?>? error = null,
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
                typeof(global::G.ResultSuccessLatencyOverTimeArray),
                Error,
                typeof(global::G.ResultErrorString),
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
        public bool Equals(ResultLatencyOverTimeArrayString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResultSuccessLatencyOverTimeArray?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResultErrorString?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultLatencyOverTimeArrayString obj1, ResultLatencyOverTimeArrayString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultLatencyOverTimeArrayString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultLatencyOverTimeArrayString obj1, ResultLatencyOverTimeArrayString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultLatencyOverTimeArrayString o && Equals(o);
        }
    }
}
