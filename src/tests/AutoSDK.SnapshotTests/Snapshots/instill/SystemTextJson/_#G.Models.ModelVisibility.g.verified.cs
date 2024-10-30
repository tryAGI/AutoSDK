//HintName: G.Models.ModelVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Visibility defines who can access the model.<br/>
    ///  - VISIBILITY_PRIVATE: Only the owner can see the model.<br/>
    ///  - VISIBILITY_PUBLIC: Other users can see the model.
    /// </summary>
    public enum ModelVisibility
    {
        /// <summary>
        /// Only the owner can see the model.
        /// </summary>
        VISIBILITYPRIVATE,
        /// <summary>
        /// Other users can see the model.
        /// </summary>
        VISIBILITYPUBLIC,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelVisibility value)
        {
            return value switch
            {
                ModelVisibility.VISIBILITYPRIVATE => "VISIBILITY_PRIVATE",
                ModelVisibility.VISIBILITYPUBLIC => "VISIBILITY_PUBLIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelVisibility? ToEnum(string value)
        {
            return value switch
            {
                "VISIBILITY_PRIVATE" => ModelVisibility.VISIBILITYPRIVATE,
                "VISIBILITY_PUBLIC" => ModelVisibility.VISIBILITYPUBLIC,
                _ => null,
            };
        }
    }
}