//HintName: G.Models.PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 参数类型，来源于OpenAPIParamType
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="array")]
        Array,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="boolean")]
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code")]
        Code,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="doc")]
        Doc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="excel")]
        Excel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="integer")]
        Integer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="number")]
        Number,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="object")]
        Object,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ppt")]
        Ppt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="string")]
        String,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="svg")]
        Svg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="time")]
        Time,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="txt")]
        Txt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video")]
        Video,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice")]
        Voice,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zip")]
        Zip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType value)
        {
            return value switch
            {
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Array => "array",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Audio => "audio",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Boolean => "boolean",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Code => "code",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Default => "default",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Doc => "doc",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Excel => "excel",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.File => "file",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Image => "image",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Integer => "integer",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Number => "number",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Object => "object",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Ppt => "ppt",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.String => "string",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Svg => "svg",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Time => "time",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Txt => "txt",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Video => "video",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Voice => "voice",
                PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType? ToEnum(string value)
        {
            return value switch
            {
                "array" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Array,
                "audio" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Audio,
                "boolean" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Boolean,
                "code" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Code,
                "default" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Default,
                "doc" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Doc,
                "excel" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Excel,
                "file" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.File,
                "image" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Image,
                "integer" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Integer,
                "number" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Number,
                "object" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Object,
                "ppt" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Ppt,
                "string" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.String,
                "svg" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Svg,
                "time" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Time,
                "txt" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Txt,
                "video" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Video,
                "voice" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Voice,
                "zip" => PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.Zip,
                _ => null,
            };
        }
    }
}