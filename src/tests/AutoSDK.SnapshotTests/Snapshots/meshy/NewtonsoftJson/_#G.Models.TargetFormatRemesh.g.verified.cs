//HintName: G.Models.TargetFormatRemesh.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TargetFormatRemesh
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blend")]
        Blend,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fbx")]
        Fbx,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="glb")]
        Glb,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="obj")]
        Obj,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stl")]
        Stl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="usdz")]
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