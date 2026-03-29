//HintName: G.Models.LettaAssistantMessageContentUnionDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LettaAssistantMessageContentUnionDiscriminatorType
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
    public static class LettaAssistantMessageContentUnionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaAssistantMessageContentUnionDiscriminatorType value)
        {
            return value switch
            {
                LettaAssistantMessageContentUnionDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaAssistantMessageContentUnionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => LettaAssistantMessageContentUnionDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}