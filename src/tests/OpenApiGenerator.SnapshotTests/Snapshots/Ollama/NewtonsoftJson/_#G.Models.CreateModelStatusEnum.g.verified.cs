//HintName: G.Models.CreateModelStatusEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModelStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="creating system layer")]
        CreatingSystemLayer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parsing modelfile")]
        ParsingModelfile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelStatusEnum value)
        {
            return value switch
            {
                CreateModelStatusEnum.CreatingSystemLayer => "creating system layer",
                CreateModelStatusEnum.ParsingModelfile => "parsing modelfile",
                CreateModelStatusEnum.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "creating system layer" => CreateModelStatusEnum.CreatingSystemLayer,
                "parsing modelfile" => CreateModelStatusEnum.ParsingModelfile,
                "success" => CreateModelStatusEnum.Success,
                _ => null,
            };
        }
    }
}