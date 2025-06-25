//HintName: G.Models.ModelPublicServiceListModelDefinitionsView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelPublicServiceListModelDefinitionsView
    {
        /// <summary>
        /// Default view, only includes basic information (omits `model_spec`).
        /// </summary>
        VIEWBASIC,
        /// <summary>
        /// Full representation.
        /// </summary>
        VIEWFULL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelPublicServiceListModelDefinitionsViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelPublicServiceListModelDefinitionsView value)
        {
            return value switch
            {
                ModelPublicServiceListModelDefinitionsView.VIEWBASIC => "VIEW_BASIC",
                ModelPublicServiceListModelDefinitionsView.VIEWFULL => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelPublicServiceListModelDefinitionsView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => ModelPublicServiceListModelDefinitionsView.VIEWBASIC,
                "VIEW_FULL" => ModelPublicServiceListModelDefinitionsView.VIEWFULL,
                _ => null,
            };
        }
    }
}