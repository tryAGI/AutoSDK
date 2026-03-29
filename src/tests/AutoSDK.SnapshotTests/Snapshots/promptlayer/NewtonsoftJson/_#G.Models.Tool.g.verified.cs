//HintName: G.Models.Tool.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Tool : global::System.IEquatable<Tool>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ToolDiscriminatorType? Type { get; }

        /// <summary>
        /// A custom function tool definition.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionTool? Function { get; init; }
#else
        public global::G.FunctionTool? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// A provider-native built-in tool (e.g. web search, code interpreter, bash).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BuiltInTool? WebSearch { get; init; }
#else
        public global::G.BuiltInTool? WebSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.FunctionTool value) => new Tool((global::G.FunctionTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionTool?(Tool @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.FunctionTool? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.BuiltInTool value) => new Tool((global::G.BuiltInTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BuiltInTool?(Tool @this) => @this.WebSearch;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.BuiltInTool? value)
        {
            WebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Tool(
            global::G.ToolDiscriminatorType? type,
            global::G.FunctionTool? function,
            global::G.BuiltInTool? webSearch
            )
        {
            Type = type;

            Function = function;
            WebSearch = webSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebSearch as object ??
            Function as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            WebSearch?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsWebSearch || !IsFunction && IsWebSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FunctionTool?, TResult>? function = null,
            global::System.Func<global::G.BuiltInTool?, TResult>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsWebSearch && webSearch != null)
            {
                return webSearch(WebSearch!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.FunctionTool?>? function = null,
            global::System.Action<global::G.BuiltInTool?>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Function,
                typeof(global::G.FunctionTool),
                WebSearch,
                typeof(global::G.BuiltInTool),
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
        public bool Equals(Tool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionTool?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BuiltInTool?>.Default.Equals(WebSearch, other.WebSearch) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Tool obj1, Tool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Tool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Tool obj1, Tool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Tool o && Equals(o);
        }
    }
}
