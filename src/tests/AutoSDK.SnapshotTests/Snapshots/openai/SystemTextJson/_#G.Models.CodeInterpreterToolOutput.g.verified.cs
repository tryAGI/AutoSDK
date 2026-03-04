//HintName: G.Models.CodeInterpreterToolOutput.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The output of a code interpreter tool.
    /// </summary>
    public readonly partial struct CodeInterpreterToolOutput : global::System.IEquatable<CodeInterpreterToolOutput>
    {
        /// <summary>
        /// The output of a code interpreter tool call that is text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodeInterpreterTextOutput? Logs { get; init; }
#else
        public global::G.CodeInterpreterTextOutput? Logs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Logs))]
#endif
        public bool IsLogs => Logs != null;

        /// <summary>
        /// The output of a code interpreter tool call that is a file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodeInterpreterFileOutput? Files { get; init; }
#else
        public global::G.CodeInterpreterFileOutput? Files { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Files))]
#endif
        public bool IsFiles => Files != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeInterpreterToolOutput(global::G.CodeInterpreterTextOutput value) => new CodeInterpreterToolOutput((global::G.CodeInterpreterTextOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeInterpreterTextOutput?(CodeInterpreterToolOutput @this) => @this.Logs;

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterToolOutput(global::G.CodeInterpreterTextOutput? value)
        {
            Logs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeInterpreterToolOutput(global::G.CodeInterpreterFileOutput value) => new CodeInterpreterToolOutput((global::G.CodeInterpreterFileOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeInterpreterFileOutput?(CodeInterpreterToolOutput @this) => @this.Files;

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterToolOutput(global::G.CodeInterpreterFileOutput? value)
        {
            Files = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterToolOutput(
            global::G.CodeInterpreterTextOutput? logs,
            global::G.CodeInterpreterFileOutput? files
            )
        {
            Logs = logs;
            Files = files;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Files as object ??
            Logs as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Logs?.ToString() ??
            Files?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLogs && !IsFiles || !IsLogs && IsFiles;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CodeInterpreterTextOutput?, TResult>? logs = null,
            global::System.Func<global::G.CodeInterpreterFileOutput?, TResult>? files = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLogs && logs != null)
            {
                return logs(Logs!);
            }
            else if (IsFiles && files != null)
            {
                return files(Files!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CodeInterpreterTextOutput?>? logs = null,
            global::System.Action<global::G.CodeInterpreterFileOutput?>? files = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLogs)
            {
                logs?.Invoke(Logs!);
            }
            else if (IsFiles)
            {
                files?.Invoke(Files!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Logs,
                typeof(global::G.CodeInterpreterTextOutput),
                Files,
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
                global::System.Collections.Generic.EqualityComparer<global::G.CodeInterpreterTextOutput?>.Default.Equals(Logs, other.Logs) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeInterpreterFileOutput?>.Default.Equals(Files, other.Files) 
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
