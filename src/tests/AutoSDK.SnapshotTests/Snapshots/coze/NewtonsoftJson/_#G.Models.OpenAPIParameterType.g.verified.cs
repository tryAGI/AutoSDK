//HintName: G.Models.OpenAPIParameterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 参数类型，来源于OpenAPIParamType
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAPIParameterType
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