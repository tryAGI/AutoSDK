//HintName: G.Models.ResultRunsCountNumberScoresRecordStringScoreString.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultRunsCountNumberScoresRecordStringScoreString : global::System.IEquatable<ResultRunsCountNumberScoresRecordStringScoreString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResultSuccessRunsCountNumberScoresRecordStringScore? Success { get; init; }
#else
        public global::G.ResultSuccessRunsCountNumberScoresRecordStringScore? Success { get; }
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
        public static implicit operator ResultRunsCountNumberScoresRecordStringScoreString(global::G.ResultSuccessRunsCountNumberScoresRecordStringScore value) => new ResultRunsCountNumberScoresRecordStringScoreString((global::G.ResultSuccessRunsCountNumberScoresRecordStringScore?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultSuccessRunsCountNumberScoresRecordStringScore?(ResultRunsCountNumberScoresRecordStringScoreString @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public ResultRunsCountNumberScoresRecordStringScoreString(global::G.ResultSuccessRunsCountNumberScoresRecordStringScore? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultRunsCountNumberScoresRecordStringScoreString(global::G.ResultErrorString value) => new ResultRunsCountNumberScoresRecordStringScoreString((global::G.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultErrorString?(ResultRunsCountNumberScoresRecordStringScoreString @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResultRunsCountNumberScoresRecordStringScoreString(global::G.ResultErrorString? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultRunsCountNumberScoresRecordStringScoreString(
            global::G.ResultSuccessRunsCountNumberScoresRecordStringScore? success,
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
            global::System.Func<global::G.ResultSuccessRunsCountNumberScoresRecordStringScore?, TResult>? success = null,
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
            global::System.Action<global::G.ResultSuccessRunsCountNumberScoresRecordStringScore?>? success = null,
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
                typeof(global::G.ResultSuccessRunsCountNumberScoresRecordStringScore),
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
        public bool Equals(ResultRunsCountNumberScoresRecordStringScoreString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResultSuccessRunsCountNumberScoresRecordStringScore?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResultErrorString?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultRunsCountNumberScoresRecordStringScoreString obj1, ResultRunsCountNumberScoresRecordStringScoreString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultRunsCountNumberScoresRecordStringScoreString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultRunsCountNumberScoresRecordStringScoreString obj1, ResultRunsCountNumberScoresRecordStringScoreString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultRunsCountNumberScoresRecordStringScoreString o && Equals(o);
        }
    }
}
