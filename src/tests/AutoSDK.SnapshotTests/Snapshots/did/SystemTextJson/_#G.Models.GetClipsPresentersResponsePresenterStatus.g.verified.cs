//HintName: G.Models.GetClipsPresentersResponsePresenterStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the presenter
    /// </summary>
    public enum GetClipsPresentersResponsePresenterStatus
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
    public static class GetClipsPresentersResponsePresenterStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetClipsPresentersResponsePresenterStatus value)
        {
            return value switch
            {
                GetClipsPresentersResponsePresenterStatus.Done => "done",
                GetClipsPresentersResponsePresenterStatus.Error => "error",
                GetClipsPresentersResponsePresenterStatus.Rejected => "rejected",
                GetClipsPresentersResponsePresenterStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetClipsPresentersResponsePresenterStatus? ToEnum(string value)
        {
            return value switch
            {
                "done" => GetClipsPresentersResponsePresenterStatus.Done,
                "error" => GetClipsPresentersResponsePresenterStatus.Error,
                "rejected" => GetClipsPresentersResponsePresenterStatus.Rejected,
                "started" => GetClipsPresentersResponsePresenterStatus.Started,
                _ => null,
            };
        }
    }
}