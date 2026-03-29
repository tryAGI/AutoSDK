//HintName: G.Models.TargetFormatRemesh.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TargetFormatRemesh
    {
        /// <summary>
        /// 
        /// </summary>
        Blend,
        /// <summary>
        /// 
        /// </summary>
        Fbx,
        /// <summary>
        /// 
        /// </summary>
        Glb,
        /// <summary>
        /// 
        /// </summary>
        Obj,
        /// <summary>
        /// 
        /// </summary>
        Stl,
        /// <summary>
        /// 
        /// </summary>
        Usdz,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TargetFormatRemeshExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TargetFormatRemesh value)
        {
            return value switch
            {
                TargetFormatRemesh.Blend => "blend",
                TargetFormatRemesh.Fbx => "fbx",
                TargetFormatRemesh.Glb => "glb",
                TargetFormatRemesh.Obj => "obj",
                TargetFormatRemesh.Stl => "stl",
                TargetFormatRemesh.Usdz => "usdz",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TargetFormatRemesh? ToEnum(string value)
        {
            return value switch
            {
                "blend" => TargetFormatRemesh.Blend,
                "fbx" => TargetFormatRemesh.Fbx,
                "glb" => TargetFormatRemesh.Glb,
                "obj" => TargetFormatRemesh.Obj,
                "stl" => TargetFormatRemesh.Stl,
                "usdz" => TargetFormatRemesh.Usdz,
                _ => null,
            };
        }
    }
}