//HintName: G.Models.FunctionId.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The function to evaluate
    /// </summary>
    public readonly partial struct FunctionId : global::System.IEquatable<FunctionId>
    {
        /// <summary>
        /// Function id
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionIdFunctionId1? Id1 { get; init; }
#else
        public global::G.FunctionIdFunctionId1? Id1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Id1))]
#endif
        public bool IsId1 => Id1 != null;

        /// <summary>
        /// Project name and slug
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionIdProjectSlug? ProjectSlug { get; init; }
#else
        public global::G.FunctionIdProjectSlug? ProjectSlug { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProjectSlug))]
#endif
        public bool IsProjectSlug => ProjectSlug != null;

        /// <summary>
        /// Global function name
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionIdGlobalFunction? GlobalFunction { get; init; }
#else
        public global::G.FunctionIdGlobalFunction? GlobalFunction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GlobalFunction))]
#endif
        public bool IsGlobalFunction => GlobalFunction != null;

        /// <summary>
        /// Prompt session id
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionIdPromptSessionId? PromptSessionId { get; init; }
#else
        public global::G.FunctionIdPromptSessionId? PromptSessionId { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PromptSessionId))]
#endif
        public bool IsPromptSessionId => PromptSessionId != null;

        /// <summary>
        /// Inline code function
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionIdInlineCode? InlineCode { get; init; }
#else
        public global::G.FunctionIdInlineCode? InlineCode { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineCode))]
#endif
        public bool IsInlineCode => InlineCode != null;

        /// <summary>
        /// Inline function definition
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionIdInlineFunction? InlineFunction { get; init; }
#else
        public global::G.FunctionIdInlineFunction? InlineFunction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineFunction))]
#endif
        public bool IsInlineFunction => InlineFunction != null;

        /// <summary>
        /// Inline prompt definition
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FunctionIdInlinePrompt? InlinePrompt { get; init; }
#else
        public global::G.FunctionIdInlinePrompt? InlinePrompt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlinePrompt))]
#endif
        public bool IsInlinePrompt => InlinePrompt != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionId(global::G.FunctionIdFunctionId1 value) => new FunctionId((global::G.FunctionIdFunctionId1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionIdFunctionId1?(FunctionId @this) => @this.Id1;

        /// <summary>
        /// 
        /// </summary>
        public FunctionId(global::G.FunctionIdFunctionId1? value)
        {
            Id1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionId(global::G.FunctionIdProjectSlug value) => new FunctionId((global::G.FunctionIdProjectSlug?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionIdProjectSlug?(FunctionId @this) => @this.ProjectSlug;

        /// <summary>
        /// 
        /// </summary>
        public FunctionId(global::G.FunctionIdProjectSlug? value)
        {
            ProjectSlug = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionId(global::G.FunctionIdGlobalFunction value) => new FunctionId((global::G.FunctionIdGlobalFunction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionIdGlobalFunction?(FunctionId @this) => @this.GlobalFunction;

        /// <summary>
        /// 
        /// </summary>
        public FunctionId(global::G.FunctionIdGlobalFunction? value)
        {
            GlobalFunction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionId(global::G.FunctionIdPromptSessionId value) => new FunctionId((global::G.FunctionIdPromptSessionId?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionIdPromptSessionId?(FunctionId @this) => @this.PromptSessionId;

        /// <summary>
        /// 
        /// </summary>
        public FunctionId(global::G.FunctionIdPromptSessionId? value)
        {
            PromptSessionId = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionId(global::G.FunctionIdInlineCode value) => new FunctionId((global::G.FunctionIdInlineCode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionIdInlineCode?(FunctionId @this) => @this.InlineCode;

        /// <summary>
        /// 
        /// </summary>
        public FunctionId(global::G.FunctionIdInlineCode? value)
        {
            InlineCode = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionId(global::G.FunctionIdInlineFunction value) => new FunctionId((global::G.FunctionIdInlineFunction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionIdInlineFunction?(FunctionId @this) => @this.InlineFunction;

        /// <summary>
        /// 
        /// </summary>
        public FunctionId(global::G.FunctionIdInlineFunction? value)
        {
            InlineFunction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionId(global::G.FunctionIdInlinePrompt value) => new FunctionId((global::G.FunctionIdInlinePrompt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FunctionIdInlinePrompt?(FunctionId @this) => @this.InlinePrompt;

        /// <summary>
        /// 
        /// </summary>
        public FunctionId(global::G.FunctionIdInlinePrompt? value)
        {
            InlinePrompt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FunctionId(
            global::G.FunctionIdFunctionId1? id1,
            global::G.FunctionIdProjectSlug? projectSlug,
            global::G.FunctionIdGlobalFunction? globalFunction,
            global::G.FunctionIdPromptSessionId? promptSessionId,
            global::G.FunctionIdInlineCode? inlineCode,
            global::G.FunctionIdInlineFunction? inlineFunction,
            global::G.FunctionIdInlinePrompt? inlinePrompt
            )
        {
            Id1 = id1;
            ProjectSlug = projectSlug;
            GlobalFunction = globalFunction;
            PromptSessionId = promptSessionId;
            InlineCode = inlineCode;
            InlineFunction = inlineFunction;
            InlinePrompt = inlinePrompt;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InlinePrompt as object ??
            InlineFunction as object ??
            InlineCode as object ??
            PromptSessionId as object ??
            GlobalFunction as object ??
            ProjectSlug as object ??
            Id1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Id1?.ToString() ??
            ProjectSlug?.ToString() ??
            GlobalFunction?.ToString() ??
            PromptSessionId?.ToString() ??
            InlineCode?.ToString() ??
            InlineFunction?.ToString() ??
            InlinePrompt?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsId1 || IsProjectSlug || IsGlobalFunction || IsPromptSessionId || IsInlineCode || IsInlineFunction || IsInlinePrompt;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FunctionIdFunctionId1?, TResult>? id1 = null,
            global::System.Func<global::G.FunctionIdProjectSlug?, TResult>? projectSlug = null,
            global::System.Func<global::G.FunctionIdGlobalFunction?, TResult>? globalFunction = null,
            global::System.Func<global::G.FunctionIdPromptSessionId?, TResult>? promptSessionId = null,
            global::System.Func<global::G.FunctionIdInlineCode?, TResult>? inlineCode = null,
            global::System.Func<global::G.FunctionIdInlineFunction?, TResult>? inlineFunction = null,
            global::System.Func<global::G.FunctionIdInlinePrompt?, TResult>? inlinePrompt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsId1 && id1 != null)
            {
                return id1(Id1!);
            }
            else if (IsProjectSlug && projectSlug != null)
            {
                return projectSlug(ProjectSlug!);
            }
            else if (IsGlobalFunction && globalFunction != null)
            {
                return globalFunction(GlobalFunction!);
            }
            else if (IsPromptSessionId && promptSessionId != null)
            {
                return promptSessionId(PromptSessionId!);
            }
            else if (IsInlineCode && inlineCode != null)
            {
                return inlineCode(InlineCode!);
            }
            else if (IsInlineFunction && inlineFunction != null)
            {
                return inlineFunction(InlineFunction!);
            }
            else if (IsInlinePrompt && inlinePrompt != null)
            {
                return inlinePrompt(InlinePrompt!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.FunctionIdFunctionId1?>? id1 = null,
            global::System.Action<global::G.FunctionIdProjectSlug?>? projectSlug = null,
            global::System.Action<global::G.FunctionIdGlobalFunction?>? globalFunction = null,
            global::System.Action<global::G.FunctionIdPromptSessionId?>? promptSessionId = null,
            global::System.Action<global::G.FunctionIdInlineCode?>? inlineCode = null,
            global::System.Action<global::G.FunctionIdInlineFunction?>? inlineFunction = null,
            global::System.Action<global::G.FunctionIdInlinePrompt?>? inlinePrompt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsId1)
            {
                id1?.Invoke(Id1!);
            }
            else if (IsProjectSlug)
            {
                projectSlug?.Invoke(ProjectSlug!);
            }
            else if (IsGlobalFunction)
            {
                globalFunction?.Invoke(GlobalFunction!);
            }
            else if (IsPromptSessionId)
            {
                promptSessionId?.Invoke(PromptSessionId!);
            }
            else if (IsInlineCode)
            {
                inlineCode?.Invoke(InlineCode!);
            }
            else if (IsInlineFunction)
            {
                inlineFunction?.Invoke(InlineFunction!);
            }
            else if (IsInlinePrompt)
            {
                inlinePrompt?.Invoke(InlinePrompt!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Id1,
                typeof(global::G.FunctionIdFunctionId1),
                ProjectSlug,
                typeof(global::G.FunctionIdProjectSlug),
                GlobalFunction,
                typeof(global::G.FunctionIdGlobalFunction),
                PromptSessionId,
                typeof(global::G.FunctionIdPromptSessionId),
                InlineCode,
                typeof(global::G.FunctionIdInlineCode),
                InlineFunction,
                typeof(global::G.FunctionIdInlineFunction),
                InlinePrompt,
                typeof(global::G.FunctionIdInlinePrompt),
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
        public bool Equals(FunctionId other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionIdFunctionId1?>.Default.Equals(Id1, other.Id1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionIdProjectSlug?>.Default.Equals(ProjectSlug, other.ProjectSlug) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionIdGlobalFunction?>.Default.Equals(GlobalFunction, other.GlobalFunction) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionIdPromptSessionId?>.Default.Equals(PromptSessionId, other.PromptSessionId) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionIdInlineCode?>.Default.Equals(InlineCode, other.InlineCode) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionIdInlineFunction?>.Default.Equals(InlineFunction, other.InlineFunction) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FunctionIdInlinePrompt?>.Default.Equals(InlinePrompt, other.InlinePrompt) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FunctionId obj1, FunctionId obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionId>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FunctionId obj1, FunctionId obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionId o && Equals(o);
        }
    }
}
