//HintName: G.Models.ProjectSettingsSpanFieldOrderItemLayoutVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectSettingsSpanFieldOrderItemLayoutVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        TwoColumn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectSettingsSpanFieldOrderItemLayoutVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSettingsSpanFieldOrderItemLayoutVariant2 value)
        {
            return value switch
            {
                ProjectSettingsSpanFieldOrderItemLayoutVariant2.TwoColumn => "two_column",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSettingsSpanFieldOrderItemLayoutVariant2? ToEnum(string value)
        {
            return value switch
            {
                "two_column" => ProjectSettingsSpanFieldOrderItemLayoutVariant2.TwoColumn,
                _ => null,
            };
        }
    }
}