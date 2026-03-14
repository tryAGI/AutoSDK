//HintName: G.Models.CreateToolRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create a tool. Currently supports lambda tools for user-defined functions.
    /// </summary>
    public readonly partial struct CreateToolRequest : global::System.IEquatable<CreateToolRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateToolRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// Request to create a new lambda tool. Lambda tools are user-defined functions that run in a secure, sandboxed environment with Python 3.12.<br/>
        /// Input and output schemas are automatically discovered from function parameter type annotations in your code.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateLambdaToolRequest? Lambda { get; init; }
#else
        public global::G.CreateLambdaToolRequest? Lambda { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lambda))]
#endif
        public bool IsLambda => Lambda != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateToolRequest(global::G.CreateLambdaToolRequest value) => new CreateToolRequest((global::G.CreateLambdaToolRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateLambdaToolRequest?(CreateToolRequest @this) => @this.Lambda;

        /// <summary>
        /// 
        /// </summary>
        public CreateToolRequest(global::G.CreateLambdaToolRequest? value)
        {
            Lambda = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateToolRequest(
            global::G.CreateToolRequestDiscriminatorType? type,
            global::G.CreateLambdaToolRequest? lambda
            )
        {
            Type = type;

            Lambda = lambda;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Lambda as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Lambda?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLambda;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateLambdaToolRequest?, TResult>? lambda = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLambda && lambda != null)
            {
                return lambda(Lambda!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateLambdaToolRequest?>? lambda = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLambda)
            {
                lambda?.Invoke(Lambda!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Lambda,
                typeof(global::G.CreateLambdaToolRequest),
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
        public bool Equals(CreateToolRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateLambdaToolRequest?>.Default.Equals(Lambda, other.Lambda) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateToolRequest obj1, CreateToolRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateToolRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateToolRequest obj1, CreateToolRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateToolRequest o && Equals(o);
        }
    }
}
