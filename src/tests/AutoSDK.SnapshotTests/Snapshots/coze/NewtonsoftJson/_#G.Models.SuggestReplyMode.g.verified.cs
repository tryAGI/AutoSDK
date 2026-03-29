//HintName: G.Models.SuggestReplyMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SuggestReplyMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="customized")]
        Customized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disable")]
        Disable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enable")]
        Enable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SuggestReplyModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SuggestReplyMode value)
        {
            return value switch
            {
                SuggestReplyMode.Customized => "customized",
                SuggestReplyMode.Disable => "disable",
                SuggestReplyMode.Enable => "enable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SuggestReplyMode? ToEnum(string value)
        {
            return value switch
            {
                "customized" => SuggestReplyMode.Customized,
                "disable" => SuggestReplyMode.Disable,
                "enable" => SuggestReplyMode.Enable,
                _ => null,
            };
        }
    }
}