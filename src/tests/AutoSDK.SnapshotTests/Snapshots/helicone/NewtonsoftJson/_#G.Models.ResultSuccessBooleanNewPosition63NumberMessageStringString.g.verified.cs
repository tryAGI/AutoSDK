//HintName: G.Models.ResultSuccessBooleanNewPosition63NumberMessageStringString.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultSuccessBooleanNewPosition63NumberMessageStringString : global::System.IEquatable<ResultSuccessBooleanNewPosition63NumberMessageStringString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResultSuccessSuccessBooleanNewPosition63NumberMessageString? ResultSuccessSuccessBooleanNewPosition63NumberMessageString { get; init; }
#else
        public global::G.ResultSuccessSuccessBooleanNewPosition63NumberMessageString? ResultSuccessSuccessBooleanNewPosition63NumberMessageString { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResultSuccessSuccessBooleanNewPosition63NumberMessageString))]
#endif
        public bool IsResultSuccessSuccessBooleanNewPosition63NumberMessageString => ResultSuccessSuccessBooleanNewPosition63NumberMessageString != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResultSuccessSuccessBooleanNewPosition63NumberMessageString(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ResultSuccessSuccessBooleanNewPosition63NumberMessageString? value)
        {
            value = ResultSuccessSuccessBooleanNewPosition63NumberMessageString;
            return IsResultSuccessSuccessBooleanNewPosition63NumberMessageString;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ResultSuccessSuccessBooleanNewPosition63NumberMessageString PickResultSuccessSuccessBooleanNewPosition63NumberMessageString() => ResultSuccessSuccessBooleanNewPosition63NumberMessageString is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResultSuccessSuccessBooleanNewPosition63NumberMessageString' but the value was {ToString()}.");

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
        public global::G.ResultErrorString PickError() => Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultSuccessBooleanNewPosition63NumberMessageStringString(global::G.ResultSuccessSuccessBooleanNewPosition63NumberMessageString value) => new ResultSuccessBooleanNewPosition63NumberMessageStringString((global::G.ResultSuccessSuccessBooleanNewPosition63NumberMessageString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultSuccessSuccessBooleanNewPosition63NumberMessageString?(ResultSuccessBooleanNewPosition63NumberMessageStringString @this) => @this.ResultSuccessSuccessBooleanNewPosition63NumberMessageString;

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanNewPosition63NumberMessageStringString(global::G.ResultSuccessSuccessBooleanNewPosition63NumberMessageString? value)
        {
            ResultSuccessSuccessBooleanNewPosition63NumberMessageString = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultSuccessBooleanNewPosition63NumberMessageStringString FromResultSuccessSuccessBooleanNewPosition63NumberMessageString(global::G.ResultSuccessSuccessBooleanNewPosition63NumberMessageString? value) => new ResultSuccessBooleanNewPosition63NumberMessageStringString(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultSuccessBooleanNewPosition63NumberMessageStringString(global::G.ResultErrorString value) => new ResultSuccessBooleanNewPosition63NumberMessageStringString((global::G.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResultErrorString?(ResultSuccessBooleanNewPosition63NumberMessageStringString @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanNewPosition63NumberMessageStringString(global::G.ResultErrorString? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultSuccessBooleanNewPosition63NumberMessageStringString FromError(global::G.ResultErrorString? value) => new ResultSuccessBooleanNewPosition63NumberMessageStringString(value);

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanNewPosition63NumberMessageStringString(
            global::G.ResultSuccessSuccessBooleanNewPosition63NumberMessageString? resultSuccessSuccessBooleanNewPosition63NumberMessageString,
            global::G.ResultErrorString? error
            )
        {
            ResultSuccessSuccessBooleanNewPosition63NumberMessageString = resultSuccessSuccessBooleanNewPosition63NumberMessageString;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            ResultSuccessSuccessBooleanNewPosition63NumberMessageString as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResultSuccessSuccessBooleanNewPosition63NumberMessageString?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResultSuccessSuccessBooleanNewPosition63NumberMessageString || IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResultSuccessSuccessBooleanNewPosition63NumberMessageString, TResult>? resultSuccessSuccessBooleanNewPosition63NumberMessageString = null,
            global::System.Func<global::G.ResultErrorString, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResultSuccessSuccessBooleanNewPosition63NumberMessageString is { } __value0 && resultSuccessSuccessBooleanNewPosition63NumberMessageString != null)
            {
                return resultSuccessSuccessBooleanNewPosition63NumberMessageString(__value0);
            }
            else if (Error is { } __value1 && error != null)
            {
                return error(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResultSuccessSuccessBooleanNewPosition63NumberMessageString>? resultSuccessSuccessBooleanNewPosition63NumberMessageString = null,

            global::System.Action<global::G.ResultErrorString>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResultSuccessSuccessBooleanNewPosition63NumberMessageString is { } __value0)
            {
                resultSuccessSuccessBooleanNewPosition63NumberMessageString?.Invoke(__value0);
            }
            else if (Error is { } __value1)
            {
                error?.Invoke(__value1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.ResultSuccessSuccessBooleanNewPosition63NumberMessageString>? resultSuccessSuccessBooleanNewPosition63NumberMessageString = null,
            global::System.Action<global::G.ResultErrorString>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResultSuccessSuccessBooleanNewPosition63NumberMessageString is { } __value0)
            {
                resultSuccessSuccessBooleanNewPosition63NumberMessageString?.Invoke(__value0);
            }
            else if (Error is { } __value1)
            {
                error?.Invoke(__value1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResultSuccessSuccessBooleanNewPosition63NumberMessageString,
                typeof(global::G.ResultSuccessSuccessBooleanNewPosition63NumberMessageString),
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
        public bool Equals(ResultSuccessBooleanNewPosition63NumberMessageStringString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResultSuccessSuccessBooleanNewPosition63NumberMessageString?>.Default.Equals(ResultSuccessSuccessBooleanNewPosition63NumberMessageString, other.ResultSuccessSuccessBooleanNewPosition63NumberMessageString) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResultErrorString?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultSuccessBooleanNewPosition63NumberMessageStringString obj1, ResultSuccessBooleanNewPosition63NumberMessageStringString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultSuccessBooleanNewPosition63NumberMessageStringString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultSuccessBooleanNewPosition63NumberMessageStringString obj1, ResultSuccessBooleanNewPosition63NumberMessageStringString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultSuccessBooleanNewPosition63NumberMessageStringString o && Equals(o);
        }
    }
}
