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
        /// A tool that searches for relevant content from uploaded files.<br/>
        /// Learn more about the [file search tool](/docs/guides/tools-file-search).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FileSearchTool? FileSearch { get; init; }
#else
        public global::G.FileSearchTool? FileSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearch))]
#endif
        public bool IsFileSearch => FileSearch != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.FileSearchTool value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FileSearchTool?(Tool @this) => @this.FileSearch;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.FileSearchTool? value)
        {
            FileSearch = value;
        }

        /// <summary>
        /// Defines a function in your own code the model can choose to call. Learn more<br/>
        /// about [function calling](/docs/guides/function-calling).
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
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.FunctionTool value) => new Tool(value);

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
        /// A tool that controls a virtual computer. Learn more about the <br/>
        /// [computer tool](/docs/guides/tools-computer-use).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ComputerTool? Computer { get; init; }
#else
        public global::G.ComputerTool? Computer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Computer))]
#endif
        public bool IsComputer => Computer != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.ComputerTool value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComputerTool?(Tool @this) => @this.Computer;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.ComputerTool? value)
        {
            Computer = value;
        }

        /// <summary>
        /// This tool searches the web for relevant results to use in a response.<br/>
        /// Learn more about the [web search tool](/docs/guides/tools-web-search).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebSearchTool? WebSearch { get; init; }
#else
        public global::G.WebSearchTool? WebSearch { get; }
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
        public static implicit operator Tool(global::G.WebSearchTool value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebSearchTool?(Tool @this) => @this.WebSearch;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.WebSearchTool? value)
        {
            WebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Tool(
            global::G.FileSearchTool? fileSearch,
            global::G.FunctionTool? function,
            global::G.ComputerTool? computer,
            global::G.WebSearchTool? webSearch
            )
        {
            FileSearch = fileSearch;
            Function = function;
            Computer = computer;
            WebSearch = webSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebSearch as object ??
            Computer as object ??
            Function as object ??
            FileSearch as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FileSearch?.ToString() ??
            Function?.ToString() ??
            Computer?.ToString() ??
            WebSearch?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileSearch && !IsFunction && !IsComputer && !IsWebSearch || !IsFileSearch && IsFunction && !IsComputer && !IsWebSearch || !IsFileSearch && !IsFunction && IsComputer && !IsWebSearch || !IsFileSearch && !IsFunction && !IsComputer && IsWebSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FileSearchTool?, TResult>? fileSearch = null,
            global::System.Func<global::G.FunctionTool?, TResult>? function = null,
            global::System.Func<global::G.ComputerTool?, TResult>? computer = null,
            global::System.Func<global::G.WebSearchTool?, TResult>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileSearch && fileSearch != null)
            {
                return fileSearch(FileSearch!);
            }
            else if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsComputer && computer != null)
            {
                return computer(Computer!);
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
            global::System.Action<global::G.FileSearchTool?>? fileSearch = null,
            global::System.Action<global::G.FunctionTool?>? function = null,
            global::System.Action<global::G.ComputerTool?>? computer = null,
            global::System.Action<global::G.WebSearchTool?>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileSearch)
            {
                fileSearch?.Invoke(FileSearch!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsComputer)
            {
                computer?.Invoke(Computer!);
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
                FileSearch,
                typeof(global::G.FileSearchTool),
                Function,
                typeof(global::G.FunctionTool),
                Computer,
                typeof(global::G.ComputerTool),
                WebSearch,
                typeof(global::G.WebSearchTool),
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
                global::System.Collections.Generic.EqualityComparer<global::G.FileSearchTool?>.Default.Equals(FileSearch, other.FileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionTool?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerTool?>.Default.Equals(Computer, other.Computer) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSearchTool?>.Default.Equals(WebSearch, other.WebSearch) 
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
