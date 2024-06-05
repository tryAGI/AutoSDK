//HintName: G.Models.CreateThreadAndRunRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `auto` is the default value
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateThreadAndRunRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateThreadAndRunRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateThreadAndRunRequestResponseFormat value)
        {
            return value switch
            {
                CreateThreadAndRunRequestResponseFormat.None => "none",
                CreateThreadAndRunRequestResponseFormat.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateThreadAndRunRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "none" => CreateThreadAndRunRequestResponseFormat.None,
                "auto" => CreateThreadAndRunRequestResponseFormat.Auto,
                _ => null,
            };
        }
    }
}