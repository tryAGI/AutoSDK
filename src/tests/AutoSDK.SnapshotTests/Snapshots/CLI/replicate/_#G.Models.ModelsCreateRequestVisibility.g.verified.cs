//HintName: G.Models.ModelsCreateRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether the model should be public or private. A public model can be viewed and run by anyone, whereas a private model can be viewed and run only by the user or organization members that own the model.
    /// </summary>
    public enum ModelsCreateRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsCreateRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsCreateRequestVisibility value)
        {
            return value switch
            {
                ModelsCreateRequestVisibility.Private => "private",
                ModelsCreateRequestVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsCreateRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => ModelsCreateRequestVisibility.Private,
                "public" => ModelsCreateRequestVisibility.Public,
                _ => null,
            };
        }
    }
}