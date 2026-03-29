//HintName: G.Models.OpenAPIParameterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 参数类型，来源于OpenAPIParamType
    /// </summary>
    public enum OpenAPIParameterType
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
    public static class OpenAPIParameterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAPIParameterType value)
        {
            return value switch
            {
                OpenAPIParameterType.Array => "array",
                OpenAPIParameterType.Audio => "audio",
                OpenAPIParameterType.Boolean => "boolean",
                OpenAPIParameterType.Code => "code",
                OpenAPIParameterType.Default => "default",
                OpenAPIParameterType.Doc => "doc",
                OpenAPIParameterType.Excel => "excel",
                OpenAPIParameterType.File => "file",
                OpenAPIParameterType.Image => "image",
                OpenAPIParameterType.Integer => "integer",
                OpenAPIParameterType.Number => "number",
                OpenAPIParameterType.Object => "object",
                OpenAPIParameterType.Ppt => "ppt",
                OpenAPIParameterType.String => "string",
                OpenAPIParameterType.Svg => "svg",
                OpenAPIParameterType.Time => "time",
                OpenAPIParameterType.Txt => "txt",
                OpenAPIParameterType.Video => "video",
                OpenAPIParameterType.Voice => "voice",
                OpenAPIParameterType.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAPIParameterType? ToEnum(string value)
        {
            return value switch
            {
                "array" => OpenAPIParameterType.Array,
                "audio" => OpenAPIParameterType.Audio,
                "boolean" => OpenAPIParameterType.Boolean,
                "code" => OpenAPIParameterType.Code,
                "default" => OpenAPIParameterType.Default,
                "doc" => OpenAPIParameterType.Doc,
                "excel" => OpenAPIParameterType.Excel,
                "file" => OpenAPIParameterType.File,
                "image" => OpenAPIParameterType.Image,
                "integer" => OpenAPIParameterType.Integer,
                "number" => OpenAPIParameterType.Number,
                "object" => OpenAPIParameterType.Object,
                "ppt" => OpenAPIParameterType.Ppt,
                "string" => OpenAPIParameterType.String,
                "svg" => OpenAPIParameterType.Svg,
                "time" => OpenAPIParameterType.Time,
                "txt" => OpenAPIParameterType.Txt,
                "video" => OpenAPIParameterType.Video,
                "voice" => OpenAPIParameterType.Voice,
                "zip" => OpenAPIParameterType.Zip,
                _ => null,
            };
        }
    }
}