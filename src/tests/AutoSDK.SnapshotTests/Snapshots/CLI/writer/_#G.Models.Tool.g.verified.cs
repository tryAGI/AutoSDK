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
        /// 
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
#if NET6_0_OR_GREATER
        public global::G.GraphTool? Graph { get; init; }
#else
        public global::G.GraphTool? Graph { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Graph))]
#endif
        public bool IsGraph => Graph != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LlmTool? Llm { get; init; }
#else
        public global::G.LlmTool? Llm { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Llm))]
#endif
        public bool IsLlm => Llm != null;

        /// <summary>
        /// A tool that uses Palmyra Translate to translate text. Note that this tool does not stream results. The response is returned after the translation is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TranslationTool? Translation { get; init; }
#else
        public global::G.TranslationTool? Translation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Translation))]
#endif
        public bool IsTranslation => Translation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VisionTool? Vision { get; init; }
#else
        public global::G.VisionTool? Vision { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Vision))]
#endif
        public bool IsVision => Vision != null;

        /// <summary>
        /// 
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
        public static implicit operator Tool(global::G.GraphTool value) => new Tool((global::G.GraphTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphTool?(Tool @this) => @this.Graph;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.GraphTool? value)
        {
            Graph = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.LlmTool value) => new Tool((global::G.LlmTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LlmTool?(Tool @this) => @this.Llm;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.LlmTool? value)
        {
            Llm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.TranslationTool value) => new Tool((global::G.TranslationTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TranslationTool?(Tool @this) => @this.Translation;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.TranslationTool? value)
        {
            Translation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.VisionTool value) => new Tool((global::G.VisionTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VisionTool?(Tool @this) => @this.Vision;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.VisionTool? value)
        {
            Vision = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.WebSearchTool value) => new Tool((global::G.WebSearchTool?)value);

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
            global::G.ToolDiscriminatorType? type,
            global::G.FunctionTool? function,
            global::G.GraphTool? graph,
            global::G.LlmTool? llm,
            global::G.TranslationTool? translation,
            global::G.VisionTool? vision,
            global::G.WebSearchTool? webSearch
            )
        {
            Type = type;

            Function = function;
            Graph = graph;
            Llm = llm;
            Translation = translation;
            Vision = vision;
            WebSearch = webSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebSearch as object ??
            Vision as object ??
            Translation as object ??
            Llm as object ??
            Graph as object ??
            Function as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            Graph?.ToString() ??
            Llm?.ToString() ??
            Translation?.ToString() ??
            Vision?.ToString() ??
            WebSearch?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsGraph && !IsLlm && !IsTranslation && !IsVision && !IsWebSearch || !IsFunction && IsGraph && !IsLlm && !IsTranslation && !IsVision && !IsWebSearch || !IsFunction && !IsGraph && IsLlm && !IsTranslation && !IsVision && !IsWebSearch || !IsFunction && !IsGraph && !IsLlm && IsTranslation && !IsVision && !IsWebSearch || !IsFunction && !IsGraph && !IsLlm && !IsTranslation && IsVision && !IsWebSearch || !IsFunction && !IsGraph && !IsLlm && !IsTranslation && !IsVision && IsWebSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FunctionTool?, TResult>? function = null,
            global::System.Func<global::G.GraphTool?, TResult>? graph = null,
            global::System.Func<global::G.LlmTool?, TResult>? llm = null,
            global::System.Func<global::G.TranslationTool?, TResult>? translation = null,
            global::System.Func<global::G.VisionTool?, TResult>? vision = null,
            global::System.Func<global::G.WebSearchTool?, TResult>? webSearch = null,
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
            else if (IsGraph && graph != null)
            {
                return graph(Graph!);
            }
            else if (IsLlm && llm != null)
            {
                return llm(Llm!);
            }
            else if (IsTranslation && translation != null)
            {
                return translation(Translation!);
            }
            else if (IsVision && vision != null)
            {
                return vision(Vision!);
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
            global::System.Action<global::G.GraphTool?>? graph = null,
            global::System.Action<global::G.LlmTool?>? llm = null,
            global::System.Action<global::G.TranslationTool?>? translation = null,
            global::System.Action<global::G.VisionTool?>? vision = null,
            global::System.Action<global::G.WebSearchTool?>? webSearch = null,
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
            else if (IsGraph)
            {
                graph?.Invoke(Graph!);
            }
            else if (IsLlm)
            {
                llm?.Invoke(Llm!);
            }
            else if (IsTranslation)
            {
                translation?.Invoke(Translation!);
            }
            else if (IsVision)
            {
                vision?.Invoke(Vision!);
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
                Graph,
                typeof(global::G.GraphTool),
                Llm,
                typeof(global::G.LlmTool),
                Translation,
                typeof(global::G.TranslationTool),
                Vision,
                typeof(global::G.VisionTool),
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
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionTool?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GraphTool?>.Default.Equals(Graph, other.Graph) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LlmTool?>.Default.Equals(Llm, other.Llm) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TranslationTool?>.Default.Equals(Translation, other.Translation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VisionTool?>.Default.Equals(Vision, other.Vision) &&
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
