//HintName: G.Models.ToolsItem6.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolsItem6 : global::System.IEquatable<ToolsItem6>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.MessageObjectAttachmentToolDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantToolsCode? CodeInterpreter { get; init; }
#else
        public global::G.AssistantToolsCode? CodeInterpreter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreter))]
#endif
        public bool IsCodeInterpreter => CodeInterpreter != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem6(global::G.AssistantToolsCode value) => new ToolsItem6(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantToolsCode?(ToolsItem6 @this) => @this.CodeInterpreter;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem6(global::G.AssistantToolsCode? value)
        {
            CodeInterpreter = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantToolsFileSearchTypeOnly? FileSearch { get; init; }
#else
        public global::G.AssistantToolsFileSearchTypeOnly? FileSearch { get; }
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
        public static implicit operator ToolsItem6(global::G.AssistantToolsFileSearchTypeOnly value) => new ToolsItem6(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantToolsFileSearchTypeOnly?(ToolsItem6 @this) => @this.FileSearch;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem6(global::G.AssistantToolsFileSearchTypeOnly? value)
        {
            FileSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem6(
            global::G.MessageObjectAttachmentToolDiscriminatorType? type,
            global::G.AssistantToolsCode? codeInterpreter,
            global::G.AssistantToolsFileSearchTypeOnly? fileSearch
            )
        {
            Type = type;

            CodeInterpreter = codeInterpreter;
            FileSearch = fileSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FileSearch as object ??
            CodeInterpreter as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCodeInterpreter && !IsFileSearch || !IsCodeInterpreter && IsFileSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AssistantToolsCode?, TResult>? codeInterpreter = null,
            global::System.Func<global::G.AssistantToolsFileSearchTypeOnly?, TResult>? fileSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreter && codeInterpreter != null)
            {
                return codeInterpreter(CodeInterpreter!);
            }
            else if (IsFileSearch && fileSearch != null)
            {
                return fileSearch(FileSearch!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AssistantToolsCode?>? codeInterpreter = null,
            global::System.Action<global::G.AssistantToolsFileSearchTypeOnly?>? fileSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreter)
            {
                codeInterpreter?.Invoke(CodeInterpreter!);
            }
            else if (IsFileSearch)
            {
                fileSearch?.Invoke(FileSearch!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CodeInterpreter,
                typeof(global::G.AssistantToolsCode),
                FileSearch,
                typeof(global::G.AssistantToolsFileSearchTypeOnly),
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
        public bool Equals(ToolsItem6 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantToolsCode?>.Default.Equals(CodeInterpreter, other.CodeInterpreter) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantToolsFileSearchTypeOnly?>.Default.Equals(FileSearch, other.FileSearch) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem6 obj1, ToolsItem6 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem6>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem6 obj1, ToolsItem6 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem6 o && Equals(o);
        }
    }
}
