//HintName: G.Models.Tool.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that can be used to generate a response.
    /// </summary>
    public readonly partial struct Tool : global::System.IEquatable<Tool>
    {
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
        /// Give the model access to additional tools via remote Model Context Protocol <br/>
        /// (MCP) servers. [Learn more about MCP](/docs/guides/tools-remote-mcp).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MCPTool? MCP { get; init; }
#else
        public global::G.MCPTool? MCP { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCP))]
#endif
        public bool IsMCP => MCP != null;

        /// <summary>
        /// A tool that runs Python code to help generate a response to a prompt.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodeInterpreterTool? CodeInterpreter { get; init; }
#else
        public global::G.CodeInterpreterTool? CodeInterpreter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreter))]
#endif
        public bool IsCodeInterpreter => CodeInterpreter != null;

        /// <summary>
        /// A tool that generates images using a model like `gpt-image-1`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageGenTool? ImageGen { get; init; }
#else
        public global::G.ImageGenTool? ImageGen { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGen))]
#endif
        public bool IsImageGen => ImageGen != null;

        /// <summary>
        /// A tool that allows the model to execute shell commands in a local environment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LocalShellTool? LocalShell { get; init; }
#else
        public global::G.LocalShellTool? LocalShell { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalShell))]
#endif
        public bool IsLocalShell => LocalShell != null;
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
        public static implicit operator Tool(global::G.FileSearchTool value) => new Tool((global::G.FileSearchTool?)value);

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
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.WebSearchPreviewTool value) => new Tool((global::G.WebSearchPreviewTool?)value);

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
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.ComputerUsePreviewTool value) => new Tool((global::G.ComputerUsePreviewTool?)value);

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
        public static implicit operator Tool(global::G.MCPTool value) => new Tool((global::G.MCPTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPTool?(Tool @this) => @this.MCP;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.MCPTool? value)
        {
            MCP = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.CodeInterpreterTool value) => new Tool((global::G.CodeInterpreterTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeInterpreterTool?(Tool @this) => @this.CodeInterpreter;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.CodeInterpreterTool? value)
        {
            CodeInterpreter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.ImageGenTool value) => new Tool((global::G.ImageGenTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageGenTool?(Tool @this) => @this.ImageGen;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.ImageGenTool? value)
        {
            ImageGen = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.LocalShellTool value) => new Tool((global::G.LocalShellTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LocalShellTool?(Tool @this) => @this.LocalShell;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.LocalShellTool? value)
        {
            LocalShell = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Tool(
            global::G.FunctionTool? function,
            global::G.FileSearchTool? fileSearch,
            global::G.WebSearchPreviewTool? webSearchPreview,
            global::G.ComputerUsePreviewTool? computerUsePreview,
            global::G.MCPTool? mCP,
            global::G.CodeInterpreterTool? codeInterpreter,
            global::G.ImageGenTool? imageGen,
            global::G.LocalShellTool? localShell
            )
        {
            Function = function;
            FileSearch = fileSearch;
            WebSearchPreview = webSearchPreview;
            ComputerUsePreview = computerUsePreview;
            MCP = mCP;
            CodeInterpreter = codeInterpreter;
            ImageGen = imageGen;
            LocalShell = localShell;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LocalShell as object ??
            ImageGen as object ??
            CodeInterpreter as object ??
            MCP as object ??
            ComputerUsePreview as object ??
            WebSearchPreview as object ??
            FileSearch as object ??
            Function as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            FileSearch?.ToString() ??
            WebSearchPreview?.ToString() ??
            ComputerUsePreview?.ToString() ??
            MCP?.ToString() ??
            CodeInterpreter?.ToString() ??
            ImageGen?.ToString() ??
            LocalShell?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsFileSearch && !IsWebSearchPreview && !IsComputerUsePreview && !IsMCP && !IsCodeInterpreter && !IsImageGen && !IsLocalShell || !IsFunction && IsFileSearch && !IsWebSearchPreview && !IsComputerUsePreview && !IsMCP && !IsCodeInterpreter && !IsImageGen && !IsLocalShell || !IsFunction && !IsFileSearch && IsWebSearchPreview && !IsComputerUsePreview && !IsMCP && !IsCodeInterpreter && !IsImageGen && !IsLocalShell || !IsFunction && !IsFileSearch && !IsWebSearchPreview && IsComputerUsePreview && !IsMCP && !IsCodeInterpreter && !IsImageGen && !IsLocalShell || !IsFunction && !IsFileSearch && !IsWebSearchPreview && !IsComputerUsePreview && IsMCP && !IsCodeInterpreter && !IsImageGen && !IsLocalShell || !IsFunction && !IsFileSearch && !IsWebSearchPreview && !IsComputerUsePreview && !IsMCP && IsCodeInterpreter && !IsImageGen && !IsLocalShell || !IsFunction && !IsFileSearch && !IsWebSearchPreview && !IsComputerUsePreview && !IsMCP && !IsCodeInterpreter && IsImageGen && !IsLocalShell || !IsFunction && !IsFileSearch && !IsWebSearchPreview && !IsComputerUsePreview && !IsMCP && !IsCodeInterpreter && !IsImageGen && IsLocalShell;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FunctionTool?, TResult>? function = null,
            global::System.Func<global::G.FileSearchTool?, TResult>? fileSearch = null,
            global::System.Func<global::G.WebSearchPreviewTool?, TResult>? webSearchPreview = null,
            global::System.Func<global::G.ComputerUsePreviewTool?, TResult>? computerUsePreview = null,
            global::System.Func<global::G.MCPTool?, TResult>? mCP = null,
            global::System.Func<global::G.CodeInterpreterTool?, TResult>? codeInterpreter = null,
            global::System.Func<global::G.ImageGenTool?, TResult>? imageGen = null,
            global::System.Func<global::G.LocalShellTool?, TResult>? localShell = null,
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
            else if (IsFileSearch && fileSearch != null)
            {
                return fileSearch(FileSearch!);
            }
            else if (IsWebSearchPreview && webSearchPreview != null)
            {
                return webSearchPreview(WebSearchPreview!);
            }
            else if (IsComputerUsePreview && computerUsePreview != null)
            {
                return computerUsePreview(ComputerUsePreview!);
            }
            else if (IsMCP && mCP != null)
            {
                return mCP(MCP!);
            }
            else if (IsCodeInterpreter && codeInterpreter != null)
            {
                return codeInterpreter(CodeInterpreter!);
            }
            else if (IsImageGen && imageGen != null)
            {
                return imageGen(ImageGen!);
            }
            else if (IsLocalShell && localShell != null)
            {
                return localShell(LocalShell!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.FunctionTool?>? function = null,
            global::System.Action<global::G.FileSearchTool?>? fileSearch = null,
            global::System.Action<global::G.WebSearchPreviewTool?>? webSearchPreview = null,
            global::System.Action<global::G.ComputerUsePreviewTool?>? computerUsePreview = null,
            global::System.Action<global::G.MCPTool?>? mCP = null,
            global::System.Action<global::G.CodeInterpreterTool?>? codeInterpreter = null,
            global::System.Action<global::G.ImageGenTool?>? imageGen = null,
            global::System.Action<global::G.LocalShellTool?>? localShell = null,
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
            else if (IsFileSearch)
            {
                fileSearch?.Invoke(FileSearch!);
            }
            else if (IsWebSearchPreview)
            {
                webSearchPreview?.Invoke(WebSearchPreview!);
            }
            else if (IsComputerUsePreview)
            {
                computerUsePreview?.Invoke(ComputerUsePreview!);
            }
            else if (IsMCP)
            {
                mCP?.Invoke(MCP!);
            }
            else if (IsCodeInterpreter)
            {
                codeInterpreter?.Invoke(CodeInterpreter!);
            }
            else if (IsImageGen)
            {
                imageGen?.Invoke(ImageGen!);
            }
            else if (IsLocalShell)
            {
                localShell?.Invoke(LocalShell!);
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
                FileSearch,
                typeof(global::G.FileSearchTool),
                WebSearchPreview,
                typeof(global::G.WebSearchPreviewTool),
                ComputerUsePreview,
                typeof(global::G.ComputerUsePreviewTool),
                MCP,
                typeof(global::G.MCPTool),
                CodeInterpreter,
                typeof(global::G.CodeInterpreterTool),
                ImageGen,
                typeof(global::G.ImageGenTool),
                LocalShell,
                typeof(global::G.LocalShellTool),
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
                global::System.Collections.Generic.EqualityComparer<global::G.FileSearchTool?>.Default.Equals(FileSearch, other.FileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WebSearchPreviewTool?>.Default.Equals(WebSearchPreview, other.WebSearchPreview) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ComputerUsePreviewTool?>.Default.Equals(ComputerUsePreview, other.ComputerUsePreview) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPTool?>.Default.Equals(MCP, other.MCP) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeInterpreterTool?>.Default.Equals(CodeInterpreter, other.CodeInterpreter) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageGenTool?>.Default.Equals(ImageGen, other.ImageGen) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LocalShellTool?>.Default.Equals(LocalShell, other.LocalShell) 
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
