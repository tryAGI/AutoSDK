//HintName: G.Models.ModelAssetTextureTypes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When training model assets these are the texture types available to use.<br/>
    /// Default Value: NORMAL
    /// </summary>
    public enum ModelAssetTextureTypes
    {
        /// <summary>
        /// 
        /// </summary>
        Albedo,
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Roughness,
        /// <summary>
        /// 
        /// </summary>
        Displacement,
        /// <summary>
        /// 
        /// </summary>
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