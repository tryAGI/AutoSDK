//HintName: G.Models.PageStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the most recent build of the Page.<br/>
    /// Example: built
    /// </summary>
    public enum PageStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Building,
        /// <summary>
        /// 
        /// </summary>
        Built,
        /// <summary>
        /// 
        /// </summary>
        Errored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PageStatus value)
        {
            return value switch
            {
                PageStatus.Building => "building",
                PageStatus.Built => "built",
                PageStatus.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PageStatus? ToEnum(string value)
        {
            return value switch
            {
                "building" => PageStatus.Building,
                "built" => PageStatus.Built,
                "errored" => PageStatus.Errored,
                _ => null,
            };
        }
    }
}