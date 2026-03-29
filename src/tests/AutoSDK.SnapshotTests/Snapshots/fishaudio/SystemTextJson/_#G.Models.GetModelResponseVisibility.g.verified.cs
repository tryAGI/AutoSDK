//HintName: G.Models.GetModelResponseVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelResponseVisibility
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
    public static class GetModelResponseVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelResponseVisibility value)
        {
            return value switch
            {
                GetModelResponseVisibility.Private => "private",
                GetModelResponseVisibility.Public => "public",
                GetModelResponseVisibility.Unlist => "unlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelResponseVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => GetModelResponseVisibility.Private,
                "public" => GetModelResponseVisibility.Public,
                "unlist" => GetModelResponseVisibility.Unlist,
                _ => null,
            };
        }
    }
}