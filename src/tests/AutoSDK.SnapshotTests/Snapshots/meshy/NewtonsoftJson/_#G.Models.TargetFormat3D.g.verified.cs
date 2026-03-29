//HintName: G.Models.TargetFormat3D.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TargetFormat3D
    {
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
    public static class TargetFormat3DExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TargetFormat3D value)
        {
            return value switch
            {
                TargetFormat3D.Fbx => "fbx",
                TargetFormat3D.Glb => "glb",
                TargetFormat3D.Obj => "obj",
                TargetFormat3D.Stl => "stl",
                TargetFormat3D.Usdz => "usdz",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TargetFormat3D? ToEnum(string value)
        {
            return value switch
            {
                "fbx" => TargetFormat3D.Fbx,
                "glb" => TargetFormat3D.Glb,
                "obj" => TargetFormat3D.Obj,
                "stl" => TargetFormat3D.Stl,
                "usdz" => TargetFormat3D.Usdz,
                _ => null,
            };
        }
    }
}