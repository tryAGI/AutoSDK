//HintName: G.Models.ChatWebSearchServerToolParametersUserLocationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatWebSearchServerToolParametersUserLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="approximate")]
        Approximate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatWebSearchServerToolParametersUserLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatWebSearchServerToolParametersUserLocationType value)
        {
            return value switch
            {
                ChatWebSearchServerToolParametersUserLocationType.Approximate => "approximate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatWebSearchServerToolParametersUserLocationType? ToEnum(string value)
        {
            return value switch
            {
                "approximate" => ChatWebSearchServerToolParametersUserLocationType.Approximate,
                _ => null,
            };
        }
    }
}