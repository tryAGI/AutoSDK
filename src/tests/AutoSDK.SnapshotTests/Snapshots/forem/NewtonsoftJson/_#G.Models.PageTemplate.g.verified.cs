//HintName: G.Models.PageTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls what kind of layout the page is rendered in<br/>
    /// Default Value: contained
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PageTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="contained")]
        Contained,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="full_within_layout")]
        FullWithinLayout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nav_bar_included")]
        NavBarIncluded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PageTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PageTemplate value)
        {
            return value switch
            {
                PageTemplate.Contained => "contained",
                PageTemplate.FullWithinLayout => "full_within_layout",
                PageTemplate.Json => "json",
                PageTemplate.NavBarIncluded => "nav_bar_included",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PageTemplate? ToEnum(string value)
        {
            return value switch
            {
                "contained" => PageTemplate.Contained,
                "full_within_layout" => PageTemplate.FullWithinLayout,
                "json" => PageTemplate.Json,
                "nav_bar_included" => PageTemplate.NavBarIncluded,
                _ => null,
            };
        }
    }
}