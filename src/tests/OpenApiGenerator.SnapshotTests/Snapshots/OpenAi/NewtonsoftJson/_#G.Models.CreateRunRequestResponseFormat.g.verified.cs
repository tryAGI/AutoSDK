//HintName: G.Models.CreateRunRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `auto` is the default value
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRunRequestResponseFormat
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

    public static class CreateRunRequestResponseFormatExtensions
    {
        public static string ToValueString(this CreateRunRequestResponseFormat value)
        {
            return value switch
            {
                CreateRunRequestResponseFormat.None => "none",
                CreateRunRequestResponseFormat.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateRunRequestResponseFormat ToEnum(string value)
        {
            return value switch
            {
                "none" => CreateRunRequestResponseFormat.None,
                "auto" => CreateRunRequestResponseFormat.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateRunRequestResponseFormat ToEnum(int value)
        {
            return value switch
            {
                0 => CreateRunRequestResponseFormat.None,
                1 => CreateRunRequestResponseFormat.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}