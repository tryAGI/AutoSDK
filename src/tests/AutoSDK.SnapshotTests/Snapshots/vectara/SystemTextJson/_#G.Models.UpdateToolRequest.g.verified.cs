//HintName: G.Models.UpdateToolRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update a tool. Supports updating MCP and Python lambda tools.
    /// </summary>
    public readonly partial struct UpdateToolRequest : global::System.IEquatable<UpdateToolRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateToolRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// Request object for updating an existing MCP tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdateMcpToolRequest? Mcp { get; init; }
#else
        public global::G.UpdateMcpToolRequest? Mcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mcp))]
#endif
        public bool IsMcp => Mcp != null;

        /// <summary>
        /// Request to update a lambda tool, allowing modifications to code, configuration, and metadata.<br/>
        /// When code is updated, input and output schemas are automatically re-discovered from function parameter type annotations.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdateLambdaToolRequest? Lambda { get; init; }
#else
        public global::G.UpdateLambdaToolRequest? Lambda { get; }
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
        public static implicit operator UpdateToolRequest(global::G.UpdateMcpToolRequest value) => new UpdateToolRequest((global::G.UpdateMcpToolRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateMcpToolRequest?(UpdateToolRequest @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public UpdateToolRequest(global::G.UpdateMcpToolRequest? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateToolRequest(global::G.UpdateLambdaToolRequest value) => new UpdateToolRequest((global::G.UpdateLambdaToolRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateLambdaToolRequest?(UpdateToolRequest @this) => @this.Lambda;

        /// <summary>
        /// 
        /// </summary>
        public UpdateToolRequest(global::G.UpdateLambdaToolRequest? value)
        {
            Lambda = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UpdateToolRequest(
            global::G.UpdateToolRequestDiscriminatorType? type,
            global::G.UpdateMcpToolRequest? mcp,
            global::G.UpdateLambdaToolRequest? lambda
            )
        {
            Type = type;

            Mcp = mcp;
            Lambda = lambda;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Lambda as object ??
            Mcp as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Mcp?.ToString() ??
            Lambda?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMcp && !IsLambda || !IsMcp && IsLambda;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.UpdateMcpToolRequest?, TResult>? mcp = null,
            global::System.Func<global::G.UpdateLambdaToolRequest?, TResult>? lambda = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcp && mcp != null)
            {
                return mcp(Mcp!);
            }
            else if (IsLambda && lambda != null)
            {
                return lambda(Lambda!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.UpdateMcpToolRequest?>? mcp = null,
            global::System.Action<global::G.UpdateLambdaToolRequest?>? lambda = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
            else if (IsLambda)
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
                Mcp,
                typeof(global::G.UpdateMcpToolRequest),
                Lambda,
                typeof(global::G.UpdateLambdaToolRequest),
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
        public bool Equals(UpdateToolRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateMcpToolRequest?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateLambdaToolRequest?>.Default.Equals(Lambda, other.Lambda) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateToolRequest obj1, UpdateToolRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateToolRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateToolRequest obj1, UpdateToolRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateToolRequest o && Equals(o);
        }
    }
}
