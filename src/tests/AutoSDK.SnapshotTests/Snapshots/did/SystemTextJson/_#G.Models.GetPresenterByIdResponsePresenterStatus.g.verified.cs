//HintName: G.Models.GetPresenterByIdResponsePresenterStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the presenter
    /// </summary>
    public enum GetPresenterByIdResponsePresenterStatus
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
    public static class GetPresenterByIdResponsePresenterStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPresenterByIdResponsePresenterStatus value)
        {
            return value switch
            {
                GetPresenterByIdResponsePresenterStatus.Done => "done",
                GetPresenterByIdResponsePresenterStatus.Error => "error",
                GetPresenterByIdResponsePresenterStatus.Rejected => "rejected",
                GetPresenterByIdResponsePresenterStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPresenterByIdResponsePresenterStatus? ToEnum(string value)
        {
            return value switch
            {
                "done" => GetPresenterByIdResponsePresenterStatus.Done,
                "error" => GetPresenterByIdResponsePresenterStatus.Error,
                "rejected" => GetPresenterByIdResponsePresenterStatus.Rejected,
                "started" => GetPresenterByIdResponsePresenterStatus.Started,
                _ => null,
            };
        }
    }
}