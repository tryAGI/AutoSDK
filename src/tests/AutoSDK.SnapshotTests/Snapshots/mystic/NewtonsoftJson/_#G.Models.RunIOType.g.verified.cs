//HintName: G.Models.RunIOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunIOType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="array")]
        Array,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="boolean")]
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dictionary")]
        Dictionary,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fp")]
        Fp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="integer")]
        Integer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pkl")]
        Pkl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stream")]
        Stream,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="string")]
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunIOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunIOType value)
        {
            return value switch
            {
                RunIOType.Array => "array",
                RunIOType.Boolean => "boolean",
                RunIOType.Dictionary => "dictionary",
                RunIOType.File => "file",
                RunIOType.Fp => "fp",
                RunIOType.Integer => "integer",
                RunIOType.None => "none",
                RunIOType.Pkl => "pkl",
                RunIOType.Stream => "stream",
                RunIOType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunIOType? ToEnum(string value)
        {
            return value switch
            {
                "array" => RunIOType.Array,
                "boolean" => RunIOType.Boolean,
                "dictionary" => RunIOType.Dictionary,
                "file" => RunIOType.File,
                "fp" => RunIOType.Fp,
                "integer" => RunIOType.Integer,
                "none" => RunIOType.None,
                "pkl" => RunIOType.Pkl,
                "stream" => RunIOType.Stream,
                "string" => RunIOType.String,
                _ => null,
            };
        }
    }
}