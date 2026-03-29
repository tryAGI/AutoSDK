//HintName: G.Models.PatchOrgProjectConfigRequestLogVisibilitySetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PatchOrgProjectConfigRequestLogVisibilitySetting
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
    public static class PatchOrgProjectConfigRequestLogVisibilitySettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrgProjectConfigRequestLogVisibilitySetting value)
        {
            return value switch
            {
                PatchOrgProjectConfigRequestLogVisibilitySetting.DontStoreData => "dont_store_data",
                PatchOrgProjectConfigRequestLogVisibilitySetting.ShowAll => "show_all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrgProjectConfigRequestLogVisibilitySetting? ToEnum(string value)
        {
            return value switch
            {
                "dont_store_data" => PatchOrgProjectConfigRequestLogVisibilitySetting.DontStoreData,
                "show_all" => PatchOrgProjectConfigRequestLogVisibilitySetting.ShowAll,
                _ => null,
            };
        }
    }
}