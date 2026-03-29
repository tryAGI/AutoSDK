//HintName: G.Models.CreateSessionDTOStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the current status of the session. Can be either 'active' or 'completed'.
    /// </summary>
    public enum CreateSessionDTOStatus
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
    public static class CreateSessionDTOStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSessionDTOStatus value)
        {
            return value switch
            {
                CreateSessionDTOStatus.Active => "active",
                CreateSessionDTOStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSessionDTOStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => CreateSessionDTOStatus.Active,
                "completed" => CreateSessionDTOStatus.Completed,
                _ => null,
            };
        }
    }
}