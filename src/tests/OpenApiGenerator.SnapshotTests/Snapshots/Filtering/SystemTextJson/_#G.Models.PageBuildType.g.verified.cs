//HintName: G.Models.PageBuildType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The process in which the Page will be built.<br/>
    /// Example: legacy
    /// </summary>
    public enum PageBuildType
    {
        /// <summary>
        /// 
        /// </summary>
        Legacy,
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PageBuildTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PageBuildType value)
        {
            return value switch
            {
                PageBuildType.Legacy => "legacy",
                PageBuildType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PageBuildType? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => PageBuildType.Legacy,
                "workflow" => PageBuildType.Workflow,
                _ => null,
            };
        }
    }
}