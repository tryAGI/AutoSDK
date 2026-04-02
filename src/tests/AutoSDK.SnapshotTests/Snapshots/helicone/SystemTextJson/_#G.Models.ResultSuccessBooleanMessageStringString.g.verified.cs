//HintName: G.Models.ResultSuccessBooleanMessageStringString.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultSuccessBooleanMessageStringString : global::System.IEquatable<ResultSuccessBooleanMessageStringString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResultSuccessSuccessBooleanMessageString? ResultSuccessSuccessBooleanMessageString { get; init; }
#else
        public global::G.ResultSuccessSuccessBooleanMessageString? ResultSuccessSuccessBooleanMessageString { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResultSuccessSuccessBooleanMessageString))]
#endif
        public bool IsResultSuccessSuccessBooleanMessageString => ResultSuccessSuccessBooleanMessageString != null;

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
        public static implicit operator ResultSuccessBooleanMessageStringString(global::G.ResultSuccessSuccessBooleanMessageString value) => new ResultSuccessBooleanMessageStringString((global::G.ResultSuccessSuccessBooleanMessageString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultSuccessSuccessBooleanMessageString?(ResultSuccessBooleanMessageStringString @this) => @this.ResultSuccessSuccessBooleanMessageString;

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanMessageStringString(global::G.ResultSuccessSuccessBooleanMessageString? value)
        {
            ResultSuccessSuccessBooleanMessageString = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultSuccessBooleanMessageStringString(global::G.ResultErrorString value) => new ResultSuccessBooleanMessageStringString((global::G.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultErrorString?(ResultSuccessBooleanMessageStringString @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanMessageStringString(global::G.ResultErrorString? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanMessageStringString(
            global::G.ResultSuccessSuccessBooleanMessageString? resultSuccessSuccessBooleanMessageString,
            global::G.ResultErrorString? error
            )
        {
            ResultSuccessSuccessBooleanMessageString = resultSuccessSuccessBooleanMessageString;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            ResultSuccessSuccessBooleanMessageString as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResultSuccessSuccessBooleanMessageString?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResultSuccessSuccessBooleanMessageString || IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResultSuccessSuccessBooleanMessageString?, TResult>? resultSuccessSuccessBooleanMessageString = null,
            global::System.Func<global::G.ResultErrorString?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResultSuccessSuccessBooleanMessageString && resultSuccessSuccessBooleanMessageString != null)
            {
                return resultSuccessSuccessBooleanMessageString(ResultSuccessSuccessBooleanMessageString!);
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
            global::System.Action<global::G.ResultSuccessSuccessBooleanMessageString?>? resultSuccessSuccessBooleanMessageString = null,
            global::System.Action<global::G.ResultErrorString?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResultSuccessSuccessBooleanMessageString)
            {
                resultSuccessSuccessBooleanMessageString?.Invoke(ResultSuccessSuccessBooleanMessageString!);
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
                ResultSuccessSuccessBooleanMessageString,
                typeof(global::G.ResultSuccessSuccessBooleanMessageString),
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
        public bool Equals(ResultSuccessBooleanMessageStringString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResultSuccessSuccessBooleanMessageString?>.Default.Equals(ResultSuccessSuccessBooleanMessageString, other.ResultSuccessSuccessBooleanMessageString) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResultErrorString?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultSuccessBooleanMessageStringString obj1, ResultSuccessBooleanMessageStringString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultSuccessBooleanMessageStringString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultSuccessBooleanMessageStringString obj1, ResultSuccessBooleanMessageStringString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultSuccessBooleanMessageStringString o && Equals(o);
        }
    }
}
