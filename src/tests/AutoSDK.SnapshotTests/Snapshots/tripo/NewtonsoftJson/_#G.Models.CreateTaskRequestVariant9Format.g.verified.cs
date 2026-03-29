//HintName: G.Models.CreateTaskRequestVariant9Format.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTaskRequestVariant9Format
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FBX")]
        Fbx,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GLTF")]
        Gltf,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OBJ")]
        Obj,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STL")]
        Stl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="USDZ")]
        Usdz,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant9FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant9Format value)
        {
            return value switch
            {
                CreateTaskRequestVariant9Format.Fbx => "FBX",
                CreateTaskRequestVariant9Format.Gltf => "GLTF",
                CreateTaskRequestVariant9Format.Obj => "OBJ",
                CreateTaskRequestVariant9Format.Stl => "STL",
                CreateTaskRequestVariant9Format.Usdz => "USDZ",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant9Format? ToEnum(string value)
        {
            return value switch
            {
                "FBX" => CreateTaskRequestVariant9Format.Fbx,
                "GLTF" => CreateTaskRequestVariant9Format.Gltf,
                "OBJ" => CreateTaskRequestVariant9Format.Obj,
                "STL" => CreateTaskRequestVariant9Format.Stl,
                "USDZ" => CreateTaskRequestVariant9Format.Usdz,
                _ => null,
            };
        }
    }
}