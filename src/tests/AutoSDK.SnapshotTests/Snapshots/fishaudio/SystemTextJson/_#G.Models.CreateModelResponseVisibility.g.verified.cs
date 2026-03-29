//HintName: G.Models.CreateModelResponseVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelResponseVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Unlist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelResponseVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelResponseVisibility value)
        {
            return value switch
            {
                CreateModelResponseVisibility.Private => "private",
                CreateModelResponseVisibility.Public => "public",
                CreateModelResponseVisibility.Unlist => "unlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelResponseVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateModelResponseVisibility.Private,
                "public" => CreateModelResponseVisibility.Public,
                "unlist" => CreateModelResponseVisibility.Unlist,
                _ => null,
            };
        }
    }
}