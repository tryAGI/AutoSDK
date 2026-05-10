//HintName: G.Models.ResultTotalSpendNumberString.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultTotalSpendNumberString : global::System.IEquatable<ResultTotalSpendNumberString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResultSuccessTotalSpendNumber? Success { get; init; }
#else
        public global::G.ResultSuccessTotalSpendNumber? Success { get; }
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
        public bool TryPickSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResultSuccessTotalSpendNumber? value)
        {
            value = Success;
            return IsSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResultSuccessTotalSpendNumber PickSuccess() => IsSuccess
            ? Success!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Success' but the value was {ToString()}.");

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
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResultErrorString? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResultErrorString PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultTotalSpendNumberString(global::G.ResultSuccessTotalSpendNumber value) => new ResultTotalSpendNumberString((global::G.ResultSuccessTotalSpendNumber?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultSuccessTotalSpendNumber?(ResultTotalSpendNumberString @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public ResultTotalSpendNumberString(global::G.ResultSuccessTotalSpendNumber? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultTotalSpendNumberString FromSuccess(global::G.ResultSuccessTotalSpendNumber? value) => new ResultTotalSpendNumberString(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultTotalSpendNumberString(global::G.ResultErrorString value) => new ResultTotalSpendNumberString((global::G.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultErrorString?(ResultTotalSpendNumberString @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResultTotalSpendNumberString(global::G.ResultErrorString? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultTotalSpendNumberString FromError(global::G.ResultErrorString? value) => new ResultTotalSpendNumberString(value);

        /// <summary>
        /// 
        /// </summary>
        public ResultTotalSpendNumberString(
            global::G.ResultSuccessTotalSpendNumber? success,
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
            global::System.Func<global::G.ResultSuccessTotalSpendNumber, TResult>? success = null,
            global::System.Func<global::G.ResultErrorString, TResult>? error = null,
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
            global::System.Action<global::G.ResultSuccessTotalSpendNumber>? success = null,

            global::System.Action<global::G.ResultErrorString>? error = null,
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
        public void Switch(
            global::System.Action<global::G.ResultSuccessTotalSpendNumber>? success = null,
            global::System.Action<global::G.ResultErrorString>? error = null,
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
                typeof(global::G.ResultSuccessTotalSpendNumber),
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
        public bool Equals(ResultTotalSpendNumberString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResultSuccessTotalSpendNumber?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResultErrorString?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultTotalSpendNumberString obj1, ResultTotalSpendNumberString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultTotalSpendNumberString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultTotalSpendNumberString obj1, ResultTotalSpendNumberString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultTotalSpendNumberString o && Equals(o);
        }
    }
}
