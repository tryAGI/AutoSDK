//HintName: G.Models.CreateTaskRequestVariant8Style.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTaskRequestVariant8Style
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lego")]
        Lego,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="minecraft")]
        Minecraft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voronoi")]
        Voronoi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voxel")]
        Voxel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant8StyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant8Style value)
        {
            return value switch
            {
                CreateTaskRequestVariant8Style.Lego => "lego",
                CreateTaskRequestVariant8Style.Minecraft => "minecraft",
                CreateTaskRequestVariant8Style.Voronoi => "voronoi",
                CreateTaskRequestVariant8Style.Voxel => "voxel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant8Style? ToEnum(string value)
        {
            return value switch
            {
                "lego" => CreateTaskRequestVariant8Style.Lego,
                "minecraft" => CreateTaskRequestVariant8Style.Minecraft,
                "voronoi" => CreateTaskRequestVariant8Style.Voronoi,
                "voxel" => CreateTaskRequestVariant8Style.Voxel,
                _ => null,
            };
        }
    }
}