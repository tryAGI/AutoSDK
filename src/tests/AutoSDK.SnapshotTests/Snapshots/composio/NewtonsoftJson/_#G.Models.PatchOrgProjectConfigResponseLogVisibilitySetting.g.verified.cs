//HintName: G.Models.PatchOrgProjectConfigResponseLogVisibilitySetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PatchOrgProjectConfigResponseLogVisibilitySetting
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dont_store_data")]
        DontStoreData,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="show_all")]
        ShowAll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchOrgProjectConfigResponseLogVisibilitySettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrgProjectConfigResponseLogVisibilitySetting value)
        {
            return value switch
            {
                PatchOrgProjectConfigResponseLogVisibilitySetting.DontStoreData => "dont_store_data",
                PatchOrgProjectConfigResponseLogVisibilitySetting.ShowAll => "show_all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrgProjectConfigResponseLogVisibilitySetting? ToEnum(string value)
        {
            return value switch
            {
                "dont_store_data" => PatchOrgProjectConfigResponseLogVisibilitySetting.DontStoreData,
                "show_all" => PatchOrgProjectConfigResponseLogVisibilitySetting.ShowAll,
                _ => null,
            };
        }
    }
}