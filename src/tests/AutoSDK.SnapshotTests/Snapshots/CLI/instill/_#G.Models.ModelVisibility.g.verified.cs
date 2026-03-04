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
        VisibilityPrivate,
        /// <summary>
        /// Other users can see the model.
        /// </summary>
        VisibilityPublic,
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
                ModelVisibility.VisibilityPrivate => "VISIBILITY_PRIVATE",
                ModelVisibility.VisibilityPublic => "VISIBILITY_PUBLIC",
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
                "VISIBILITY_PRIVATE" => ModelVisibility.VisibilityPrivate,
                "VISIBILITY_PUBLIC" => ModelVisibility.VisibilityPublic,
                _ => null,
            };
        }
    }
}