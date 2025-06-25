//HintName: G.Models.DependabotUpdateAlertRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the Dependabot alert.<br/>
    /// A `dismissed_reason` must be provided when setting the state to `dismissed`.
    /// </summary>
    public enum DependabotUpdateAlertRequestState
    {
        /// <summary>
        /// 
        /// </summary>
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
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
        public static DependabotUpdateAlertRequestState? ToEnum(string value)
        {
            return value switch
            {
                "dismissed" => DependabotUpdateAlertRequestState.Dismissed,
                "open" => DependabotUpdateAlertRequestState.Open,
                _ => null,
            };
        }
    }
}