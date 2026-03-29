//HintName: G.Models.GetOrgProjectConfigResponseLogVisibilitySetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrgProjectConfigResponseLogVisibilitySetting
    {
        /// <summary>
        /// 
        /// </summary>
        DontStoreData,
        /// <summary>
        /// 
        /// </summary>
        ShowAll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrgProjectConfigResponseLogVisibilitySettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrgProjectConfigResponseLogVisibilitySetting value)
        {
            return value switch
            {
                GetOrgProjectConfigResponseLogVisibilitySetting.DontStoreData => "dont_store_data",
                GetOrgProjectConfigResponseLogVisibilitySetting.ShowAll => "show_all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrgProjectConfigResponseLogVisibilitySetting? ToEnum(string value)
        {
            return value switch
            {
                "dont_store_data" => GetOrgProjectConfigResponseLogVisibilitySetting.DontStoreData,
                "show_all" => GetOrgProjectConfigResponseLogVisibilitySetting.ShowAll,
                _ => null,
            };
        }
    }
}