//HintName: G.Models.RunStepStreamEventVariant3Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepStreamEventVariant3Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.step.delta")]
        ThreadRunStepDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepStreamEventVariant3EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepStreamEventVariant3Event value)
        {
            return value switch
            {
                RunStepStreamEventVariant3Event.ThreadRunStepDelta => "thread.run.step.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepStreamEventVariant3Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.delta" => RunStepStreamEventVariant3Event.ThreadRunStepDelta,
                _ => null,
            };
        }
    }
}