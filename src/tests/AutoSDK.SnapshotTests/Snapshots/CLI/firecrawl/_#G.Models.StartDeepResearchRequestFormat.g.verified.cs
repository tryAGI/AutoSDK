//HintName: G.Models.StartDeepResearchRequestFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: [markdown]
    /// </summary>
    public enum StartDeepResearchRequestFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Branding,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Markdown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StartDeepResearchRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartDeepResearchRequestFormat value)
        {
            return value switch
            {
                StartDeepResearchRequestFormat.Branding => "branding",
                StartDeepResearchRequestFormat.Json => "json",
                StartDeepResearchRequestFormat.Markdown => "markdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartDeepResearchRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "branding" => StartDeepResearchRequestFormat.Branding,
                "json" => StartDeepResearchRequestFormat.Json,
                "markdown" => StartDeepResearchRequestFormat.Markdown,
                _ => null,
            };
        }
    }
}