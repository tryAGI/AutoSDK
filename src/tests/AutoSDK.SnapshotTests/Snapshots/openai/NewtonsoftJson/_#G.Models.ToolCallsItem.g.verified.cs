﻿//HintName: G.Models.ToolCallsItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolCallsItem : global::System.IEquatable<ToolCallsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType? Type { get; }

        /// <summary>
        /// Details of the Code Interpreter tool call the run step was involved in.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepDeltaStepDetailsToolCallsCodeObject? CodeInterpreter { get; init; }
#else
        public global::G.RunStepDeltaStepDetailsToolCallsCodeObject? CodeInterpreter { get; }
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
        public static implicit operator ToolCallsItem(global::G.RunStepDeltaStepDetailsToolCallsCodeObject value) => new ToolCallsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepDeltaStepDetailsToolCallsCodeObject?(ToolCallsItem @this) => @this.CodeInterpreter;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem(global::G.RunStepDeltaStepDetailsToolCallsCodeObject? value)
        {
            CodeInterpreter = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject? FileSearch { get; init; }
#else
        public global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject? FileSearch { get; }
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
        public static implicit operator ToolCallsItem(global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject value) => new ToolCallsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject?(ToolCallsItem @this) => @this.FileSearch;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem(global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject? value)
        {
            FileSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepDeltaStepDetailsToolCallsFunctionObject? Function { get; init; }
#else
        public global::G.RunStepDeltaStepDetailsToolCallsFunctionObject? Function { get; }
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
        public static implicit operator ToolCallsItem(global::G.RunStepDeltaStepDetailsToolCallsFunctionObject value) => new ToolCallsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepDeltaStepDetailsToolCallsFunctionObject?(ToolCallsItem @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem(global::G.RunStepDeltaStepDetailsToolCallsFunctionObject? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolCallsItem(
            global::G.RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType? type,
            global::G.RunStepDeltaStepDetailsToolCallsCodeObject? codeInterpreter,
            global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject? fileSearch,
            global::G.RunStepDeltaStepDetailsToolCallsFunctionObject? function
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
            global::System.Func<global::G.RunStepDeltaStepDetailsToolCallsCodeObject?, TResult>? codeInterpreter = null,
            global::System.Func<global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject?, TResult>? fileSearch = null,
            global::System.Func<global::G.RunStepDeltaStepDetailsToolCallsFunctionObject?, TResult>? function = null,
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
            global::System.Action<global::G.RunStepDeltaStepDetailsToolCallsCodeObject?>? codeInterpreter = null,
            global::System.Action<global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject?>? fileSearch = null,
            global::System.Action<global::G.RunStepDeltaStepDetailsToolCallsFunctionObject?>? function = null,
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
                typeof(global::G.RunStepDeltaStepDetailsToolCallsCodeObject),
                FileSearch,
                typeof(global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject),
                Function,
                typeof(global::G.RunStepDeltaStepDetailsToolCallsFunctionObject),
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
        public bool Equals(ToolCallsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepDeltaStepDetailsToolCallsCodeObject?>.Default.Equals(CodeInterpreter, other.CodeInterpreter) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject?>.Default.Equals(FileSearch, other.FileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepDeltaStepDetailsToolCallsFunctionObject?>.Default.Equals(Function, other.Function) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolCallsItem obj1, ToolCallsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolCallsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolCallsItem obj1, ToolCallsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolCallsItem o && Equals(o);
        }
    }
}
