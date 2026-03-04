//HintName: G.Models.ModelAssetTextureTypes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When training model assets these are the texture types available to use.<br/>
    /// Default Value: NORMAL
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelAssetTextureTypes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ALBEDO")]
        Albedo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NORMAL")]
        Normal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ROUGHNESS")]
        Roughness,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DISPLACEMENT")]
        Displacement,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HDRP_MASK")]
        HdrpMask,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelAssetTextureTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelAssetTextureTypes value)
        {
            return value switch
            {
                ModelAssetTextureTypes.Albedo => "ALBEDO",
                ModelAssetTextureTypes.Normal => "NORMAL",
                ModelAssetTextureTypes.Roughness => "ROUGHNESS",
                ModelAssetTextureTypes.Displacement => "DISPLACEMENT",
                ModelAssetTextureTypes.HdrpMask => "HDRP_MASK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelAssetTextureTypes? ToEnum(string value)
        {
            return value switch
            {
                "ALBEDO" => ModelAssetTextureTypes.Albedo,
                "NORMAL" => ModelAssetTextureTypes.Normal,
                "ROUGHNESS" => ModelAssetTextureTypes.Roughness,
                "DISPLACEMENT" => ModelAssetTextureTypes.Displacement,
                "HDRP_MASK" => ModelAssetTextureTypes.HdrpMask,
                _ => null,
            };
        }
    }
}