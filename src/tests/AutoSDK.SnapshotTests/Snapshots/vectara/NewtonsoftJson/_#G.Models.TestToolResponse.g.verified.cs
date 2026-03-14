//HintName: G.Models.TestToolResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Response from testing a Lambda tool. Uses type field to discriminate between success and error responses.
    /// </summary>
    public readonly partial struct TestToolResponse : global::System.IEquatable<TestToolResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.TestToolResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// Successful execution response from testing a Lambda tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TestToolSuccessResponse? Success { get; init; }
#else
        public global::G.TestToolSuccessResponse? Success { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Success))]
#endif
        public bool IsSuccess => Success != null;

        /// <summary>
        /// Error response from testing a Lambda tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TestToolErrorResponse? Error { get; init; }
#else
        public global::G.TestToolErrorResponse? Error { get; }
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
        public static implicit operator TestToolResponse(global::G.TestToolSuccessResponse value) => new TestToolResponse((global::G.TestToolSuccessResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TestToolSuccessResponse?(TestToolResponse @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public TestToolResponse(global::G.TestToolSuccessResponse? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestToolResponse(global::G.TestToolErrorResponse value) => new TestToolResponse((global::G.TestToolErrorResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TestToolErrorResponse?(TestToolResponse @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public TestToolResponse(global::G.TestToolErrorResponse? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TestToolResponse(
            global::G.TestToolResponseDiscriminatorType? type,
            global::G.TestToolSuccessResponse? success,
            global::G.TestToolErrorResponse? error
            )
        {
            Type = type;

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
            global::System.Func<global::G.TestToolSuccessResponse?, TResult>? success = null,
            global::System.Func<global::G.TestToolErrorResponse?, TResult>? error = null,
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
            global::System.Action<global::G.TestToolSuccessResponse?>? success = null,
            global::System.Action<global::G.TestToolErrorResponse?>? error = null,
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
                typeof(global::G.TestToolSuccessResponse),
                Error,
                typeof(global::G.TestToolErrorResponse),
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
        public bool Equals(TestToolResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TestToolSuccessResponse?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TestToolErrorResponse?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TestToolResponse obj1, TestToolResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestToolResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TestToolResponse obj1, TestToolResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestToolResponse o && Equals(o);
        }
    }
}
