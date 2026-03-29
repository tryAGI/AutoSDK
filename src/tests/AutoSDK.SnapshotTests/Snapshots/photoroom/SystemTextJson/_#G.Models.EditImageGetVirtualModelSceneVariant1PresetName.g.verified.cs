//HintName: G.Models.EditImageGetVirtualModelSceneVariant1PresetName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Name of the preset scene.
    /// </summary>
    public enum EditImageGetVirtualModelSceneVariant1PresetName
    {
        /// <summary>
        /// 
        /// </summary>
        Asiancity,
        /// <summary>
        /// 
        /// </summary>
        Beach,
        /// <summary>
        /// 
        /// </summary>
        Bedroom,
        /// <summary>
        /// 
        /// </summary>
        Businessdistrict,
        /// <summary>
        /// 
        /// </summary>
        Cafe,
        /// <summary>
        /// 
        /// </summary>
        Coloredstudio,
        /// <summary>
        /// 
        /// </summary>
        Concretestudio,
        /// <summary>
        /// 
        /// </summary>
        Countryside,
        /// <summary>
        /// 
        /// </summary>
        Desert,
        /// <summary>
        /// 
        /// </summary>
        Factory,
        /// <summary>
        /// 
        /// </summary>
        Flowers,
        /// <summary>
        /// 
        /// </summary>
        Forest,
        /// <summary>
        /// 
        /// </summary>
        Goldenlight,
        /// <summary>
        /// 
        /// </summary>
        Latincity,
        /// <summary>
        /// 
        /// </summary>
        Library,
        /// <summary>
        /// 
        /// </summary>
        Mountain,
        /// <summary>
        /// 
        /// </summary>
        Nightlights,
        /// <summary>
        /// 
        /// </summary>
        Pool,
        /// <summary>
        /// 
        /// </summary>
        Random,
        /// <summary>
        /// 
        /// </summary>
        Street,
        /// <summary>
        /// 
        /// </summary>
        Studio,
        /// <summary>
        /// 
        /// </summary>
        Sunset,
        /// <summary>
        /// 
        /// </summary>
        Tropical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetVirtualModelSceneVariant1PresetNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetVirtualModelSceneVariant1PresetName value)
        {
            return value switch
            {
                EditImageGetVirtualModelSceneVariant1PresetName.Asiancity => "asiancity",
                EditImageGetVirtualModelSceneVariant1PresetName.Beach => "beach",
                EditImageGetVirtualModelSceneVariant1PresetName.Bedroom => "bedroom",
                EditImageGetVirtualModelSceneVariant1PresetName.Businessdistrict => "businessdistrict",
                EditImageGetVirtualModelSceneVariant1PresetName.Cafe => "cafe",
                EditImageGetVirtualModelSceneVariant1PresetName.Coloredstudio => "coloredstudio",
                EditImageGetVirtualModelSceneVariant1PresetName.Concretestudio => "concretestudio",
                EditImageGetVirtualModelSceneVariant1PresetName.Countryside => "countryside",
                EditImageGetVirtualModelSceneVariant1PresetName.Desert => "desert",
                EditImageGetVirtualModelSceneVariant1PresetName.Factory => "factory",
                EditImageGetVirtualModelSceneVariant1PresetName.Flowers => "flowers",
                EditImageGetVirtualModelSceneVariant1PresetName.Forest => "forest",
                EditImageGetVirtualModelSceneVariant1PresetName.Goldenlight => "goldenlight",
                EditImageGetVirtualModelSceneVariant1PresetName.Latincity => "latincity",
                EditImageGetVirtualModelSceneVariant1PresetName.Library => "library",
                EditImageGetVirtualModelSceneVariant1PresetName.Mountain => "mountain",
                EditImageGetVirtualModelSceneVariant1PresetName.Nightlights => "nightlights",
                EditImageGetVirtualModelSceneVariant1PresetName.Pool => "pool",
                EditImageGetVirtualModelSceneVariant1PresetName.Random => "random",
                EditImageGetVirtualModelSceneVariant1PresetName.Street => "street",
                EditImageGetVirtualModelSceneVariant1PresetName.Studio => "studio",
                EditImageGetVirtualModelSceneVariant1PresetName.Sunset => "sunset",
                EditImageGetVirtualModelSceneVariant1PresetName.Tropical => "tropical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetVirtualModelSceneVariant1PresetName? ToEnum(string value)
        {
            return value switch
            {
                "asiancity" => EditImageGetVirtualModelSceneVariant1PresetName.Asiancity,
                "beach" => EditImageGetVirtualModelSceneVariant1PresetName.Beach,
                "bedroom" => EditImageGetVirtualModelSceneVariant1PresetName.Bedroom,
                "businessdistrict" => EditImageGetVirtualModelSceneVariant1PresetName.Businessdistrict,
                "cafe" => EditImageGetVirtualModelSceneVariant1PresetName.Cafe,
                "coloredstudio" => EditImageGetVirtualModelSceneVariant1PresetName.Coloredstudio,
                "concretestudio" => EditImageGetVirtualModelSceneVariant1PresetName.Concretestudio,
                "countryside" => EditImageGetVirtualModelSceneVariant1PresetName.Countryside,
                "desert" => EditImageGetVirtualModelSceneVariant1PresetName.Desert,
                "factory" => EditImageGetVirtualModelSceneVariant1PresetName.Factory,
                "flowers" => EditImageGetVirtualModelSceneVariant1PresetName.Flowers,
                "forest" => EditImageGetVirtualModelSceneVariant1PresetName.Forest,
                "goldenlight" => EditImageGetVirtualModelSceneVariant1PresetName.Goldenlight,
                "latincity" => EditImageGetVirtualModelSceneVariant1PresetName.Latincity,
                "library" => EditImageGetVirtualModelSceneVariant1PresetName.Library,
                "mountain" => EditImageGetVirtualModelSceneVariant1PresetName.Mountain,
                "nightlights" => EditImageGetVirtualModelSceneVariant1PresetName.Nightlights,
                "pool" => EditImageGetVirtualModelSceneVariant1PresetName.Pool,
                "random" => EditImageGetVirtualModelSceneVariant1PresetName.Random,
                "street" => EditImageGetVirtualModelSceneVariant1PresetName.Street,
                "studio" => EditImageGetVirtualModelSceneVariant1PresetName.Studio,
                "sunset" => EditImageGetVirtualModelSceneVariant1PresetName.Sunset,
                "tropical" => EditImageGetVirtualModelSceneVariant1PresetName.Tropical,
                _ => null,
            };
        }
    }
}