//HintName: G.Models.CreateToolTemplateDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: tool
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateToolTemplateDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateToolTemplateDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateToolTemplateDTOType value)
        {
            return value switch
            {
                CreateToolTemplateDTOType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateToolTemplateDTOType? ToEnum(string value)
        {
            return value switch
            {
                "tool" => CreateToolTemplateDTOType.Tool,
                _ => null,
            };
        }
    }
}