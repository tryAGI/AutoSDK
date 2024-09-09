//HintName: G.Models.ReposCreatePagesSiteRequestBuildType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The process in which the Page will be built. Possible values are `"legacy"` and `"workflow"`.
    /// </summary>
    public enum ReposCreatePagesSiteRequestBuildType
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
    public static class ReposCreatePagesSiteRequestBuildTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreatePagesSiteRequestBuildType value)
        {
            return value switch
            {
                ReposCreatePagesSiteRequestBuildType.Legacy => "legacy",
                ReposCreatePagesSiteRequestBuildType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreatePagesSiteRequestBuildType? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => ReposCreatePagesSiteRequestBuildType.Legacy,
                "workflow" => ReposCreatePagesSiteRequestBuildType.Workflow,
                _ => null,
            };
        }
    }
}