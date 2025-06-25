//HintName: G.Models.ModelPublicServiceGetModelOperationView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelPublicServiceGetModelOperationView
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
    public static class ModelPublicServiceGetModelOperationViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelPublicServiceGetModelOperationView value)
        {
            return value switch
            {
                ModelPublicServiceGetModelOperationView.VIEWBASIC => "VIEW_BASIC",
                ModelPublicServiceGetModelOperationView.VIEWFULL => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelPublicServiceGetModelOperationView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => ModelPublicServiceGetModelOperationView.VIEWBASIC,
                "VIEW_FULL" => ModelPublicServiceGetModelOperationView.VIEWFULL,
                _ => null,
            };
        }
    }
}