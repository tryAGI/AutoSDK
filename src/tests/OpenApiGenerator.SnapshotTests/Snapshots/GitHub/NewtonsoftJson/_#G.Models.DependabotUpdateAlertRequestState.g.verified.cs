//HintName: G.Models.DependabotUpdateAlertRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the Dependabot alert.
    /// A `dismissed_reason` must be provided when setting the state to `dismissed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependabotUpdateAlertRequestState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dismissed")]
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotUpdateAlertRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotUpdateAlertRequestState value)
        {
            return value switch
            {
                DependabotUpdateAlertRequestState.Dismissed => "dismissed",
                DependabotUpdateAlertRequestState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotUpdateAlertRequestState ToEnum(string value)
        {
            return value switch
            {
                "dismissed" => DependabotUpdateAlertRequestState.Dismissed,
                "open" => DependabotUpdateAlertRequestState.Open,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}