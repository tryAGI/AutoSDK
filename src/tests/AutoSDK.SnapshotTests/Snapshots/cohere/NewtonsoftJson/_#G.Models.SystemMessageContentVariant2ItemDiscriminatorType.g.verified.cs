//HintName: G.Models.SystemMessageContentVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SystemMessageContentVariant2ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemMessageContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemMessageContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                SystemMessageContentVariant2ItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemMessageContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => SystemMessageContentVariant2ItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}