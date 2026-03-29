//HintName: G.Models.PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 参数类型，来源于OpenAPIParamType
    /// </summary>
    public enum PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType
    {
        /// <summary>
        /// 
        /// </summary>
        Array,
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Doc,
        /// <summary>
        /// 
        /// </summary>
        Excel,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Integer,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Object,
        /// <summary>
        /// 
        /// </summary>
        Ppt,
        /// <summary>
        /// 
        /// </summary>
        String,
        /// <summary>
        /// 
        /// </summary>
        Svg,
        /// <summary>
        /// 
        /// </summary>
        Time,
        /// <summary>
        /// 
        /// </summary>
        Txt,
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        Voice,
        /// <summary>
        /// 
        /// </summary>
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