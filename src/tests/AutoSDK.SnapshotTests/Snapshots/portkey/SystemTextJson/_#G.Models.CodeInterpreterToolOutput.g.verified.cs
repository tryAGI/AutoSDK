//HintName: G.Models.CodeInterpreterToolOutput.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CodeInterpreterToolOutput : global::System.IEquatable<CodeInterpreterToolOutput>
    {
        /// <summary>
        /// The output of a code interpreter tool call that is text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodeInterpreterTextOutput? CodeInterpreterTextOutput { get; init; }
#else
        public global::G.CodeInterpreterTextOutput? CodeInterpreterTextOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterTextOutput))]
#endif
        public bool IsCodeInterpreterTextOutput => CodeInterpreterTextOutput != null;

        /// <summary>
        /// The output of a code interpreter tool call that is a file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodeInterpreterFileOutput? CodeInterpreterFileOutput { get; init; }
#else
        public global::G.CodeInterpreterFileOutput? CodeInterpreterFileOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterFileOutput))]
#endif
        public bool IsCodeInterpreterFileOutput => CodeInterpreterFileOutput != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeInterpreterToolOutput(global::G.CodeInterpreterTextOutput value) => new CodeInterpreterToolOutput((global::G.CodeInterpreterTextOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeInterpreterTextOutput?(CodeInterpreterToolOutput @this) => @this.CodeInterpreterTextOutput;

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterToolOutput(global::G.CodeInterpreterTextOutput? value)
        {
            CodeInterpreterTextOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeInterpreterToolOutput(global::G.CodeInterpreterFileOutput value) => new CodeInterpreterToolOutput((global::G.CodeInterpreterFileOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeInterpreterFileOutput?(CodeInterpreterToolOutput @this) => @this.CodeInterpreterFileOutput;

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterToolOutput(global::G.CodeInterpreterFileOutput? value)
        {
            CodeInterpreterFileOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterToolOutput(
            global::G.CodeInterpreterTextOutput? codeInterpreterTextOutput,
            global::G.CodeInterpreterFileOutput? codeInterpreterFileOutput
            )
        {
            CodeInterpreterTextOutput = codeInterpreterTextOutput;
            CodeInterpreterFileOutput = codeInterpreterFileOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CodeInterpreterFileOutput as object ??
            CodeInterpreterTextOutput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CodeInterpreterTextOutput?.ToString() ??
            CodeInterpreterFileOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCodeInterpreterTextOutput && !IsCodeInterpreterFileOutput || !IsCodeInterpreterTextOutput && IsCodeInterpreterFileOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CodeInterpreterTextOutput?, TResult>? codeInterpreterTextOutput = null,
            global::System.Func<global::G.CodeInterpreterFileOutput?, TResult>? codeInterpreterFileOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreterTextOutput && codeInterpreterTextOutput != null)
            {
                return codeInterpreterTextOutput(CodeInterpreterTextOutput!);
            }
            else if (IsCodeInterpreterFileOutput && codeInterpreterFileOutput != null)
            {
                return codeInterpreterFileOutput(CodeInterpreterFileOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CodeInterpreterTextOutput?>? codeInterpreterTextOutput = null,
            global::System.Action<global::G.CodeInterpreterFileOutput?>? codeInterpreterFileOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreterTextOutput)
            {
                codeInterpreterTextOutput?.Invoke(CodeInterpreterTextOutput!);
            }
            else if (IsCodeInterpreterFileOutput)
            {
                codeInterpreterFileOutput?.Invoke(CodeInterpreterFileOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CodeInterpreterTextOutput,
                typeof(global::G.CodeInterpreterTextOutput),
                CodeInterpreterFileOutput,
                typeof(global::G.CodeInterpreterFileOutput),
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
        public bool Equals(CodeInterpreterToolOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CodeInterpreterTextOutput?>.Default.Equals(CodeInterpreterTextOutput, other.CodeInterpreterTextOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeInterpreterFileOutput?>.Default.Equals(CodeInterpreterFileOutput, other.CodeInterpreterFileOutput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CodeInterpreterToolOutput obj1, CodeInterpreterToolOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CodeInterpreterToolOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CodeInterpreterToolOutput obj1, CodeInterpreterToolOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CodeInterpreterToolOutput o && Equals(o);
        }
    }
}
