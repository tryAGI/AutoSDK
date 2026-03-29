//HintName: G.Models.PostOrgOwnerProjectNewRequestConfigLogVisibilitySetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostOrgOwnerProjectNewRequestConfigLogVisibilitySetting
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
    public static class PostOrgOwnerProjectNewRequestConfigLogVisibilitySettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostOrgOwnerProjectNewRequestConfigLogVisibilitySetting value)
        {
            return value switch
            {
                PostOrgOwnerProjectNewRequestConfigLogVisibilitySetting.DontStoreData => "dont_store_data",
                PostOrgOwnerProjectNewRequestConfigLogVisibilitySetting.ShowAll => "show_all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostOrgOwnerProjectNewRequestConfigLogVisibilitySetting? ToEnum(string value)
        {
            return value switch
            {
                "dont_store_data" => PostOrgOwnerProjectNewRequestConfigLogVisibilitySetting.DontStoreData,
                "show_all" => PostOrgOwnerProjectNewRequestConfigLogVisibilitySetting.ShowAll,
                _ => null,
            };
        }
    }
}