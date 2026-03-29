//HintName: G.Models.PageTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls what kind of layout the page is rendered in<br/>
    /// Default Value: contained
    /// </summary>
    public enum PageTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        Contained,
        /// <summary>
        /// 
        /// </summary>
        FullWithinLayout,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
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