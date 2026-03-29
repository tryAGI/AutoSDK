//HintName: G.Models.RunStreamEventVariant1Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStreamEventVariant1Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.run.created")]
        ThreadRunCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStreamEventVariant1EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStreamEventVariant1Event value)
        {
            return value switch
            {
                RunStreamEventVariant1Event.ThreadRunCreated => "thread.run.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStreamEventVariant1Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.created" => RunStreamEventVariant1Event.ThreadRunCreated,
                _ => null,
            };
        }
    }
}