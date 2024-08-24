//HintName: G.Models.MODELASSETTEXTURETYPES.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When training model assets these are the texture types available to use.<br/>
    /// Default Value: NORMAL
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MODELASSETTEXTURETYPES
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ALBEDO")]
        ALBEDO,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NORMAL")]
        NORMAL,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ROUGHNESS")]
        ROUGHNESS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DISPLACEMENT")]
        DISPLACEMENT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HDRP_MASK")]
        HDRPMASK,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MODELASSETTEXTURETYPESExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MODELASSETTEXTURETYPES value)
        {
            return value switch
            {
                MODELASSETTEXTURETYPES.ALBEDO => "ALBEDO",
                MODELASSETTEXTURETYPES.NORMAL => "NORMAL",
                MODELASSETTEXTURETYPES.ROUGHNESS => "ROUGHNESS",
                MODELASSETTEXTURETYPES.DISPLACEMENT => "DISPLACEMENT",
                MODELASSETTEXTURETYPES.HDRPMASK => "HDRP_MASK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MODELASSETTEXTURETYPES? ToEnum(string value)
        {
            return value switch
            {
                "ALBEDO" => MODELASSETTEXTURETYPES.ALBEDO,
                "NORMAL" => MODELASSETTEXTURETYPES.NORMAL,
                "ROUGHNESS" => MODELASSETTEXTURETYPES.ROUGHNESS,
                "DISPLACEMENT" => MODELASSETTEXTURETYPES.DISPLACEMENT,
                "HDRP_MASK" => MODELASSETTEXTURETYPES.HDRPMASK,
                _ => null,
            };
        }
    }
}