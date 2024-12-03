//HintName: G.Models.Tool.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A tool the model may use.
    /// </summary>
    public readonly partial struct Tool : global::System.IEquatable<Tool>
    {
        /// <summary>
        /// A custom tool the model may use.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolCustom? Custom { get; init; }
#else
        public global::G.ToolCustom? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.ToolCustom value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolCustom?(Tool @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.ToolCustom? value)
        {
            Custom = value;
        }

        /// <summary>
        /// A tool that uses a mouse and keyboard to interact with a computer, and take screenshots.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolComputerUse? ComputerUse { get; init; }
#else
        public global::G.ToolComputerUse? ComputerUse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerUse))]
#endif
        public bool IsComputerUse => ComputerUse != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.ToolComputerUse value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolComputerUse?(Tool @this) => @this.ComputerUse;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.ToolComputerUse? value)
        {
            ComputerUse = value;
        }

        /// <summary>
        /// A tool for viewing, creating and editing files.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolTextEditor? TextEditor { get; init; }
#else
        public global::G.ToolTextEditor? TextEditor { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditor))]
#endif
        public bool IsTextEditor => TextEditor != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.ToolTextEditor value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolTextEditor?(Tool @this) => @this.TextEditor;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.ToolTextEditor? value)
        {
            TextEditor = value;
        }

        /// <summary>
        /// A tool for running commands in a bash shell.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolBash? Bash { get; init; }
#else
        public global::G.ToolBash? Bash { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bash))]
#endif
        public bool IsBash => Bash != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::G.ToolBash value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolBash?(Tool @this) => @this.Bash;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::G.ToolBash? value)
        {
            Bash = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Tool(
            global::G.ToolCustom? custom,
            global::G.ToolComputerUse? computerUse,
            global::G.ToolTextEditor? textEditor,
            global::G.ToolBash? bash
            )
        {
            Custom = custom;
            ComputerUse = computerUse;
            TextEditor = textEditor;
            Bash = bash;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Bash as object ??
            TextEditor as object ??
            ComputerUse as object ??
            Custom as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustom && !IsComputerUse && !IsTextEditor && !IsBash || !IsCustom && IsComputerUse && !IsTextEditor && !IsBash || !IsCustom && !IsComputerUse && IsTextEditor && !IsBash || !IsCustom && !IsComputerUse && !IsTextEditor && IsBash;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ToolCustom?, TResult>? custom = null,
            global::System.Func<global::G.ToolComputerUse?, TResult>? computerUse = null,
            global::System.Func<global::G.ToolTextEditor?, TResult>? textEditor = null,
            global::System.Func<global::G.ToolBash?, TResult>? bash = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }
            else if (IsComputerUse && computerUse != null)
            {
                return computerUse(ComputerUse!);
            }
            else if (IsTextEditor && textEditor != null)
            {
                return textEditor(TextEditor!);
            }
            else if (IsBash && bash != null)
            {
                return bash(Bash!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ToolCustom?>? custom = null,
            global::System.Action<global::G.ToolComputerUse?>? computerUse = null,
            global::System.Action<global::G.ToolTextEditor?>? textEditor = null,
            global::System.Action<global::G.ToolBash?>? bash = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsComputerUse)
            {
                computerUse?.Invoke(ComputerUse!);
            }
            else if (IsTextEditor)
            {
                textEditor?.Invoke(TextEditor!);
            }
            else if (IsBash)
            {
                bash?.Invoke(Bash!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Custom,
                typeof(global::G.ToolCustom),
                ComputerUse,
                typeof(global::G.ToolComputerUse),
                TextEditor,
                typeof(global::G.ToolTextEditor),
                Bash,
                typeof(global::G.ToolBash),
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
                global::System.Collections.Generic.EqualityComparer<global::G.ToolCustom?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolComputerUse?>.Default.Equals(ComputerUse, other.ComputerUse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolTextEditor?>.Default.Equals(TextEditor, other.TextEditor) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolBash?>.Default.Equals(Bash, other.Bash) 
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
