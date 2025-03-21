//HintName: G.Models.RunStreamEventVariant4Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStreamEventVariant4Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.requires_action")]
        ThreadRunRequiresAction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStreamEventVariant4EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStreamEventVariant4Event value)
        {
            return value switch
            {
                RunStreamEventVariant4Event.ThreadRunRequiresAction => "thread.run.requires_action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStreamEventVariant4Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.requires_action" => RunStreamEventVariant4Event.ThreadRunRequiresAction,
                _ => null,
            };
        }
    }
}