//HintName: G.Models.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput : global::System.IEquatable<RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType? Type { get; }

        /// <summary>
        /// Text output from the Code Interpreter tool call as part of a run step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? Logs { get; init; }
#else
        public global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? Logs { get; }
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
        public static implicit operator RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject value) => new RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject?(RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput @this) => @this.Logs;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? value)
        {
            Logs = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? Image { get; init; }
#else
        public global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? Image { get; }
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
        public static implicit operator RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject value) => new RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject?(RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput(global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput(
            global::G.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType? type,
            global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? logs,
            global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? image
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
            global::System.Func<global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject?, TResult>? logs = null,
            global::System.Func<global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject?, TResult>? image = null,
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
            global::System.Action<global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject?>? logs = null,
            global::System.Action<global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject?>? image = null,
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
                typeof(global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject),
                Image,
                typeof(global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject),
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
        public bool Equals(RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject?>.Default.Equals(Logs, other.Logs) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj1, RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj1, RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput o && Equals(o);
        }
    }
}
