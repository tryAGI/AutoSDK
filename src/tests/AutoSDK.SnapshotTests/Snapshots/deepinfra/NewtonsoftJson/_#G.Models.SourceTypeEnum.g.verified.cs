//HintName: G.Models.SourceTypeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SourceTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="civitai")]
        Civitai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SourceTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SourceTypeEnum value)
        {
            return value switch
            {
                SourceTypeEnum.Civitai => "civitai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SourceTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "civitai" => SourceTypeEnum.Civitai,
                _ => null,
            };
        }
    }
}