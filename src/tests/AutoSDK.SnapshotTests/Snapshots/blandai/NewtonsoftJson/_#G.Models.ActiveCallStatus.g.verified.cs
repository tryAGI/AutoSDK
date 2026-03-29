//HintName: G.Models.ActiveCallStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActiveCallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="IN_PROGRESS")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="QUEUED")]
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActiveCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActiveCallStatus value)
        {
            return value switch
            {
                ActiveCallStatus.InProgress => "IN_PROGRESS",
                ActiveCallStatus.Queued => "QUEUED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActiveCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "IN_PROGRESS" => ActiveCallStatus.InProgress,
                "QUEUED" => ActiveCallStatus.Queued,
                _ => null,
            };
        }
    }
}