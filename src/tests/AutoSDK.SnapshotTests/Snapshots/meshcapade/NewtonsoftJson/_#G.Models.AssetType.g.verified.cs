//HintName: G.Models.AssetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssetType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ANIMATION")]
        Animation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AVATAR")]
        Avatar,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="IMAGE")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="JSON")]
        Json,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MESH")]
        Mesh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MOTION")]
        Motion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="POSE_SEQUENCE")]
        PoseSequence,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SCENE")]
        Scene,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TEXTURE")]
        Texture,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIDEO")]
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetType value)
        {
            return value switch
            {
                AssetType.Animation => "ANIMATION",
                AssetType.Avatar => "AVATAR",
                AssetType.Image => "IMAGE",
                AssetType.Json => "JSON",
                AssetType.Mesh => "MESH",
                AssetType.Motion => "MOTION",
                AssetType.PoseSequence => "POSE_SEQUENCE",
                AssetType.Scene => "SCENE",
                AssetType.Texture => "TEXTURE",
                AssetType.Video => "VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetType? ToEnum(string value)
        {
            return value switch
            {
                "ANIMATION" => AssetType.Animation,
                "AVATAR" => AssetType.Avatar,
                "IMAGE" => AssetType.Image,
                "JSON" => AssetType.Json,
                "MESH" => AssetType.Mesh,
                "MOTION" => AssetType.Motion,
                "POSE_SEQUENCE" => AssetType.PoseSequence,
                "SCENE" => AssetType.Scene,
                "TEXTURE" => AssetType.Texture,
                "VIDEO" => AssetType.Video,
                _ => null,
            };
        }
    }
}