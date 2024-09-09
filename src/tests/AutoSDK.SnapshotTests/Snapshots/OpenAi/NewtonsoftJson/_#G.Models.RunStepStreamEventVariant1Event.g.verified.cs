//HintName: G.Models.RunStepStreamEventVariant1Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepStreamEventVariant1Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.step.created")]
        ThreadRunStepCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepStreamEventVariant1EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepStreamEventVariant1Event value)
        {
            return value switch
            {
                RunStepStreamEventVariant1Event.ThreadRunStepCreated => "thread.run.step.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepStreamEventVariant1Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.created" => RunStepStreamEventVariant1Event.ThreadRunStepCreated,
                _ => null,
            };
        }
    }
}