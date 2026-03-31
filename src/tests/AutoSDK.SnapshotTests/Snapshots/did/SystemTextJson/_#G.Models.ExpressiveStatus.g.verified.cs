//HintName: G.Models.ExpressiveStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExpressiveStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
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
    public static class ExpressiveStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveStatus value)
        {
            return value switch
            {
                ExpressiveStatus.Created => "created",
                ExpressiveStatus.Done => "done",
                ExpressiveStatus.Error => "error",
                ExpressiveStatus.Rejected => "rejected",
                ExpressiveStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => ExpressiveStatus.Created,
                "done" => ExpressiveStatus.Done,
                "error" => ExpressiveStatus.Error,
                "rejected" => ExpressiveStatus.Rejected,
                "started" => ExpressiveStatus.Started,
                _ => null,
            };
        }
    }
}