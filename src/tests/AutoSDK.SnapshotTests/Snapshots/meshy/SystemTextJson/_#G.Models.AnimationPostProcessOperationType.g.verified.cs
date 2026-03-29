//HintName: G.Models.AnimationPostProcessOperationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnimationPostProcessOperationType
    {
        /// <summary>
        /// 
        /// </summary>
        ChangeFps,
        /// <summary>
        /// 
        /// </summary>
        ExtractArmature,
        /// <summary>
        /// 
        /// </summary>
        Fbx2usdz,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnimationPostProcessOperationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnimationPostProcessOperationType value)
        {
            return value switch
            {
                AnimationPostProcessOperationType.ChangeFps => "change_fps",
                AnimationPostProcessOperationType.ExtractArmature => "extract_armature",
                AnimationPostProcessOperationType.Fbx2usdz => "fbx2usdz",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnimationPostProcessOperationType? ToEnum(string value)
        {
            return value switch
            {
                "change_fps" => AnimationPostProcessOperationType.ChangeFps,
                "extract_armature" => AnimationPostProcessOperationType.ExtractArmature,
                "fbx2usdz" => AnimationPostProcessOperationType.Fbx2usdz,
                _ => null,
            };
        }
    }
}