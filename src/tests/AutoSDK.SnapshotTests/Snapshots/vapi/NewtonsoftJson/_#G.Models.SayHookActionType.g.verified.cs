//HintName: G.Models.SayHookActionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of action - must be "say"
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SayHookActionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="say")]
        Say,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SayHookActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SayHookActionType value)
        {
            return value switch
            {
                SayHookActionType.Say => "say",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SayHookActionType? ToEnum(string value)
        {
            return value switch
            {
                "say" => SayHookActionType.Say,
                _ => null,
            };
        }
    }
}