//HintName: G.Models.LabelStreamTaskDistributionEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `auto_distribution` - Label Stream distributes tasks automatically to annotators<br/>
    /// * `assigned_only` - Label Stream shows tasks only to assigned users
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LabelStreamTaskDistributionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assigned_only")]
        AssignedOnly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto_distribution")]
        AutoDistribution,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LabelStreamTaskDistributionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LabelStreamTaskDistributionEnum value)
        {
            return value switch
            {
                LabelStreamTaskDistributionEnum.AssignedOnly => "assigned_only",
                LabelStreamTaskDistributionEnum.AutoDistribution => "auto_distribution",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LabelStreamTaskDistributionEnum? ToEnum(string value)
        {
            return value switch
            {
                "assigned_only" => LabelStreamTaskDistributionEnum.AssignedOnly,
                "auto_distribution" => LabelStreamTaskDistributionEnum.AutoDistribution,
                _ => null,
            };
        }
    }
}