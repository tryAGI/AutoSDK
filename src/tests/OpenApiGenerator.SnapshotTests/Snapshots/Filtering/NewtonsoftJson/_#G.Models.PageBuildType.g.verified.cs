//HintName: G.Models.PageBuildType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The process in which the Page will be built.
    /// <br/>Example: legacy
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PageBuildType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="legacy")]
        Legacy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow")]
        Workflow,
    }

    public static class PageBuildTypeExtensions
    {
        public static string ToValueString(this PageBuildType value)
        {
            return value switch
            {
                PageBuildType.Legacy => "legacy",
                PageBuildType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static PageBuildType ToEnum(string value)
        {
            return value switch
            {
                "legacy" => PageBuildType.Legacy,
                "workflow" => PageBuildType.Workflow,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static PageBuildType ToEnum(int value)
        {
            return value switch
            {
                0 => PageBuildType.Legacy,
                1 => PageBuildType.Workflow,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}