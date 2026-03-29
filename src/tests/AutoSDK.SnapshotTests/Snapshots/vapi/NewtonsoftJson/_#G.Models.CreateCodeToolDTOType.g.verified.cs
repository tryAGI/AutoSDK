//HintName: G.Models.CreateCodeToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "code" for Code tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateCodeToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code")]
        Code,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCodeToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCodeToolDTOType value)
        {
            return value switch
            {
                CreateCodeToolDTOType.Code => "code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCodeToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "code" => CreateCodeToolDTOType.Code,
                _ => null,
            };
        }
    }
}