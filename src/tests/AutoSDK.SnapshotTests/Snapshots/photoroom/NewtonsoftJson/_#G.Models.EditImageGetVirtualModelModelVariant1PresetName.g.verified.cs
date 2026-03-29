//HintName: G.Models.EditImageGetVirtualModelModelVariant1PresetName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Name of the preset model.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetVirtualModelModelVariant1PresetName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="alex")]
        Alex,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ava")]
        Ava,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="avery")]
        Avery,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="casey")]
        Casey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="emma")]
        Emma,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fiona")]
        Fiona,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jackson")]
        Jackson,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jordan")]
        Jordan,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="julia")]
        Julia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kendall")]
        Kendall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lena")]
        Lena,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="maya")]
        Maya,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reece")]
        Reece,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sam")]
        Sam,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sophia")]
        Sophia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="taylor")]
        Taylor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zoe")]
        Zoe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetVirtualModelModelVariant1PresetNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetVirtualModelModelVariant1PresetName value)
        {
            return value switch
            {
                EditImageGetVirtualModelModelVariant1PresetName.Alex => "alex",
                EditImageGetVirtualModelModelVariant1PresetName.Ava => "ava",
                EditImageGetVirtualModelModelVariant1PresetName.Avery => "avery",
                EditImageGetVirtualModelModelVariant1PresetName.Casey => "casey",
                EditImageGetVirtualModelModelVariant1PresetName.Emma => "emma",
                EditImageGetVirtualModelModelVariant1PresetName.Fiona => "fiona",
                EditImageGetVirtualModelModelVariant1PresetName.Jackson => "jackson",
                EditImageGetVirtualModelModelVariant1PresetName.Jordan => "jordan",
                EditImageGetVirtualModelModelVariant1PresetName.Julia => "julia",
                EditImageGetVirtualModelModelVariant1PresetName.Kendall => "kendall",
                EditImageGetVirtualModelModelVariant1PresetName.Lena => "lena",
                EditImageGetVirtualModelModelVariant1PresetName.Maya => "maya",
                EditImageGetVirtualModelModelVariant1PresetName.Reece => "reece",
                EditImageGetVirtualModelModelVariant1PresetName.Sam => "sam",
                EditImageGetVirtualModelModelVariant1PresetName.Sophia => "sophia",
                EditImageGetVirtualModelModelVariant1PresetName.Taylor => "taylor",
                EditImageGetVirtualModelModelVariant1PresetName.Zoe => "zoe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetVirtualModelModelVariant1PresetName? ToEnum(string value)
        {
            return value switch
            {
                "alex" => EditImageGetVirtualModelModelVariant1PresetName.Alex,
                "ava" => EditImageGetVirtualModelModelVariant1PresetName.Ava,
                "avery" => EditImageGetVirtualModelModelVariant1PresetName.Avery,
                "casey" => EditImageGetVirtualModelModelVariant1PresetName.Casey,
                "emma" => EditImageGetVirtualModelModelVariant1PresetName.Emma,
                "fiona" => EditImageGetVirtualModelModelVariant1PresetName.Fiona,
                "jackson" => EditImageGetVirtualModelModelVariant1PresetName.Jackson,
                "jordan" => EditImageGetVirtualModelModelVariant1PresetName.Jordan,
                "julia" => EditImageGetVirtualModelModelVariant1PresetName.Julia,
                "kendall" => EditImageGetVirtualModelModelVariant1PresetName.Kendall,
                "lena" => EditImageGetVirtualModelModelVariant1PresetName.Lena,
                "maya" => EditImageGetVirtualModelModelVariant1PresetName.Maya,
                "reece" => EditImageGetVirtualModelModelVariant1PresetName.Reece,
                "sam" => EditImageGetVirtualModelModelVariant1PresetName.Sam,
                "sophia" => EditImageGetVirtualModelModelVariant1PresetName.Sophia,
                "taylor" => EditImageGetVirtualModelModelVariant1PresetName.Taylor,
                "zoe" => EditImageGetVirtualModelModelVariant1PresetName.Zoe,
                _ => null,
            };
        }
    }
}