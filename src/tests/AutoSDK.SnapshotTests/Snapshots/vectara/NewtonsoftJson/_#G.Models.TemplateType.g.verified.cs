//HintName: G.Models.TemplateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The templating engine used for instructions.<br/>
    /// Default Value: velocity<br/>
    /// Example: velocity
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TemplateType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="velocity")]
        Velocity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateType value)
        {
            return value switch
            {
                TemplateType.Velocity => "velocity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateType? ToEnum(string value)
        {
            return value switch
            {
                "velocity" => TemplateType.Velocity,
                _ => null,
            };
        }
    }
}