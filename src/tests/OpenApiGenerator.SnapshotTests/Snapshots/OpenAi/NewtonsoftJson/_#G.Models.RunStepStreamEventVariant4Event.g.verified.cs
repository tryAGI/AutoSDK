//HintName: G.Models.RunStepStreamEventVariant4Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepStreamEventVariant4Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.step.completed")]
        ThreadRunStepCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepStreamEventVariant4EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepStreamEventVariant4Event value)
        {
            return value switch
            {
                RunStepStreamEventVariant4Event.ThreadRunStepCompleted => "thread.run.step.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepStreamEventVariant4Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.completed" => RunStepStreamEventVariant4Event.ThreadRunStepCompleted,
                _ => null,
            };
        }
    }
}