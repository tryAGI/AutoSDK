//HintName: G.Models.UpdateSessionDTOStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the new status for the session.
    /// </summary>
    public enum UpdateSessionDTOStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSessionDTOStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSessionDTOStatus value)
        {
            return value switch
            {
                UpdateSessionDTOStatus.Active => "active",
                UpdateSessionDTOStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSessionDTOStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => UpdateSessionDTOStatus.Active,
                "completed" => UpdateSessionDTOStatus.Completed,
                _ => null,
            };
        }
    }
}