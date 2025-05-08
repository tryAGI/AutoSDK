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
        /// A tool that searches for relevant content from uploaded files. Learn more about the [file search tool](https://platform.openai.com/docs/guides/tools-file-search).
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
        /// Defines a function in your own code the model can choose to call. Learn more about [function calling](https://platform.openai.com/docs/guides/function-calling).
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
        /// This tool searches the web for relevant results to use in a response. Learn more about the [web search tool](https://platform.openai.com/docs/guides/tools-web-search).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebSearchPreviewTool? WebSearchPreview { get; init; }
#else
        public global::G.WebSearchPreviewTool? WebSearchPreview { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchPreview))]
#endif
        public bool IsWebSearchPreview => WebSearchPreview != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.WebSearchPreviewTool value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebSearchPreviewTool?(Tool @this) => @this.WebSearchPreview;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.WebSearchPreviewTool? value)
        {
            WebSearchPreview = value;
        }

        /// <summary>
        /// A tool that controls a virtual computer. Learn more about the [computer tool](https://platform.openai.com/docs/guides/tools-computer-use).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ComputerUsePreviewTool? ComputerUsePreview { get; init; }
#else
        public global::G.ComputerUsePreviewTool? ComputerUsePreview { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerUsePreview))]
#endif
        public bool IsComputerUsePreview => ComputerUsePreview != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.ComputerUsePreviewTool value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComputerUsePreviewTool?(Tool @this) => @this.ComputerUsePreview;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.ComputerUsePreviewTool? value)
        {
            ComputerUsePreview = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Tool(
            global::G.FileSearchTool? fileSearch,
            global::G.FunctionTool? function,
            global::G.WebSearchPreviewTool? webSearchPreview,
            global::G.ComputerUsePreviewTool? computerUsePreview
            )
        {
            FileSearch = fileSearch;
            Function = function;
            WebSearchPreview = webSearchPreview;
            ComputerUsePreview = computerUsePreview;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ComputerUsePreview as object ??
            WebSearchPreview as object ??
            Function as object ??
            FileSearch as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FileSearch?.ToString() ??
            Function?.ToString() ??
            WebSearchPreview?.ToString() ??
            ComputerUsePreview?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileSearch && !IsFunction && !IsWebSearchPreview && !IsComputerUsePreview || !IsFileSearch && IsFunction && !IsWebSearchPreview && !IsComputerUsePreview || !IsFileSearch && !IsFunction && IsWebSearchPreview && !IsComputerUsePreview || !IsFileSearch && !IsFunction && !IsWebSearchPreview && IsComputerUsePreview;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FileSearchTool?, TResult>? fileSearch = null,
            global::System.Func<global::G.FunctionTool?, TResult>? function = null,
            global::System.Func<global::G.WebSearchPreviewTool?, TResult>? webSearchPreview = null,
            global::System.Func<global::G.ComputerUsePreviewTool?, TResult>? computerUsePreview = null,
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
            else if (IsWebSearchPreview && webSearchPreview != null)
            {
                return webSearchPreview(WebSearchPreview!);
            }
            else if (IsComputerUsePreview && computerUsePreview != null)
            {
                return computerUsePreview(ComputerUsePreview!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.FileSearchTool?>? fileSearch = null,
            global::System.Action<global::G.FunctionTool?>? function = null,
            global::System.Action<global::G.WebSearchPreviewTool?>? webSearchPreview = null,
            global::System.Action<global::G.ComputerUsePreviewTool?>? computerUsePreview = null,
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
            else if (IsWebSearchPreview)
            {
                webSearchPreview?.Invoke(WebSearchPreview!);
            }
            else if (IsComputerUsePreview)
            {
                computerUsePreview?.Invoke(ComputerUsePreview!);
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
                WebSearchPreview,
                typeof(global::G.WebSearchPreviewTool),
                ComputerUsePreview,
                typeof(global::G.ComputerUsePreviewTool),
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
                global::System.Collections.Generic.EqualityComparer<global::G.WebSearchPreviewTool?>.Default.Equals(WebSearchPreview, other.WebSearchPreview) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerUsePreviewTool?>.Default.Equals(ComputerUsePreview, other.ComputerUsePreview) 
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
