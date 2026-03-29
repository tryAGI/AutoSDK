//HintName: G.Models.OpenAPIParamType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAPIParamType
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