//HintName: G.Models.CreatePagesRequestTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls what kind of layout the page is rendered in<br/>
    /// Default Value: contained
    /// </summary>
    public enum CreatePagesRequestTemplate
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
    public static class CreatePagesRequestTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePagesRequestTemplate value)
        {
            return value switch
            {
                CreatePagesRequestTemplate.Contained => "contained",
                CreatePagesRequestTemplate.FullWithinLayout => "full_within_layout",
                CreatePagesRequestTemplate.Json => "json",
                CreatePagesRequestTemplate.NavBarIncluded => "nav_bar_included",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePagesRequestTemplate? ToEnum(string value)
        {
            return value switch
            {
                "contained" => CreatePagesRequestTemplate.Contained,
                "full_within_layout" => CreatePagesRequestTemplate.FullWithinLayout,
                "json" => CreatePagesRequestTemplate.Json,
                "nav_bar_included" => CreatePagesRequestTemplate.NavBarIncluded,
                _ => null,
            };
        }
    }
}