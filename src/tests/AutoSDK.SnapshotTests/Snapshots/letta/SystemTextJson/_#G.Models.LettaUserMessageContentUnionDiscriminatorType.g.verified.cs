//HintName: G.Models.LettaUserMessageContentUnionDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LettaUserMessageContentUnionDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LettaUserMessageContentUnionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaUserMessageContentUnionDiscriminatorType value)
        {
            return value switch
            {
                LettaUserMessageContentUnionDiscriminatorType.Image => "image",
                LettaUserMessageContentUnionDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaUserMessageContentUnionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => LettaUserMessageContentUnionDiscriminatorType.Image,
                "text" => LettaUserMessageContentUnionDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}