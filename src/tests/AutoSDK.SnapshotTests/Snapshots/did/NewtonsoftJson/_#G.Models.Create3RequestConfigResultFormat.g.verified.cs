//HintName: G.Models.Create3RequestConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The file format of the result. If result_url is provided, result_format must match the format of the result_url.<br/>
    /// Example: mp4
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Create3RequestConfigResultFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mov")]
        Mov,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp4")]
        Mp4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webm")]
        Webm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Create3RequestConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create3RequestConfigResultFormat value)
        {
            return value switch
            {
                Create3RequestConfigResultFormat.Mov => "mov",
                Create3RequestConfigResultFormat.Mp4 => "mp4",
                Create3RequestConfigResultFormat.Webm => "webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create3RequestConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => Create3RequestConfigResultFormat.Mov,
                "mp4" => Create3RequestConfigResultFormat.Mp4,
                "webm" => Create3RequestConfigResultFormat.Webm,
                _ => null,
            };
        }
    }
}