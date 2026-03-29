//HintName: G.Models.CreateTextToVideoRequestMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generation mode.<br/>
    /// Default Value: std
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTextToVideoRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pro")]
        Pro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="std")]
        Std,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestMode value)
        {
            return value switch
            {
                CreateTextToVideoRequestMode.Pro => "pro",
                CreateTextToVideoRequestMode.Std => "std",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "pro" => CreateTextToVideoRequestMode.Pro,
                "std" => CreateTextToVideoRequestMode.Std,
                _ => null,
            };
        }
    }
}