//HintName: G.Models.CreateEventRequestEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEventRequestEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="playground-view")]
        PlaygroundView,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="playground-run")]
        PlaygroundRun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEventRequestEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEventRequestEventType value)
        {
            return value switch
            {
                CreateEventRequestEventType.PlaygroundView => "playground-view",
                CreateEventRequestEventType.PlaygroundRun => "playground-run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEventRequestEventType? ToEnum(string value)
        {
            return value switch
            {
                "playground-view" => CreateEventRequestEventType.PlaygroundView,
                "playground-run" => CreateEventRequestEventType.PlaygroundRun,
                _ => null,
            };
        }
    }
}