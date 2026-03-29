//HintName: G.Models.GroupConditionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type discriminator for group condition<br/>
    /// Example: group
    /// </summary>
    public enum GroupConditionType
    {
        /// <summary>
        /// 
        /// </summary>
        Group,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroupConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupConditionType value)
        {
            return value switch
            {
                GroupConditionType.Group => "group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupConditionType? ToEnum(string value)
        {
            return value switch
            {
                "group" => GroupConditionType.Group,
                _ => null,
            };
        }
    }
}