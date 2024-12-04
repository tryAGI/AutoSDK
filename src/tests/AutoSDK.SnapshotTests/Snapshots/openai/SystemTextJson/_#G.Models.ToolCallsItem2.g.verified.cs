//HintName: G.Models.ToolCallsItem2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolCallsItem2 : global::System.IEquatable<ToolCallsItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsObjectToolCallDiscriminatorType? Type { get; }

        /// <summary>
        /// Details of the Code Interpreter tool call the run step was involved in.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepDetailsToolCallsCodeObject? CodeInterpreter { get; init; }
#else
        public global::G.RunStepDetailsToolCallsCodeObject? CodeInterpreter { get; }
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
        public static implicit operator ToolCallsItem2(global::G.RunStepDetailsToolCallsCodeObject value) => new ToolCallsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepDetailsToolCallsCodeObject?(ToolCallsItem2 @this) => @this.CodeInterpreter;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem2(global::G.RunStepDetailsToolCallsCodeObject? value)
        {
            CodeInterpreter = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepDetailsToolCallsFileSearchObject? FileSearch { get; init; }
#else
        public global::G.RunStepDetailsToolCallsFileSearchObject? FileSearch { get; }
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
        public static implicit operator ToolCallsItem2(global::G.RunStepDetailsToolCallsFileSearchObject value) => new ToolCallsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepDetailsToolCallsFileSearchObject?(ToolCallsItem2 @this) => @this.FileSearch;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem2(global::G.RunStepDetailsToolCallsFileSearchObject? value)
        {
            FileSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepDetailsToolCallsFunctionObject? Function { get; init; }
#else
        public global::G.RunStepDetailsToolCallsFunctionObject? Function { get; }
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
        public static implicit operator ToolCallsItem2(global::G.RunStepDetailsToolCallsFunctionObject value) => new ToolCallsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepDetailsToolCallsFunctionObject?(ToolCallsItem2 @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem2(global::G.RunStepDetailsToolCallsFunctionObject? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem2(
            global::G.RunStepDetailsToolCallsObjectToolCallDiscriminatorType? type,
            global::G.RunStepDetailsToolCallsCodeObject? codeInterpreter,
            global::G.RunStepDetailsToolCallsFileSearchObject? fileSearch,
            global::G.RunStepDetailsToolCallsFunctionObject? function
            )
        {
            Type = type;

            CodeInterpreter = codeInterpreter;
            FileSearch = fileSearch;
            Function = function;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Function as object ??
            FileSearch as object ??
            CodeInterpreter as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCodeInterpreter && !IsFileSearch && !IsFunction || !IsCodeInterpreter && IsFileSearch && !IsFunction || !IsCodeInterpreter && !IsFileSearch && IsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RunStepDetailsToolCallsCodeObject?, TResult>? codeInterpreter = null,
            global::System.Func<global::G.RunStepDetailsToolCallsFileSearchObject?, TResult>? fileSearch = null,
            global::System.Func<global::G.RunStepDetailsToolCallsFunctionObject?, TResult>? function = null,
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
            else if (IsFunction && function != null)
            {
                return function(Function!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RunStepDetailsToolCallsCodeObject?>? codeInterpreter = null,
            global::System.Action<global::G.RunStepDetailsToolCallsFileSearchObject?>? fileSearch = null,
            global::System.Action<global::G.RunStepDetailsToolCallsFunctionObject?>? function = null,
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
            else if (IsFunction)
            {
                function?.Invoke(Function!);
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
                typeof(global::G.RunStepDetailsToolCallsCodeObject),
                FileSearch,
                typeof(global::G.RunStepDetailsToolCallsFileSearchObject),
                Function,
                typeof(global::G.RunStepDetailsToolCallsFunctionObject),
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
        public bool Equals(ToolCallsItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepDetailsToolCallsCodeObject?>.Default.Equals(CodeInterpreter, other.CodeInterpreter) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepDetailsToolCallsFileSearchObject?>.Default.Equals(FileSearch, other.FileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepDetailsToolCallsFunctionObject?>.Default.Equals(Function, other.Function) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolCallsItem2 obj1, ToolCallsItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolCallsItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolCallsItem2 obj1, ToolCallsItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolCallsItem2 o && Equals(o);
        }
    }
}
