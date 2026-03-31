//HintName: G.Models.ClipPresenterDtoStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the presenter
    /// </summary>
    public enum ClipPresenterDtoStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipPresenterDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipPresenterDtoStatus value)
        {
            return value switch
            {
                ClipPresenterDtoStatus.Done => "done",
                ClipPresenterDtoStatus.Error => "error",
                ClipPresenterDtoStatus.Rejected => "rejected",
                ClipPresenterDtoStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipPresenterDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "done" => ClipPresenterDtoStatus.Done,
                "error" => ClipPresenterDtoStatus.Error,
                "rejected" => ClipPresenterDtoStatus.Rejected,
                "started" => ClipPresenterDtoStatus.Started,
                _ => null,
            };
        }
    }
}