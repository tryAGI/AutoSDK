//HintName: G.Models.OpenAPIParamType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAPIParamType
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
    public static class OpenAPIParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAPIParamType value)
        {
            return value switch
            {
                OpenAPIParamType.Array => "array",
                OpenAPIParamType.Audio => "audio",
                OpenAPIParamType.Boolean => "boolean",
                OpenAPIParamType.Code => "code",
                OpenAPIParamType.Default => "default",
                OpenAPIParamType.Doc => "doc",
                OpenAPIParamType.Excel => "excel",
                OpenAPIParamType.File => "file",
                OpenAPIParamType.Image => "image",
                OpenAPIParamType.Integer => "integer",
                OpenAPIParamType.Number => "number",
                OpenAPIParamType.Object => "object",
                OpenAPIParamType.Ppt => "ppt",
                OpenAPIParamType.String => "string",
                OpenAPIParamType.Svg => "svg",
                OpenAPIParamType.Time => "time",
                OpenAPIParamType.Txt => "txt",
                OpenAPIParamType.Video => "video",
                OpenAPIParamType.Voice => "voice",
                OpenAPIParamType.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAPIParamType? ToEnum(string value)
        {
            return value switch
            {
                "array" => OpenAPIParamType.Array,
                "audio" => OpenAPIParamType.Audio,
                "boolean" => OpenAPIParamType.Boolean,
                "code" => OpenAPIParamType.Code,
                "default" => OpenAPIParamType.Default,
                "doc" => OpenAPIParamType.Doc,
                "excel" => OpenAPIParamType.Excel,
                "file" => OpenAPIParamType.File,
                "image" => OpenAPIParamType.Image,
                "integer" => OpenAPIParamType.Integer,
                "number" => OpenAPIParamType.Number,
                "object" => OpenAPIParamType.Object,
                "ppt" => OpenAPIParamType.Ppt,
                "string" => OpenAPIParamType.String,
                "svg" => OpenAPIParamType.Svg,
                "time" => OpenAPIParamType.Time,
                "txt" => OpenAPIParamType.Txt,
                "video" => OpenAPIParamType.Video,
                "voice" => OpenAPIParamType.Voice,
                "zip" => OpenAPIParamType.Zip,
                _ => null,
            };
        }
    }
}