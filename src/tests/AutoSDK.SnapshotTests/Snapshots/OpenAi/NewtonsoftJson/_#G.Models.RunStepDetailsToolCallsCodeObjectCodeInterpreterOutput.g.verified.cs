//HintName: G.Models.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput : global::System.IEquatable<RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType? Type { get; }

        /// <summary>
        /// Text output from the Code Interpreter tool call as part of a run step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepDetailsToolCallsCodeOutputLogsObject? Logs { get; init; }
#else
        public global::G.RunStepDetailsToolCallsCodeOutputLogsObject? Logs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Logs))]
#endif
        public bool IsLogs => Logs != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::G.RunStepDetailsToolCallsCodeOutputLogsObject value) => new RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepDetailsToolCallsCodeOutputLogsObject?(RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput @this) => @this.Logs;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::G.RunStepDetailsToolCallsCodeOutputLogsObject? value)
        {
            Logs = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepDetailsToolCallsCodeOutputImageObject? Image { get; init; }
#else
        public global::G.RunStepDetailsToolCallsCodeOutputImageObject? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::G.RunStepDetailsToolCallsCodeOutputImageObject value) => new RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepDetailsToolCallsCodeOutputImageObject?(RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::G.RunStepDetailsToolCallsCodeOutputImageObject? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(
            global::G.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType? type,
            global::G.RunStepDetailsToolCallsCodeOutputLogsObject? logs,
            global::G.RunStepDetailsToolCallsCodeOutputImageObject? image
            )
        {
            Type = type;

            Logs = logs;
            Image = image;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Image as object ??
            Logs as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLogs && !IsImage || !IsLogs && IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RunStepDetailsToolCallsCodeOutputLogsObject?, TResult>? logs = null,
            global::System.Func<global::G.RunStepDetailsToolCallsCodeOutputImageObject?, TResult>? image = null,
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
            else if (IsImage && image != null)
            {
                return image(Image!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RunStepDetailsToolCallsCodeOutputLogsObject?>? logs = null,
            global::System.Action<global::G.RunStepDetailsToolCallsCodeOutputImageObject?>? image = null,
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
            else if (IsImage)
            {
                image?.Invoke(Image!);
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
                typeof(global::G.RunStepDetailsToolCallsCodeOutputLogsObject),
                Image,
                typeof(global::G.RunStepDetailsToolCallsCodeOutputImageObject),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepDetailsToolCallsCodeOutputLogsObject?>.Default.Equals(Logs, other.Logs) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepDetailsToolCallsCodeOutputImageObject?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj1, RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj1, RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput o && Equals(o);
        }
    }
}
