//HintName: G.Models.ProjectSettingsSpanFieldOrderItemLayoutVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectSettingsSpanFieldOrderItemLayoutVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="full")]
        Full,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectSettingsSpanFieldOrderItemLayoutVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSettingsSpanFieldOrderItemLayoutVariant1 value)
        {
            return value switch
            {
                ProjectSettingsSpanFieldOrderItemLayoutVariant1.Full => "full",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSettingsSpanFieldOrderItemLayoutVariant1? ToEnum(string value)
        {
            return value switch
            {
                "full" => ProjectSettingsSpanFieldOrderItemLayoutVariant1.Full,
                _ => null,
            };
        }
    }
}