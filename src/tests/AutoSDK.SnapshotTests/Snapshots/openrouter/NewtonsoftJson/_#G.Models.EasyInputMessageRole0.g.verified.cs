//HintName: G.Models.EasyInputMessageRole0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EasyInputMessageRole0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EasyInputMessageRole0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EasyInputMessageRole0 value)
        {
            return value switch
            {
                EasyInputMessageRole0.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EasyInputMessageRole0? ToEnum(string value)
        {
            return value switch
            {
                "user" => EasyInputMessageRole0.User,
                _ => null,
            };
        }
    }
}