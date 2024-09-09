//HintName: G.Models.RunStepStreamEventVariant5Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepStreamEventVariant5Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.step.failed")]
        ThreadRunStepFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepStreamEventVariant5EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepStreamEventVariant5Event value)
        {
            return value switch
            {
                RunStepStreamEventVariant5Event.ThreadRunStepFailed => "thread.run.step.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepStreamEventVariant5Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.failed" => RunStepStreamEventVariant5Event.ThreadRunStepFailed,
                _ => null,
            };
        }
    }
}